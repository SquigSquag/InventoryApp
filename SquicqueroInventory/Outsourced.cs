using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquicqueroInventory
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }
        public Outsourced() { }
        public Outsourced(int partid, string name, decimal price, int instock, int min, int max, string companyname) {
        
            this.PartID = partid;
            this.Name = name;
            this.Price = price;
            this.InStock = instock;
            this.Min = min;
            this.Max = max;
            this.CompanyName = companyname;
    }

        public Outsourced(int partid, string name, decimal price, int instock, int min, int max) {
            
            this.PartID = partid;
            this.Name = name;
            this.Price = price;
            this.InStock = instock;
            this.Min = min;
            this.Max = max;

        }

    }
}
