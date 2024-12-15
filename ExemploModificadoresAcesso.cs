using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoOrientadaAObjetos
{
    internal class ExemploModificadoresAcesso
    {
        private string cor = "vermelho";


        public static void Main(string[] args)
        {
            ExemploModificadoresAcesso herby = new ExemploModificadoresAcesso();
            Console.WriteLine("A cor do carro do Macedo é: " + herby.cor);

        }
    }
}
