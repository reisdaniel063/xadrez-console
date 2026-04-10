using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        public static void Main(string[] args)
        {

            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);
                tabuleiro.colocarPeca(new Torre(Cor.Branca, tabuleiro), new Posicao(0, 0));
                tabuleiro.colocarPeca(new Rei(Cor.Branca, tabuleiro), new Posicao(1, 9));
                tabuleiro.colocarPeca(new Torre(Cor.Preta, tabuleiro), new Posicao(2, 4));
                Tela.ImprimirTabuleiro(tabuleiro);
            } catch (TabuleiroException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}