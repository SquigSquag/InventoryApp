using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace SquicqueroInventory
{
     public class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();
        

          
        public Inventory() {
            
        }
                       
        public static void addProduct(Product product) {

            Products.Add(product);
        }
        public static void generateExamples() {
            
            InHouse example1 = new InHouse(1, "example1", (decimal)11.90, 1, 2, 10, 1234);
            Product example2 = new Product(1, "example2", (decimal)20.11, 1, 10, 20);

            addPart(example1);
            addProduct(example2);

        }
        public static void addPart (Part part){

            AllParts.Add(part);
        }

        public static bool removeProduct(int product) {

            foreach (Product prod in Products) {
                if (prod.ProductID == product) {
                    Products.Remove(prod);
                    return true;
                }
             }
                
             MessageBox.Show("Unable to locate Product. Try another product ID");
             return false; 
        }
        public static bool removePart(int part)
        {

            foreach (Part prod in AllParts) {
                if(prod.PartID == part)
                {
                    AllParts.Remove(prod);
                    
                    return true;
                }
            }
            MessageBox.Show("Unable to locate Part. Try another product ID");
            return false;
        }
        public static void updateProduct(int product, Product thing) {
            try
            {
                foreach (Product prod in Products)
                {
                    if (prod.ProductID == product)
                    {

                        prod.ProductID = thing.ProductID;
                        prod.Name = thing.Name;
                        prod.Price = thing.Price;
                        prod.InStock = thing.InStock;
                        prod.Min = thing.Min;
                        prod.Max = thing.Max;
                        return;

                    }
                }
            }
            catch (Exception e) {
                string msg = e.Message;
                MessageBox.Show(msg);
                return;

            }
            
        }
        public static Product lookupProduct(int product) {
            
            foreach (Product prod in Products){
                if(prod.ProductID == product){
                    
                    return prod;
                }


            }

            Product defaultprod = new Product();    
            return defaultprod;
         }

        public static Part lookupPart (int part) {

            foreach (Part lookuppart in AllParts)
            {
                if (lookuppart.PartID == part)
                {
                    return lookuppart;
                }


            }

            InHouse defaultpart = new InHouse();
            return defaultpart;
        }

        public static void updatePart(int inttmp, Part thing)
        {
            try
            {
                removePart(inttmp);
                addPart(thing);
            }
            catch (Exception e)
            {
                string msg = e.Message;
                MessageBox.Show(msg);
                return;

            }

        }
        

    }


}
