using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.EstrategiaPedidos
{
    public class Estrategia2 : IEstrategiaPedidos
    {
        public void calcularCantidadPedidos(VectorEstado anterior, VectorEstado actual)
        {
            actual.Pedido = 23;
        }
    }
}
