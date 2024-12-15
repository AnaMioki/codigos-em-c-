using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoOrientadaAObjetos
{
    internal class ExibirComputador
    {
        public static void Main(string[] args)
        {
            Computador computadorGamer = new Computador();
            Console.WriteLine($"O processador é {computadorGamer.processador}, a memória RAM é {computadorGamer.memoriaRAM}, o armazenamento é {computadorGamer.armazenamento}, a placa de vídeo é {computadorGamer.placaVideo} e o monitor é {computadorGamer.monitor} ");
        }
    }
}
