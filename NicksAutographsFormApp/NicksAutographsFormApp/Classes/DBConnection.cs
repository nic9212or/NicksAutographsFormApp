using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NicksAutographsFormApp
{
    class DBConnection
    {
        //Manage connection

        //public static void recordToDb(string celbName, string selectedItem, string selectedCat, string descrip, string dateAquired, string autoCost, string itemCost, string autoObtainedBy, string picLink)
        public static void recordToDb(AutographItem myItem)
        {
            string connect = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;          
            SqlConnection conn = new SqlConnection(connect);
            try
            {
                conn.Open();

                //Get date and time
                String dateNow = DateTime.Now.ToString("M/d/yyyy h:mm:ss");
                String query = "INSERT INTO dbo.NicksAutographs (CelebrityName, Item, Category, Description, DateAquired, AutographCost, ItemCost, ObtainedBy, PictureLink, DateRecoreded) VALUES (@cName,@item,@cat, @desc, @dateAq, @autoCost, @itemCost, @autoObtnBy,@picLink, @dateRec)";
                using (SqlCommand comm = new SqlCommand())
                {                          
                    //LogFile.WriteToLog("******Query Inserted******");
                    // tempMonEventLog.WriteEntry("******Query Inserted******");

                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@cName", myItem.CelebName);
                    command.Parameters.AddWithValue("@item", myItem.SelectedItem);
                    command.Parameters.AddWithValue("@cat", myItem.SelectedCat);
                    command.Parameters.AddWithValue("@desc", myItem.Description);
                    command.Parameters.AddWithValue("@dateAq", myItem.DateAquired);
                    command.Parameters.AddWithValue("@autoCost", myItem.AutoCost);
                    command.Parameters.AddWithValue("@itemCost", myItem.ItemCost);
                    command.Parameters.AddWithValue("@autoObtnBy", myItem.AutoObtainedBy);
                    command.Parameters.AddWithValue("@picLink", myItem.PicLink);
                    command.Parameters.AddWithValue("@dateRec", dateNow);
                
                    //run query      
                    command.ExecuteNonQuery();
                  }
            }

            finally
            {   //close connection
                conn.Close();
            }
        }
        ////public static void recordToDb(string celbName, string selectedItem, string selectedCat, string descrip, string dateAquired, string autoCost, string itemCost, string autoObtainedBy, string picLink)        
        //{
        //    string connect = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
        //    SqlConnection conn = new SqlConnection(connect);

        //    try
        //    {
        //        conn.Open();

        //        //Get date and time
        //        String dateNow = DateTime.Now.ToString("M/d/yyyy h:mm:ss");
        //        String query = "INSERT INTO dbo.NicksAutographs (CelebrityName, Item, Category, Description, DateAquired, AutographCost, ItemCost, ObtainedBy, PictureLink, DateRecoreded) VALUES (@cName,@item,@cat, @desc, @dateAq, @autoCost, @itemCost, @autoObtnBy,@picLink, @dateRec)";
        //        using (SqlCommand comm = new SqlCommand())
        //        {
        //            // Console.WriteLine("******Query Inserted******");
        //            //LogFile.WriteToLog("******Query Inserted******");
        //            // tempMonEventLog.WriteEntry("******Query Inserted******");

        //            SqlCommand command = new SqlCommand(query, conn);
        //            command.Parameters.AddWithValue("@cName", celbName);
        //            command.Parameters.AddWithValue("@item", selectedItem);
        //            command.Parameters.AddWithValue("@cat", selectedCat);
        //            command.Parameters.AddWithValue("@desc", descrip);
        //            command.Parameters.AddWithValue("@dateAq", dateAquired);
        //            command.Parameters.AddWithValue("@autoCost", autoCost);
        //            command.Parameters.AddWithValue("@itemCost", itemCost);
        //            command.Parameters.AddWithValue("@autoObtnBy", autoObtainedBy);
        //            command.Parameters.AddWithValue("@picLink", picLink);
        //            command.Parameters.AddWithValue("@dateRec", dateNow);

        //            //run query      
        //            command.ExecuteNonQuery();
        //        }
        //    }

        //    finally
        //    {   //close connection
        //        conn.Close();
        //    }
        //}
    }
}
