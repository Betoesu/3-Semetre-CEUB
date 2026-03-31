using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AppOCLojaOnline.Model
{
    public class DescontoCupom : IDesconto
    {

        public decimal CalcularDesconto(decimal valorTotal)
        {
            return valorTotal * 0.20m;
        }
    }
}

