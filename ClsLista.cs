using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Instagram
{
    class ClsLista
    {
        private ClsNodo InicioLista;

        public ClsLista()
        {
            InicioLista = null;
        }

        public bool ListaVacia() 
        {
            bool vacio = true;
            if (InicioLista != null) vacio = false;

            return vacio;
        }

        public void InsertarDato(object dato) 
        {
            if (ListaVacia()) 
            {
                InicioLista = new ClsNodo(dato);
            }
            else 
            {
                ClsNodo nodo_Aux = InicioLista;
                while (nodo_Aux !=null ) 
                {
                    nodo_Aux = nodo_Aux.Get_NodoSig();
                }

                nodo_Aux = new ClsNodo(dato);
            }
        }

        public bool EliminarDato(object dato)
        {
            bool encontrado =  false;

            if (ListaVacia())
            {
                return encontrado;
            }
            else
            {
                ClsNodo nodo_anterior = InicioLista;
                ClsNodo nodo_Aux  = InicioLista.Get_NodoSig();
                
                ClsUserInsta Usuario_buscado = (ClsUserInsta)dato;
                ClsUserInsta Usuario_encontrado = (ClsUserInsta) nodo_anterior.Get_dato();

                while (nodo_anterior.Get_NodoSig() != null  && Usuario_buscado.Get_nomPerfil() != Usuario_encontrado.Get_nomPerfil())
                {
                    nodo_anterior = nodo_Aux;
                    nodo_Aux = nodo_Aux.Get_NodoSig();
                    Usuario_encontrado = (ClsUserInsta)nodo_Aux.Get_dato();
                }

                if(Usuario_buscado.Get_nomPerfil() == Usuario_encontrado.Get_nomPerfil()) 
                {
                    if (nodo_Aux != null) 
                    {
                        nodo_anterior.Set_NodoSig(nodo_Aux.Get_NodoSig());
                        nodo_Aux = null;
                        
                    }
                    else
                    {
                        InicioLista = null;
                    }
                    encontrado = true;
                }
                else 
                {
                    encontrado = false;
                }

                return encontrado;
            }
        }

        public ClsBusquedaObjetos BuscarDato(object dato)
        {
            bool encontrado = false;

            if (ListaVacia())
            {
                return new ClsBusquedaObjetos(dato,encontrado);
            }
            else
            {
                ClsNodo nodo_Aux = InicioLista;
                ClsUserInsta Usuario_buscado = (ClsUserInsta)dato;
                ClsUserInsta Usuario_encontrado = (ClsUserInsta)nodo_Aux.Get_dato();

                while (nodo_Aux != null && Usuario_buscado.Get_nomPerfil() != Usuario_encontrado.Get_nomPerfil())
                {
                    nodo_Aux = nodo_Aux.Get_NodoSig();
                    Usuario_encontrado = (ClsUserInsta)nodo_Aux.Get_dato();
                }

                if (Usuario_buscado.Get_nomPerfil() == Usuario_encontrado.Get_nomPerfil())
                {
                    encontrado = true;
                }
                else
                {
                    encontrado = false;
                }

                return new ClsBusquedaObjetos(dato, encontrado);
            }
        }

        public int LongitudLista() 
        {
            ClsNodo aux_inicio = InicioLista;
            int contador_datos=0;

            if (!ListaVacia()) 
            {
                while (aux_inicio != null) 
                {
                    contador_datos += 1;
                    aux_inicio = aux_inicio.Get_NodoSig();
                }  
            }

            return contador_datos;
        }

        public object Recorrido(int correlativo ) 
        {
            ClsNodo aux_inicio = InicioLista;
            int contador_datos = 1;

            if (!ListaVacia())
            {
                while (aux_inicio != null && correlativo == contador_datos)
                {
                    contador_datos += 1;
                    aux_inicio = aux_inicio.Get_NodoSig();
                }
            }

            return aux_inicio.Get_dato();
        }
    }
}
