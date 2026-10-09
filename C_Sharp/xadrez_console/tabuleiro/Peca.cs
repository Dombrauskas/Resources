namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QteMovimentos { get; set; }
        public Tabuleiro tabuleiro { get; protected set; }
        
        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            posicao = null;
            this.tabuleiro = tabuleiro;
            this.cor = cor;
            this.QteMovimentos = 0;
        }
        
        public void IncrementarMovimento()
        {
            QteMovimentos++;
        }
        
        public abstract bool[,] MovimentoPossivel();
    }
}