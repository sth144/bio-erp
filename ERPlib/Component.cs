/************************************************************************************************************
 * Title: Component Class   
 * Author: Sean Hinds
 * Date: 11/18/17
 * Description: Component class implementation for the ERPlib library
 ************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPlib
{
    public class Component
    {
        public string Name { get; set; }
        public double leadTimeDays { get; set; }
        public DateTime orderDate { get; set; }
        public Component(string n, double lead, DateTime dead)
        {
            Name = n;
            leadTimeDays = lead;
            orderDate = ERPlib.Calculator.subDaysFromDate(lead, dead);
        }
        public string Display
        {
            get
            {
                string buffer = "";
                int nameLength = Name.Length;
                for (int i = 0; i < (30 - nameLength); i++)
                {
                    buffer += " ";
                }
                return string.Format("{0}{1}{2}", Name, buffer, orderDate.ToShortDateString());
            }
        }
    }
}
