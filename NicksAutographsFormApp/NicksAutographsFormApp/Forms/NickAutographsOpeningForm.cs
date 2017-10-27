using System;
using System.Windows.Forms;
using System.Linq;

//installed add on determine in future if vs is slower https://marketplace.visualstudio.com/items?itemName=Skybladev2.Coutline2015
namespace NicksAutographsFormApp
{
    public partial class NickAutographsOpeningForm : Form 
    {
        string flickrLink = "https://www.flickr.com/photos/152389030@N07/";
            //https://www.flickr.com/photos/152389030@N07/37114027923/in/dateposted-public/
            //embed <a data-flickr-embed="true"  href="https://www.flickr.com/photos/152389030@N07/23931038608/in/dateposted-public/" title="20140906_144444"><img src="https://farm5.staticflickr.com/4504/23931038608_146c912199_k.jpg" width="1152" height="2048" alt="20140906_144444"></a><script async src="//embedr.flickr.com/assets/client-code.js" charset="utf-8"></script>

            //thought
            //https://www.flickr.com/photos/152389030@N07/20140906_144444/in/dateposted-public/
            //acutal: https://www.flickr.com/photos/152389030@N07/23931038608/in/dateposted-public/
        //form variables
        private string celbName = string.Empty;
        private string dateAquired = string.Empty;
        private string selectedCat = string.Empty;
        private string selectedItem = string.Empty;
        private string descrip = string.Empty;
        private string autoObtnBy = string.Empty;
        private string picLink = string.Empty;
        private const double DEFAULTCOST = 0.00;
        private double autoCost = DEFAULTCOST;
        private double itemCost = DEFAULTCOST;
        private string[] categories = new string[] { "Baseball", "Basketball", "Football", "Movies", "TV","Comedian", "Other" };
        private string[] items = new string[] { "Baseball", "Baseball Card", "Basketball Card", "Football Card", "Signature Card", "Index Card","Photo", "Other" };
        Boolean passedValidation = true;
        //ArrayList categories = new ArrayList("Baseball", "Basketball", "Football", "Movies", "Political", "Other"); takes objects

