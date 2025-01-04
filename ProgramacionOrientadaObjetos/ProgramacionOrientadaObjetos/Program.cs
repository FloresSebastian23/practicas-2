using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOrientadaObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           perro P1 = new perro();
            P1.Nombre = "sanwell";
            Console.WriteLine("el nombre del perro es:" + P1.Nombre); 
           
           Console.ReadKey();
        }
    }
}
