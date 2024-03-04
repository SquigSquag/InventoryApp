using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SquicqueroInventory
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public BindingList<Part> AssociatedParts = new BindingList<Part>();



        public Product() { }

        public Product(int id, string name, decimal price, int inventory, int min, int max,BindingList<Part> temppart)
        {
            this.ProductID = id;
            this.Name = name;
            this.Price = price;
            this.InStock = inventory;
            this.Min = min;
            this.Max = max;
            AssociatedParts.AllowRemove = true;
            AssociatedParts.AllowNew = true;
            foreach (Part part in temppart) {
                addAssociatedPart(part);
            }
        }
        public Product(int id, string name, decimal price, int inventory, int min, int max)
        {
            this.ProductID = id;
            this.Name = name;
            this.Price = price;
            this.InStock = inventory;
            this.Min = min;
            this.Max = max;
            AssociatedParts.AllowRemove = true;
            AssociatedParts.AllowNew = true;
        }

        public void addAssociatedPart(Part thing)
        {
            try {AssociatedParts.Add(thing);}
            catch (Exception e)
            {
                string msg = e.Message;
                MessageBox.Show(msg);

            }

        }



        public bool removeAssociatedPart(int thing) {

            foreach (Part part in AssociatedParts) {
                if (part.PartID == thing) {
                    AssociatedParts.Remove(part);
                    return true;

                }
            }
            string msg = "Part does not exist";
            MessageBox.Show(msg);
            return false;
        }
    

        public Part lookupAssociatedPart(int thing) {

        foreach (Part part in AssociatedParts) {
            if (part.PartID == thing){
                return part;
            }
        }
        Part defaultpart = new Outsourced();
        return defaultpart;
        }
    }
}
 


