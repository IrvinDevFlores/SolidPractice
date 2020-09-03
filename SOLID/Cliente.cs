using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.open_closed
{
    class Cliente
    {
        public string Nombre { get; set; }
        public Localidad Localidad { get; set; }
        public decimal Saldo { get; set; }
    }

    public enum Localidad
    {
        SanPedroSula  = 1,
        LaLima,
        Nicaragua,
        Villanueva
    }
}
