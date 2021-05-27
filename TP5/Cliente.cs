﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    public class Cliente
    {
        private int numeroEntradas;
        private String estado;
        private bool entradaAnticipada;

        public int NumeroEntradas { get => numeroEntradas; set => numeroEntradas = value; }
        public string Estado { get => estado; set => estado = value; }
        public bool EntradaAnticipada { get => entradaAnticipada; set => entradaAnticipada = value; }

        public Cliente(int numEntradas, bool entrada)
        {
            numeroEntradas = numeroEntradas;
            entradaAnticipada = entrada;
            if (!entrada)
                estado = "esperando_compra";
            else
                estado = "esperando_entrar";
        }
    }

    
}
