
namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; set; }
        public Tabuleiro tab { get; set; }

        public Peca(Cor cor, Tabuleiro tabuleiro)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tabuleiro;
        }
        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
        }
}
