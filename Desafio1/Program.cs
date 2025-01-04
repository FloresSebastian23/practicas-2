using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono T1 = new Telefono("11 promax", "iphone");
            T1.NumeroTelefonico = "2374101321";
            T1.CodigoOperador = 1;

            Telefono T2 = new Telefono("15 plus", "iphone");
            T2.NumeroTelefonico = "1168826597";
            T2.CodigoOperador = 2;

            Telefono T3 = new Telefono("a21", "samsung");
            T3.NumeroTelefonico = "1234567890";
            T3 .CodigoOperador = 5;

            Console.WriteLine("los datos son.." + T1.Marca);
            Console.WriteLine("los datos son.." + T1.Modelo);
            Console.WriteLine("los datos son.." + T1.NumeroTelefonico);
            Console.WriteLine("los datos son.." + T1.CodigoOperador);
           // Console.WriteLine(T1.Llamar());
            Console.WriteLine(T1.Llamar("sebi" ));
            //Console.ReadKey;




        }
    }
}
