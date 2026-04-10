using System;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        public static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            Tela.ImprimirTabuleiro(tabuleiro);
        }
    }
}