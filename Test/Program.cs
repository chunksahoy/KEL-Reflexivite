using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using KEL_Reflexivite;

namespace Test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static void Main()
        {
            Explorateur ex = new Explorateur(new ClasseMagique());
            Explorateur magie = new Explorateur(new ClasseMagique());
            //Console.WriteLine("{0}",
            //   ex.InvoquerConstructeur<ex.Type>
            //      (void, 0, new object[] { }).SecretUnivers().ToString());
            Console.WriteLine(magie.InvoquerMethode<ClasseMagique>(0, magie, new object { }).ToString());
        }
    }
}