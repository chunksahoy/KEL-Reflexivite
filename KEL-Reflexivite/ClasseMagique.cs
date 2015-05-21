using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEL_Reflexivite
{
    public class ClasseMagique
    {
        int Secret = 10;
        string Message = "J'aime mon prof";
        public ClasseMagique()
        {

        }
        public ClasseMagique(int val)
        {
            Secret = val;
        }
        public int SecretUnivers()
        {
            return ((Secret / 2) + 1) * 7;
        }
        public double Tarte()
        {
            return Math.PI;
        }
        public string MessageSecret()
        {
            return Message;
        }
    }
}
