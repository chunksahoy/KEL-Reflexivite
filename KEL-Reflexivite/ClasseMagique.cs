/**************************************************************************|
|                                                                          |
|  ClasseMagique                                                           |
|  Charles Hunter-Roy,                                                     |
|  Daren Ken Saint-Laurent                                                 |
|  2015                                                                    |
|                                                                          |
|  Classe se voulant très simpliste, ne sert qu'à prouver                  |
|  le concept de l'explorateur de classe.                                  |
|                                                                          |
***************************************************************************/
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
