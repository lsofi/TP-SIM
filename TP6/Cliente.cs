using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    public class Cliente
    {
        private String nombre;
        private int numeroEntradas;
        private String estado;
        private bool entradaAnticipada;
        private List<Cliente> acompañantes;

        public int NumeroEntradas { get => numeroEntradas; set => numeroEntradas = value; }
        public string Estado { get => estado; set => estado = value; }
        public bool EntradaAnticipada { get => entradaAnticipada; set => entradaAnticipada = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Cliente> Acompañantes { get => acompañantes; set => acompañantes = value; }

        public Cliente(int numEntradas, bool entrada)
        {
            numeroEntradas = numEntradas;
            entradaAnticipada = entrada;
            acompañantes = new List<Cliente>();
            if (!entrada)
                estado = "esperando_compra";
            else
                estado = "esperando_entrar";
        }
    }

    
}
