using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploLSP.Model
{
    public class CalcularArea
    {
        private static void ObterAreaParelelogramo(Paralelogramo paralelogramo)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Paralelogramo\n");
            Console.WriteLine(paralelogramo.Altura + "*" + paralelogramo.Largura);
            Console.WriteLine();
            Console.WriteLine(paralelogramo.Area);
            Console.ReadKey();

        }
        public static void Calcular()
        {
            double altura, largura;
            Console.WriteLine("Informe a altura do paralelogramo");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a largura do paralelogramo");
            largura = Convert.ToDouble(Console.ReadLine());

            var quadrado = new Quadrado(5, 5);
            var retangulo = new Retangulo(10, 5);

            ObterAreaParelelogramo(retangulo);
            ObterAreaParelelogramo(quadrado);
        }
    }
}
