using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOCLojaOnline.Model
{
    public class CalcularPagamento()
    {
        public decimal CalcularTotal(decimal valorTotal, IDesconto desconto)
        {
            return valorTotal - desconto.CalcularDesconto(valorTotal);
        }
    }
}
