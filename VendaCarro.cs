using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoOrientadaAObjetos
{
    internal class VendaCarro
    {
        public int idCarro;
        public string modeloCarro;
        public string corCarro;
        public int ano;
        public int tamanhoRoda;
        public void velocidadeMaxima()
        {
            Console.WriteLine("O carro está indo o mais rápido que pode");
        }
    }
}
