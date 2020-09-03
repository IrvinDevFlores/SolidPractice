using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Facturas
{
    class IvaNormal
    {
        private const decimal PORCENTA_IVA_NORMAL = 0.16m;
        public  decimal PorcentajeIvaNormal
        {
            get {
                return PORCENTA_IVA_NORMAL;
            }
        }

        public decimal CalcularIVA(decimal importe)
        {
            return importe * PORCENTA_IVA_NORMAL;
        }
    }
}
