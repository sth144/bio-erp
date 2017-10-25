using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ERPlib;

namespace bioERP
{
    public partial class frontEnd : Form
    {

        private Plant plant = new Plant("Plant");
        private List<Product> productData = new List<Product>();

        private List<Product> projects = new List<Product>();
        private List<ERPlib.Component> cmpnts = new List<ERPlib.Component>();

        BindingSource catalogueBinding = new BindingSource();
        BindingSource projectsBinding = new BindingSource();
        BindingSource componentsBinding = new BindingSource();

        public frontEnd()
        {

            InitializeComponent();

            ExampleData.sendDummyDataTo(plant);

            catalogueBinding.DataSource = plant.Products;
            catalogue.DataSource = catalogueBinding;

            catalogue.DisplayMember = "DisplayNoDate";
            catalogue.ValueMember = "Display";

            projectsBinding.DataSource = projects;
            productBox.DataSource = projectsBinding;

            productBox.DisplayMember = "Display";
            productBox.ValueMember = "Display";

            componentsBinding.DataSource = cmpnts;
            componentBox.DataSource = componentsBinding;

            componentBox.DisplayMember = "Display";
            componentBox.ValueMember = "Display";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // No functionality
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // No functionality
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            Product sel = (Product)catalogue.SelectedItem;
            Product selected = new Product(sel.Name, sel.deadline);
            for (int i = 0; i < sel.Components.Count; i++)
            {
                ERPlib.Component comp = new ERPlib.Component(sel.Components[i].Name, sel.Components[i].leadTimeDays, sel.Components[i].orderDate);
                selected.Components.Add(comp);
            }

            selected.deadline = dateTimePicker1.Value.Date;

            projects.Add(selected);

            projectsBinding.ResetBindings(false);

        }

        private void submit_Click(object sender, EventArgs e)
        {

            foreach (Product prod in projects)
            {
                foreach (ERPlib.Component c in prod.Components)
                {
                    c.orderDate = Calculator.subDaysFromDate(c.leadTimeDays, prod.deadline);
                    cmpnts.Add(c);
                }
            }

            catalogueBinding.ResetBindings(false);
            projectsBinding.ResetBindings(false);
            componentsBinding.ResetBindings(false);
        }
    }
}
