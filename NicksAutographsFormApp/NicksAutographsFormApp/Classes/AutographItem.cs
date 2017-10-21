using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicksAutographsFormApp
{
    class AutographItem
    {
      //Instance variables. You refernce with THIS. Values change with different customer objects. 

        public string CelebName { get; set; }
        public string SelectedItem { get; set; }
        public string SelectedCat { get; set; }
        public string Description { get; set; }
        public string DateAquired { get; set; }
        public string AutoCost { get; set; }
        public string ItemCost { get; set; }
        public string AutoObtainedBy { get; set; }
        public string PicLink { get; set; }
              
        //private string _favCoffee;

        //public string FavCoffee
        //{
        //    get
        //    {
        //        return _favCoffee;
        //    }

        //    set
        //    {
        //        _favCoffee = value;
        //    }
        //}

        //another way to set/ get
        //private string phoneNumber;
        //public string PhoneNumber
        //{
        //    set { phoneNumber = value; }
        //    get { return phoneNumber; }
        //}

    }
}
