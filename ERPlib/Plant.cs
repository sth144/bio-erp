/************************************************************************************************************
 * Title: Plant Class
 * Author: Sean Hinds
 * Date: 11/18/17
 * Description: Plant class implementation for the ERPlib library
 ************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPlib
{
    public class Plant
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public Plant(string n) 
        {
            Name = n;
            Products = new List<Product>();
        }
        public string Display
        {
            get
            {
                return Name;
            }
        }
    }
}
