using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOCLojaOnline.Model
{
    public interface IDesconto
    {
        decimal CalcularDesconto(decimal valorTotal);
    }
}