        public NickAutographsOpeningForm()
        {
            InitializeComponent();
            loadDropDowns();
            radioButtonMySelf.Checked= true;//default selection
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            celbName = txtBoxCelebrityName.Text.ToString();                                           
            // selectedItem = this.cmbBoxItem.GetItemText(this.cmbBoxItem.SelectedItem);
            //selectedCat= this.cmbBoxCategory.GetItemText(this.cmbBoxCategory.SelectedItem);
            selectedCat = cmbBoxCategory.Text.ToString();
            selectedItem = cmbBoxItem.Text.ToString();  

            //get the checked radio button 
            var checkedButton = groupBoxObtainedBy.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(rb => rb.Checked);
            autoObtnBy = checkedButton.Text.ToString();
           
            //lblError.Text = checkedButton.Text.ToString();
            //validation check
            vaildationCheck();
            if (passedValidation == false)
            {
                return;//exit method
            }
            //obj creation
            AutographItem myItem = new AutographItem();
            myItem.CelebName = celbName;
            myItem.SelectedCat = selectedCat;
            myItem.SelectedItem = selectedItem;
            myItem.AutoObtainedBy= autoObtnBy;           
            myItem.PicLink = picLink;
            myItem.Description = descrip;
            myItem.DateAquired = dateAquired;
            myItem.AutoCost = autoCost.ToString();
            myItem.ItemCost= itemCost.ToString();

            //write to DB     
            writeToDB(myItem);       

            //open new form
            //ConfirmationForm cform = new ConfirmationForm();
            //cform.Show();
             //MessageBox.Show("**Form Saved** \n '" +myItem.CelebName +"' \nSucesfully Added To Database");
            MessageBox.Show("**Form Saved** \n '" + myItem.CelebName + "' \nSucesfully Added To Database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //customize messagebox
                //https://msdn.microsoft.com/en-us/library/tewzaxwc(v=vs.110).aspx
                //https://msdn.microsoft.com/en-us/library/system.windows.forms.messageboxicon(v=vs.110).aspx
           
            //close this form
            this.Hide(); //https://stackoverflow.com/questions/2751076/closing-a-form-and-then-call-another-one

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();            
        }      
        private void checkDate()
        {     
                   
            if (dateTimePickerAutographAquired.Text == string.Empty)
            {                
                dateAquired = (DateTime.Today).ToString("MM/dd/yyyy");
            }
            else
            {
                dateAquired = dateTimePickerAutographAquired.Value.ToShortDateString();
            }
        }
        public string getDescription()
        {
            if (txtBoxDesc.Text == string.Empty)
            {
                descrip = "N/A";
            }
            else
            {
                descrip = txtBoxDesc.Text.ToString();
            }            
            return descrip;
        }
        private void writeToDB(AutographItem theItem)
        {
            DBConnection.recordToDb(theItem);
        }
        private void loadDropDowns()
        {
            foreach (string i in categories)
            {
                
                cmbBoxCategory.Items.Add(i.ToString());
                cmbBoxCategory.Text = i.ToString();
            }

            foreach (string i in items)
            {
                cmbBoxItem.Items.Add(i.ToString());
                cmbBoxItem.Text = i.ToString();
            }
        }
        private void btnShowDb_Click(object sender, EventArgs e)
        {
            DBForm myForm = new DBForm();
            myForm.Show();
        }
        private void checkName()
        {
            if (txtBoxCelebrityName.Text == string.Empty)
            {
                MessageBox.Show("Name Cannot be Blank");
                //return back to screen dont let submit
                passedValidation = false;
            }
        }
        private void checkCost()
        {           
            if (txtBoxItemCost.Text == string.Empty || txtBoxItemCost.Text==string.Empty)
            {
                itemCost = DEFAULTCOST;
            }
            else
            {
                double outAuto;
                double outItem;
                Boolean canCvtItem;
                Boolean canCvtAuto;
                canCvtItem = double.TryParse(txtBoxItemCost.Text, out outItem);
                canCvtAuto = double.TryParse(txtBoxAutoCost.Text, out outAuto);
                if (canCvtItem && canCvtAuto)
                {
                    itemCost = outItem;
                    autoCost= outAuto;
                }
                else if (canCvtItem)//allow blank auto cost
                {
                    itemCost = outItem;
                    autoCost = DEFAULTCOST;
                }
                else
                {
                    MessageBox.Show("Must Enter a Number for Item and Autograph Cost");                    
                    //return back to screen dont let submit
                    passedValidation = false;
                }
            }         
        }
        private void vaildationCheck()
        {
            checkName();
            checkCost();
            getDescription();
            checkDate();
            picLinkCheck();
        }
        private void picLinkCheck()
        {
        //    Dim userInput As String = textBoxUserInput.Text 'users number in string format
        //'Parse the userinput amount
        //If (Double.TryParse(userInput, userNum)) Then
        //    'is a number
        //    calcAmts(userNum)
        //ElseIf textBoxUserInput.Text = String.Empty Then 'if textbox is blank, default to 0            
        //    userNum = 0
        //    calcAmts(0)
        //Else 'Not a number
        //    MessageBox.Show("Not a Number", "Incorrect Input Error", MessageBoxButton.OK, MessageBoxImage.Error)
        //    'reset displayed amount
        //    textBoxUserInput.Text = String.Empty
        //    stringAmt = String.Empty
        //    Return
        //End If

            if (txtBoxPicLink.Text == string.Empty)
            {
                picLink = "N/A";
            }
            else
            {
                picLink = txtBoxPicLink.Text.ToString();
            }
        }

        private void btnCustShow_Click(object sender, EventArgs e)
        {
            CustomShowDB myCustDB = new CustomShowDB();
            myCustDB.Show();
        }
  
        private void btnPictures_Click(object sender, EventArgs e)
        {
            PicturesForm pf = new PicturesForm();
            pf.Show();
        }
    }
}
