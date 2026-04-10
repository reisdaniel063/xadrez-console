
using tabuleiro;

namespace xadrez_console.tabuleiro
{
    internal class Peca
    {
        public Posicao posicao  { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; set; }
        public Tabuleiro tab { get; set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tabuleiro)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tabuleiro;
        }



    }
}
