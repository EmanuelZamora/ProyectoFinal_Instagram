using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Instagram
{
    interface IComparador
    {
        bool mayorQue(object objeto, int tipo_llave);
        bool menorQue(object objeto, int tipo_llave);
        bool igualQue(object objeto, int tipo_llave);
    }
}
