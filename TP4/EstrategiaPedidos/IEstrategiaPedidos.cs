using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.EstrategiaPedidos
{
    public interface IEstrategiaPedidos
    {
        void calcularCantidadPedidos(VectorEstado anterior, VectorEstado actual);
    }
}
