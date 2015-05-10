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
    }
}
