using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.open_closed
{
    public abstract class EspecificacionFiltroCliente
    {
        protected abstract IEnumerable AplicarFiltro(IList<Cliente> clientes);

        public IEnumerable Filtrar(IList<Cliente> clientes)
        {
            return AplicarFiltro(clientes);
        }
    }
}
