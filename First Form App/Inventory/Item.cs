using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Form_App.Inventory
{
    class Item
    {
        //deklaracija statu za iteme
        string name;
        string desc;
        string stats;
        string rarity;

        Item(string x, string y, string z, string a)
        {
            name = x;
            desc = y;
            stats = z;
            rarity = a;
            
        }


    }
}
