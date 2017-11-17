/************************************************************************************************************
 * Title: 
 * Author:
 * Date:
 * Description:
 ************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPlib
{
    public class Product
    {
        public string Name { get; set; }
        public List<Component> Components;
        public DateTime deadline { get; set; }
        public Product(string n)
        {
            Name = n;
            deadline = Calculator.addDaysToToday(30);
            Components = new List<Component>();
        }
        public Product(string n, DateTime dead)
        {
            Name = n;
            deadline = dead;
            Components = new List<Component>();
        }
        public string Display
        {
            get
            {
                return string.Format("{0}\t{1}", Name, deadline.ToShortDateString());
            }
        }
        public string DisplayNoDate
        {
            get
            {
                return string.Format("{0}", Name);
            }
        }
    }
}
