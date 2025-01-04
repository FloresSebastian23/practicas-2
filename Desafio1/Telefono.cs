using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Telefono
    {     
        public Telefono(string modelo, string marca) {

            this.Modelo = modelo;
            this.Marca = marca;
        }
        public string  Llamar(){

            return "Realizando llamada..";
        }
        public string Llamar(string contacto)
        {

            return "Lamando a.." + contacto;
        }

        // public int CodigoOperador { get; set; }
        // private string modelo;
        //private string marca;
        //private string numeroTelefonico;
        public string Modelo { get; }
        public string Marca { get; }
        public string NumeroTelefonico { get; set; }
       
        private int codOperador;
        public int CodigoOperador { 
            
            get { return codOperador; }
            
            set {  if ( value == 1|| value == 2 || value ==3 ) 
                
                codOperador = value;
                   else 
                    codOperador = 0;
            }



        }
    }
}
