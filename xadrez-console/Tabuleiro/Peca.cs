namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMove { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QteMove = 0;
        }

        public abstract bool[,] MovimentosPossiveis();
        

        

        public void IncrementarQteMovimentos()
        {
            QteMove++;
        }

    }
}
