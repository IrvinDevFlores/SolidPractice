using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Facturas
{
    class Factura
    {
        public string Codigo { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal ImporteFactura { get; set; }
        public decimal ImporteIVA { get; set; }
        public decimal ImporteDeduccion { get; set; }
        public decimal ImporteTotal { get; set; }
        public decimal PorcentajeDeduccion { get; set; }

        public void CalcularTotal()
        {
            Deduccion deduccio = new Deduccion(PorcentajeDeduccion);
            ImporteDeduccion = deduccio.CalcularDeduccion(ImporteFactura);

            IvaNormal iva = new IvaNormal();
            ImporteIVA = iva.CalcularIVA(ImporteFactura);

            ImporteTotal = (ImporteFactura - ImporteDeduccion) + ImporteIVA;
        }
    }
}
