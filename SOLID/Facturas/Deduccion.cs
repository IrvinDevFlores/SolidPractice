using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Facturas
{
    class Deduccion
    {
        private decimal m_PorcentajeDeduccion;
        public Deduccion(decimal porcentaje)
        {
            m_PorcentajeDeduccion = porcentaje;
        }

        public decimal CalcularDeduccion(decimal importe)
        {
            return (importe * m_PorcentajeDeduccion) / 100;
        }
    }
}
