using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaSem4.Entidades;

namespace TareaSem4.Negocio
{
    public class ClsContadorLetras
    {
        public int contador(ContadorLetras par)
        {

            return  (par.palabra.Length);
              

        }
    }
}