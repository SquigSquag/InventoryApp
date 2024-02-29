using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquicqueroInventory
{
    public class InHouse : Part
    {
        public int MachineID { get; set; }


        public InHouse() { }
        public InHouse(int partid, string name, decimal price, int instock, int min, int max, int machineid)
        {
            this.PartID = partid;
            this.Name = name;
            this.Price = price;
            this.InStock = instock;
            this.Min = min;
            this.Max = max;
            this.MachineID = machineid;
        }
        public InHouse(int partid, string name, decimal price, int instock, int min, int max)
        {
            this.PartID = partid;
            this.Name = name;
            this.Price = price;
            this.InStock = instock;
            this.Min = min;
            this.Max = max;
            
        }


    }
}
