using System.Collections.Generic;

namespace SOLID_DYEORDER.DyeOrderComponents
{
    public class Port
    {
        public int minimunLoad { get; set; }
        public int maximumLoad { get; set; }
        public int PoundsClothToProduce { get; set; }
        public List<Sku> skusInPort;

        public Port(int minLoad, int maxLoad)
        {
            minimunLoad = minLoad;
            maximumLoad = maxLoad;
            skusInPort = new List<Sku>();
        }
    }
}