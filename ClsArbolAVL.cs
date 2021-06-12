using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Instagram
{
    class ClsArbolAVL
    {
        private ClsNodoAVL raiz;
        private bool aumento_altura;
        private bool disminuyo_altura;


        public ClsArbolAVL()
        {
            raiz = null;
            aumento_altura = false;
        }

        public void AddDatos(object dato, int tipo_llave)
        {
            if (raiz == null)
            {
                raiz = new ClsNodoAVL(dato);
            }
            else
            {
                raiz = InsertarDato(raiz, dato, tipo_llave);
            }
        }

        private ClsNodoAVL InsertarDato(ClsNodoAVL aux_raiz, object dato, int tipo_llave)
        {
            IComparador llave = (ClsUserInsta)dato;
            ClsNodoAVL SubArb;
            ClsNodoAVL NuevaRaiz = aux_raiz;
            if (aux_raiz != null)
            {
                if (llave.menorQue(aux_raiz.Get_dato(), tipo_llave))
                {
                    SubArb = InsertarDato(aux_raiz.Get_SubArbIzq(), dato, tipo_llave);
                    aux_raiz.Set_SubArbIzq(SubArb);
                    if (aumento_altura)
                    {
                        switch (aux_raiz.Get_FE())
                        {
                            case 1:
                                aux_raiz.Set_FE(0);
                                aumento_altura = false;
                                break;
                            case 0:
                                aux_raiz.Set_FE(-1);
                                break;
                            case -1:
                                if (SubArb.Get_FE() <= 0)
                                {
                                    NuevaRaiz = RotacionII(aux_raiz);
                                }
                                else
                                {
                                    NuevaRaiz = RotacionID(aux_raiz);
                                }
                                break;
                        }//Fin Switch
                    }//Fin if de altura de arbol

                }
                else if (llave.mayorQue(aux_raiz.Get_dato(), tipo_llave))
                {
                    SubArb = InsertarDato(aux_raiz.Get_SubArbDer(), dato, tipo_llave);
                    aux_raiz.Set_SubArbDer(SubArb);
                    if (aumento_altura)
                    {
                        switch (aux_raiz.Get_FE())
                        {
                            case -1:
                                aux_raiz.Set_FE(0);
                                aumento_altura = false;
                                break;
                            case 0:
                                aux_raiz.Set_FE(-1);
                                break;
                            case 1:
                                if (SubArb.Get_FE() >= 0)
                                {
                                    NuevaRaiz = RotacionDD(aux_raiz);
                                }
                                else
                                {
                                    NuevaRaiz = RotacionDI(aux_raiz);
                                }
                                break;
                        }//Fin Switch
                    }//Fin if de altura de arbol
                }
                else
                {
                    //Explicar que no se pudo agregar porque la llave es igual
                    MessageBox.Show("Error", "El dato ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }//FIN IF DE COMPARACIONES DE LLAVE
            }
            else
            {
                aumento_altura = true;
                NuevaRaiz = new ClsNodoAVL(dato);
            }//FIN IF SUBARB NULO


            return NuevaRaiz;
        }//Fin Insertar Dato


        private ClsNodoAVL RotacionII(ClsNodoAVL nodo)
        {
            ClsNodoAVL nodo1 = nodo.Get_SubArbIzq();

            nodo.Set_SubArbIzq(nodo1.Get_SubArbDer());
            nodo1.Set_SubArbDer(nodo);

            nodo.Set_FE(0);
            nodo1.Set_FE(0);

            return nodo1;
        }

        private ClsNodoAVL RotacionID(ClsNodoAVL nodo)
        {
            ClsNodoAVL nodo1 = nodo.Get_SubArbIzq();
            ClsNodoAVL nodo2 = nodo1.Get_SubArbDer();

            nodo1.Set_SubArbDer(nodo2.Get_SubArbIzq());
            nodo2.Set_SubArbIzq(nodo1);
            nodo.Set_SubArbIzq(nodo2.Get_SubArbDer());
            nodo2.Set_SubArbDer(nodo);

            switch (nodo2.Get_FE())
            {
                case -1:
                    nodo2.Set_FE(0);
                    nodo1.Set_FE(0);
                    nodo.Set_FE(1);
                    break;
                case 0:
                    nodo1.Set_FE(0);
                    nodo2.Set_FE(0);
                    nodo.Set_FE(0);
                    break;
                case 1:
                    nodo2.Set_FE(0);
                    nodo1.Set_FE(-1);
                    nodo.Set_FE(0);
                    break;

            }

            return nodo2;
        }

        private ClsNodoAVL RotacionDD(ClsNodoAVL nodo)
        {
            ClsNodoAVL nodo1 = nodo.Get_SubArbDer();

            nodo.Set_SubArbDer(nodo1.Get_SubArbIzq());
            nodo1.Set_SubArbIzq(nodo);

            nodo.Set_FE(0);
            nodo1.Set_FE(0);

            return nodo1;
        }

        private ClsNodoAVL RotacionDI(ClsNodoAVL nodo)
        {
            ClsNodoAVL nodo1 = nodo.Get_SubArbDer();
            ClsNodoAVL nodo2 = nodo1.Get_SubArbIzq();

            nodo1.Set_SubArbIzq(nodo2.Get_SubArbDer());
            nodo2.Set_SubArbDer(nodo1);
            nodo.Set_SubArbDer(nodo2.Get_SubArbDer());
            nodo2.Set_SubArbIzq(nodo);

            switch (nodo2.Get_FE())
            {
                case -1:
                    nodo2.Set_FE(0);
                    nodo1.Set_FE(1);
                    nodo.Set_FE(0);
                    break;
                case 0:
                    nodo1.Set_FE(0);
                    nodo2.Set_FE(0);
                    nodo.Set_FE(0);
                    break;
                case 1:
                    nodo2.Set_FE(0);
                    nodo1.Set_FE(0);
                    nodo.Set_FE(-1);
                    break;

            }

            return nodo2;
        }

        public void DeleteDato(object dato, int tipo_llave)
        {
            raiz = ProcEliminar(raiz, dato, false, tipo_llave);
        }

        private ClsNodoAVL ProcEliminar(ClsNodoAVL raiz_aux, object dato, bool cambio_altura, int tipo_llave)
        {
            IComparador llave = (ClsUserInsta)dato;
            ClsNodoAVL Nueva_Raiz = raiz_aux;
            ClsNodoAVL otra_raiz_aux = null;
            ClsNodoAVL raiz_aux2 = null;
            ClsNodoAVL raiz_aux3 = null;

            if (raiz_aux != null)
            {
                if (llave.menorQue(raiz_aux.Get_dato(), tipo_llave))
                {
                    Nueva_Raiz = ProcEliminar(raiz_aux.Get_SubArbIzq(), dato, false, tipo_llave);
                    Nueva_Raiz = RestructuracionIzq(raiz_aux);
                }
                else if (llave.mayorQue(raiz_aux.Get_dato(), tipo_llave))
                {
                    Nueva_Raiz = ProcEliminar(raiz_aux.Get_SubArbDer(), dato, false, tipo_llave);
                    Nueva_Raiz = RestructuracionDer(raiz_aux);
                }
                else
                {
                    otra_raiz_aux = raiz_aux;
                    disminuyo_altura = true;

                    if (otra_raiz_aux.Get_SubArbDer() == null)
                    {
                        raiz_aux.Set_SubArbIzq(otra_raiz_aux.Get_SubArbIzq());
                    }
                    else if (otra_raiz_aux.Get_SubArbIzq() == null)
                    {
                        raiz_aux.Set_SubArbDer(otra_raiz_aux.Get_SubArbDer());

                    }
                    else
                    {
                        bool interruptor = false;
                        raiz_aux2 = raiz_aux.Get_SubArbIzq();

                        while (raiz_aux2.Get_SubArbDer() != null)
                        {
                            raiz_aux3 = raiz_aux2;
                            raiz_aux2 = raiz_aux2.Get_SubArbDer();
                            interruptor = true;
                        }

                        raiz_aux.Set_datos(raiz_aux2.Get_dato());
                        otra_raiz_aux = raiz_aux;

                        if (interruptor)
                        {
                            raiz_aux3.Set_SubArbDer(raiz_aux2.Get_SubArbIzq());
                        }
                        else
                        {
                            raiz_aux.Set_SubArbIzq(raiz_aux.Get_SubArbIzq());
                        }
                        Nueva_Raiz = RestructuracionDer(raiz_aux);
                        otra_raiz_aux = null;
                    }//Fin de if principal


                }

            }
            else
            {
                MessageBox.Show("NO SE ENCONTRO DATO", "ERROR", MessageBoxButtons.OK);
            }

            return Nueva_Raiz;
        }

        private ClsNodoAVL RestructuracionDer(ClsNodoAVL nodo)
        {
            ClsNodoAVL nueva_raiz = nodo;
            ClsNodoAVL nodo1;
            if (disminuyo_altura)
            {
                switch (nodo.Get_FE())
                {
                    case 1:
                        nodo.Set_FE(0);
                        break;
                    case 0:
                        nodo.Set_FE(-1);
                        disminuyo_altura = false;
                        break;
                    case -1:
                        nodo1 = nodo.Get_SubArbIzq();
                        if (nodo1.Get_FE() <= 1)
                        {
                            nueva_raiz = RotacionII(nodo);
                        }
                        else
                        {
                            nueva_raiz = RotacionID(nodo);
                        }

                        break;
                }//Fin de Switch
            }//Fin if de disminucion de altura

            return nueva_raiz;
        }
        private ClsNodoAVL RestructuracionIzq(ClsNodoAVL nodo)
        {
            ClsNodoAVL nueva_raiz = nodo;
            ClsNodoAVL nodo1;
            if (disminuyo_altura)
            {
                switch (nodo.Get_FE())
                {
                    case -1:
                        nodo.Set_FE(0);
                        break;
                    case 0:
                        nodo.Set_FE(1);
                        disminuyo_altura = false;
                        break;
                    case 1:
                        nodo1 = nodo.Get_SubArbIzq();
                        if (nodo1.Get_FE() <= 1)
                        {
                            nueva_raiz = RotacionDD(nodo);
                        }
                        else
                        {
                            nueva_raiz = RotacionDI(nodo);
                        }

                        break;
                }//Fin de Switch
            }//Fin if de disminucion de altura

            return nueva_raiz;
        }


        public ClsBusquedaObjetos BuscarDato(Object objeto, int tipo_llave)
        {
            if (raiz != null)
            {
                return BuscarUsuario(raiz, objeto, tipo_llave);
            }
            else
            {
                return new ClsBusquedaObjetos(null, false);
            }

        }
        private ClsBusquedaObjetos BuscarUsuario(ClsNodoAVL aux_raiz, Object objeto, int tipo_llave)
        {
            ClsBusquedaObjetos valor_encontrado = null;
            IComparador llave = (ClsUserInsta)objeto;
            if (aux_raiz != null)
            {
                if (llave.menorQue(aux_raiz.Get_dato(), tipo_llave))
                {
                    valor_encontrado = BuscarUsuario(aux_raiz.Get_SubArbIzq(), objeto, tipo_llave);
                }
                else if (llave.mayorQue(aux_raiz.Get_dato(), tipo_llave))
                {
                    valor_encontrado = BuscarUsuario(aux_raiz.Get_SubArbDer(), objeto, tipo_llave);
                }
                else
                {
                    return new ClsBusquedaObjetos(aux_raiz.Get_dato(), true);
                }//FIN IF DE COMPARACIONES DE LLAVE
            }
            else
            {
                return new ClsBusquedaObjetos(null, false); ;
            }

            return valor_encontrado;
        }
        public void mostrardata()
        {
            InOrden(raiz);
        }

        private void InOrden(ClsNodoAVL raiz_aux)
        {
            if(raiz_aux!= null)
            {
                InOrden(raiz_aux.Get_SubArbIzq());
                Console.WriteLine(((ClsUserInsta)raiz_aux.Get_dato()).Get_nomPerfil());
                InOrden(raiz_aux.Get_SubArbDer());
            }
        }
    }//Fin Clase Arbol AVL
}//Fin names_space

