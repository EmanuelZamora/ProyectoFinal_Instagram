using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Instagram
{
    class ClsHashTable
    {
        private ClsLista[] Lista;
        private const int tamanio = 103;

        public ClsHashTable()
        {
            Lista = new ClsLista[tamanio];
        }

        public void AddDatoHash(object dato, string llave)
        {
            int llave_array = HashCode(llave);
            if (Lista[llave_array] !=null) 
            {
                Lista[llave_array].InsertarDato(dato);
            }
            else
            {
                Lista[llave_array] = new ClsLista();
                Lista[llave_array].InsertarDato(dato);
            }
            
        }

        public bool DeleteUsuario(string llave) 
        {
            bool eliminado = false;
            int llave_array = HashCode(llave);
            ClsUserInsta usuario_eliminar = new ClsUserInsta();
            usuario_eliminar.Set_nomPerfil(llave);

            if(Lista[llave_array] != null) 
            {
                eliminado = Lista[llave_array].EliminarDato(usuario_eliminar);

            }

            return eliminado;
        }

        private int HashCode(string llave)
        {
            int llave_aux = Valor_llave(llave);
            int llave_array;
            llave_array = llave_aux%tamanio;

            return llave_array;
        }

        public object BuscarLista(string dato) 
        {
            ClsLista Dato_encontrado = SearchData(dato);
            return Dato_encontrado;
        }
        private ClsLista SearchData(string llave)
        {
            int llave_array = HashCode(llave); ;
            return Lista[llave_array];
        }

        private int Valor_llave(string llave)
        {
            int c = 0;
            for (int i = 1; i< llave.Length; i++  ) 
            {
                if(i == 1) 
                {
                    c += Convert.ToInt32(llave[i])*10;
                }
                else
                {
                    c += Convert.ToInt32(llave[i]);
                }
                
            }

            return c;
        }

        public int HashTableContent() 
        {
            int i = 0;
            int contador_datos=0;
            if (Lista != null) 
            {
                while (i < Lista.Length)
                {
                    if (Lista[i]!=null) 
                    {
                        contador_datos += Lista[i].LongitudLista();
                    }
                    i++;
                }
            }

            return contador_datos;
        }

        public ClsLista HashTableSearchCorrelative(int correlativo) 
        {
            int i = 0;
            int x = 0;
            ClsLista ListaEnviada = null;

            while (i < Lista.Length) 
            {
                if (Lista[i] !=null) 
                {
                    x++;
                    if(x == correlativo) 
                    {
                        ListaEnviada = Lista[i];
                        i = 1000;
                    } 
                }
                i++;
            }
            return ListaEnviada;
        }

        
    }
}
