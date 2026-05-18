using AppExercicioISP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicioISP.Model
{
    public class ArCondicionado : IControlavel, ITermostatizavel
    {
        public void AjustarTemperatura(int graus)
        {
            throw new NotImplementedException();
        }

        public void Desligar()
        {
            throw new NotImplementedException();
        }

        public void Ligar()
        {
            throw new NotImplementedException();
        }
    }
}
