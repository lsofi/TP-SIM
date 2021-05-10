using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.EstrategiaPedidos
{
    class Estrategia1 : IEstrategiaPedidos
    {
        public void calcularCantidadPedidos(VectorEstado anterior, VectorEstado actual)
        {
            actual.Pedido = anterior.Demanda;
        }
    }
}
