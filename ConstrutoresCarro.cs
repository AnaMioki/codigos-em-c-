using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ProgramacaoOrientadaAObjetos
{
    internal class ConstrutoresCarrao
    {
        public string modeloCarrao;

        public ConstrutoresCarrao()
        {
            modeloCarrao = "Pálio";
        }

        public static void Main(string[] args)
        {
            ConstrutoresCarrao CarraoEllen = new ConstrutoresCarrao(); // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine(CarraoEllen.modeloCarrao);
        }
    }

    
}
