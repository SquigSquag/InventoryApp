using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquicqueroInventory
{
    public class Part
    {
        private long ID;
        private string Name;
        private double Price;
        private int Inventory;
        public BindingList<Product> Products = new BindingList<Product>();

        public Part(int id, string name, double price, int inventory){
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Inventory = inventory;
        }
        public long getID(){
            return this.ID;
        }
        public void setID(long id){
            this.ID = id;
        }

        public string getName(){
            return this.Name;   
        }

        public void setName(string name){
            this.Name = name;   
        }

        public double getPrice(){
            return this.Price;  
        }

        public void setPrice(double price){
            this.Price = price;
        }
        public int getInventory(){
            return this.Inventory;  
        }

        public void setInventory(int inventory){
            this.Inventory = inventory;
        }

        public BindingList<Product> getProducts(){
            return this.Products;
        }

    }
}
