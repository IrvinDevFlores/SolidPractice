}using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DYEORDER.ManageDyeOrder
{
    public class DyeOrder
    {
        public int id { get; set; }
        public Dictionary<int, string> machines;
        public string Color { get; set; }
        public DyeOrder()
        {
            machines = new Dictionary<int, string>();

            machines.Add(1,"");
        }
    }
}
