using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Instagram
{
    class ClsNodo
    {
        protected ClsNodo Nodo_Sig;
        protected object dato;

        public ClsNodo( object dato)
        {
            Nodo_Sig = null;
            this.dato = dato;
        }
        public object Get_dato() { return dato; }
        public ClsNodo Get_NodoSig() { return Nodo_Sig; }
        public void Set_dato(object dato) { this.dato = dato; }
        public void Set_NodoSig(ClsNodo Nodo_Sig) { this.Nodo_Sig = Nodo_Sig; }
    }
}
