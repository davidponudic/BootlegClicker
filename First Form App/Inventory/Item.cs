using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace First_Form_App.Inventory
{
    class Item
    {
        private Bitmap cPicture;
        private string cName;
        private int cNumber;

        public Item(Bitmap cPicture, string cName, int cNumber)
        {
            this.cPicture = cPicture;
            this.cName = cName;
            this.cNumber = cNumber;
        }

        public Bitmap picture
        {
            set { cPicture = value; }
            get { return cPicture; }
        }
        public string name
        {
            set { cName = value; }
            get { return cName; }
        }
        public int number
        {
            set { cNumber = value; }
            get { return cNumber; }
        }
    }
}
