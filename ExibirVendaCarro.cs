using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoOrientadaAObjetos
{
    internal class ExibirVendaCarro
    {
        public static void Main(string[] args)
        {
            VendaCarro Carro1 = new VendaCarro();
            Carro1.idCarro = 0123;
            Carro1.modeloCarro = "Fusquinha";
            Carro1.corCarro = "gray";
            Carro1.ano = 1982;
            Carro1.tamanhoRoda = 16;
            Console.WriteLine($"O id do carro é {Carro1.idCarro},  o modelo é {Carro1.modeloCarro}, a cor é {Carro1.corCarro}, o ano de fabricação é {Carro1.ano}, e o tamanho da roda é {Carro1.tamanhoRoda} polegadas.");

        }
    }
}
