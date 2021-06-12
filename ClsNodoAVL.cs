using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Instagram
{
    class ClsNodoAVL
    {
        private ClsNodoAVL SubArbIzq;
        private ClsNodoAVL SubArbDer;
        private object dato;
        private int FE;

        public ClsNodoAVL(Object dato) 
        {
            SubArbDer = null;
            SubArbIzq = null;
            FE = 0;
            this.dato = dato; 
        }

        public ClsNodoAVL Get_SubArbDer() { return SubArbDer; }
        public ClsNodoAVL Get_SubArbIzq() { return SubArbIzq; }
        public object Get_dato() { return dato; }
        public int Get_FE() { return FE; }

        public void Set_SubArbIzq(ClsNodoAVL SubArbIzq) {  this.SubArbIzq =  SubArbIzq; }
        public void Set_SubArbDer(ClsNodoAVL SubArbDer) { this.SubArbDer = SubArbDer; }
        public void Set_datos(object dato) { this.dato = dato; }
        public void Set_FE(int FE) { this.FE = FE; }


    }
}
