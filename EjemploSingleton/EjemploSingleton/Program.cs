using System;
using System.Threading;

namespace EjemploSingleton
{
    class Program
    {
        /// <summary>
        /// Main principal.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton funciona, ambas variables contienen la misma instancia.");
            }
            else
            {
                Console.WriteLine("Singleton falló, las variables contienen diferentes instancias.");
            }

            Console.ReadKey();
        }
    }
}
