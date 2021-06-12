using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Instagram
{
    class ClsBusquedaObjetos
    {
        private object dato;
        private bool encontrado;

        public ClsBusquedaObjetos(object dato, bool encontrado) 
        {
            this.dato = dato;
            this.encontrado = encontrado;
        }


        public object GetDato() { return dato; }
        public bool GetEncontrado() { return encontrado; }
        public void SetDato(object dato) { this.dato = dato; }
        public void SetEncontrado(bool encontrado) { this.encontrado = encontrado; }
    }
}
