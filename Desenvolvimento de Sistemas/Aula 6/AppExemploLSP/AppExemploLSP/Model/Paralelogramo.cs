using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploLSP.Model
{
    public class Paralelogramo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Paralelogramo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double Area(double altura, double largura)
        {
            return Altura * Largura;
        }


    }
}
