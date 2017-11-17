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
using ERPlib;


namespace bioERP
{
    public class ExampleData
    {
        static public void sendDummyDataTo(Plant p)
        {

            List<Product> prods = new List<Product>();

            int i = 0;

            prods.Add(new Product("Ribonuclease"));
            prods[i].Components.Add(new Component("Cell paste", 25, prods[i].deadline));
            prods[i].Components.Add(new Component("Lysis buffer", 4, prods[i].deadline));
            prods[i].Components.Add(new Component("Glycerol", 1, prods[i].deadline));
            prods[i].Components.Add(new Component("1,2-propanediol", 45, prods[i].deadline));
            prods[i].Components.Add(new Component("Size exlusion buffer", 5, prods[i].deadline));
            prods[i].Components.Add(new Component("Ultrafiltration membrane", 4, prods[i].deadline));
            i++;

            prods.Add(new Product("DNA Polymerase"));
            prods[i].Components.Add(new Component("Lyophilized enzyme", 3, prods[i].deadline));
            prods[i].Components.Add(new Component("Resuspension buffer", 3, prods[i].deadline));
            prods[i].Components.Add(new Component("Nickel resin", 4, prods[i].deadline));
            prods[i].Components.Add(new Component("Imidazole", 4, prods[i].deadline));
            prods[i].Components.Add(new Component("ddNTPs", 20, prods[i].deadline));
            prods[i].Components.Add(new Component("Size exclusion buffer", 5, prods[i].deadline));
            i++;

            prods.Add(new Product("Streptavidin Particle"));
            prods[i].Components.Add(new Component("Streptavidin", 12, prods[i].deadline));
            prods[i].Components.Add(new Component("Agar beads", 10, prods[i].deadline));
            prods[i].Components.Add(new Component("Click reagent", 30, prods[i].deadline));
            prods[i].Components.Add(new Component("Wash buffer", 5, prods[i].deadline));
            prods[i].Components.Add(new Component("Biotynilated IgG", 90, prods[i].deadline));
            prods[i].Components.Add(new Component("Ethanol", 2, prods[i].deadline));
            i++;

            prods.Add(new Product("Magnetic Resin"));
            prods[i].Components.Add(new Component("Iron Oxide", 2, prods[i].deadline));
            prods[i].Components.Add(new Component("Nickel Chloride", 3, prods[i].deadline));
            prods[i].Components.Add(new Component("Silica gel", 6, prods[i].deadline));
            prods[i].Components.Add(new Component("Wash buffer", 5, prods[i].deadline));
            prods[i].Components.Add(new Component("Plasmid", 20, prods[i].deadline));
            prods[i].Components.Add(new Component("Ethanol", 2, prods[i].deadline));
            i++;

            prods.Add(new Product("Immunoglobulin"));
            prods[i].Components.Add(new Component("Rabbit blood", 80, prods[i].deadline));
            prods[i].Components.Add(new Component("Nickel resin", 6, prods[i].deadline));
            prods[i].Components.Add(new Component("Cobalt resin", 9, prods[i].deadline));
            prods[i].Components.Add(new Component("Sodium azide 10%", 3, prods[i].deadline));
            prods[i].Components.Add(new Component("Horseradish peroxidase", 3, prods[i].deadline));
            prods[i].Components.Add(new Component("Hydrogen peroxide", 2, prods[i].deadline));
            i++;

            prods.Add(new Product("tRNA Cocktail"));
            prods[i].Components.Add(new Component("Yeast cell paste", 10, prods[i].deadline));
            prods[i].Components.Add(new Component("Lysis buffer", 2, prods[i].deadline));
            prods[i].Components.Add(new Component("Glycerol", 0, prods[i].deadline));
            prods[i].Components.Add(new Component("Template mRNA", 3, prods[i].deadline));
            prods[i].Components.Add(new Component("Tris buffer", 3, prods[i].deadline));
            i++;

            foreach (Product prod in prods)
            {
                p.Products.Add(prod);
            }

        }

    }
}

