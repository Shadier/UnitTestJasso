using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilidadesRepositorio
{
    public class Matematicas
    {
        public static int Suma(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;
        }

        public static int Division(int dividendo, int divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException("¡No se puede dividir entre CERO!");
            
            return dividendo/divisor;
        }
    }
}
