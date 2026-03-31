using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOCLojaOnline.Model
{
    public class DescontoQuantidade : IDesconto
    {
        public decimal CalcularDesconto(decimal valorTotal)
        {
            //valorTotal>200 --> DescontoCupom 20%
            //valorTotal>50 e <=200--> DescontoCupom 10%
            decimal desconto;
            if (valorTotal > 200)
            {
                desconto = 0.20m;
            }
            else if (valorTotal > 50 && valorTotal <= 200)
            {
                desconto = 0.1m;
            }
            else
            {
                desconto = 1;
            }

            return valorTotal * desconto;
        }
    }
}
