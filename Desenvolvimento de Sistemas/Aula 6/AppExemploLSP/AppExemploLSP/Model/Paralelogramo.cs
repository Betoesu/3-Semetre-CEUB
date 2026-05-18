using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploLSP.Model
{
    public class Paralelogramo
    {
        public double Altura { get; private set; }
        public double Largura { get; private set; }
        public double Area { get { return Altura * Largura; } }

        public Paralelogramo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

   

    }
}
