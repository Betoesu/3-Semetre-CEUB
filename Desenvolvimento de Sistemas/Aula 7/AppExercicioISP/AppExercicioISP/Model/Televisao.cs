using AppExercicioISP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicioISP.Model
{
    public class Televisao : IControlavel, ISintonizavel
    {
        public void Desligar()
        {
            throw new NotImplementedException();
        }

        public void Ligar()
        {
            throw new NotImplementedException();
        }

        public void MudarCanal(int canal)
        {
            throw new NotImplementedException();
        }
    }
}
