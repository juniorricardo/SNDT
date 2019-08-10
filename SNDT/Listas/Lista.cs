﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNDT
{
    public abstract class Lista
    {
        protected int tamanio { get; set; }

        public abstract object obtenerElemento(int pos);
        public abstract void agregar(object elem, int pos);
        public abstract void eliminar(int pos);
        public abstract bool esVacia();
        public abstract bool incluye(object elem);

        public abstract Recorredor getRecorredor();

        public int obtenerTamanio()
        {
            return tamanio;
        }
    }
}