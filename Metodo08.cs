using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoOrientadaAObjetos
{
    internal class Metodo08
    {
        static int Soma(int x, int y)
        {
            return x + y;
        }

        static double Soma(double x, double y)
        {
            return x + y;
        }

        static string Soma(string x, string y)
        {
            return x + y;
        }

        public static void Main(string[] args)
        {
            int meuNumero01 = Soma(5, 6);
            double meuNumero02 = Soma(7.8, 9.2);
            string meuNome03 = Soma("Ana", "Mioki");

            Console.WriteLine("Int " + meuNumero01);
            Console.WriteLine("Double " + meuNumero02);
            Console.WriteLine("Nome " + meuNome03);
            Console.WriteLine("Nome " + Soma("Jailson", "Costa"));
        }
    }
}
