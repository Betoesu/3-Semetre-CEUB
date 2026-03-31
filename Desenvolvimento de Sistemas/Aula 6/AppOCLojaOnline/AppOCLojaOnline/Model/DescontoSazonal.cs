using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOCLojaOnline.Model
{
    public class DescontoSazonal : IDesconto
    {
        public decimal CalcularDesconto(decimal valorTotal)
        {
            //Desconto sazonal para o mes 3 15%
            //Desconto sazonal para o mes 6 10%
            //Desconto sazonal para o mes 11 20%

            int mes = DateTime.Now.Month;
            decimal desconto;
            if (mes == 3)
            {
                desconto = 0.15m;
            }

            else if (mes == 6)
            {
                desconto = 0.1m;
            }

            else if (mes == 11) 
            {
                desconto = 0.2m;
            }
            else
            {
                desconto = 1;
            }

            return valorTotal * desconto;
        }
    }
}
