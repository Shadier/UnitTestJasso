using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilidadesRepositorio
{
    public class User
    {
        public string FirstName;
        public string LastName;
        public int employeeID;
    }
    public class Assignments
    {
        public static bool addUser(User user)
        {
            bool isText = true;
            for (int i = 0; i < user.FirstName.Length; i++)
            {
                if (Char.IsNumber(user.FirstName, i))
                    isText = false;
            }

            for (int i = 0; i < user.LastName.Length; i++)
            {
                if (Char.IsNumber(user.LastName, i))
                    isText = false;
            }
            bool wrongLength = (user.employeeID < 1000)? true : false;
            return isText && !wrongLength;
        }

        public static int Division(int dividendo, int divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException("¡No se puede dividir entre CERO!");
            
            return dividendo/divisor;
        }
    }
}
