using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploDIP.Model
{
    public interface ITurma
    {
        string Nome { get; }
        string Periodo { get; }
        string GetInformacoesTurma();
    }
}
