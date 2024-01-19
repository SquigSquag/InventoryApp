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
        private long ID;
        private string Name;
        private double Price;
        private int Inventory;
        public BindingList<Part> RelatedParts = new BindingList<Part>();

        public Product(int id, string name,  double price, int inventory) {
        this.ID = id;
        this.Name = name;
        this.Price = price;
        this.Inventory = inventory;
        
        }

        public long getID()
        {
            return this.ID;
        }
        public void setID(int id)
        {
            this.ID = id;
        }

        public string getName()
        {
            return this.Name;
        }

        public void setName(string name)
        {
            this.Name = name;
        }

        public double getPrice()
        {
            return this.Price;
        }
        public void setPrice(double price)
        {
            this.Price = price;
        }
        public int getInventory()
        {
            return this.Inventory;
        }

        public void setInventory(int inventory)
        {
            this.Inventory = inventory;
        }

        public BindingList<Part> getParts()
        {
            return this.RelatedParts;
        }


    }
}
