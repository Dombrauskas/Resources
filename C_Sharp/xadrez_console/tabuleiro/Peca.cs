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
        
        public bool ExisteMovimento()
        {
            bool[,] Mat = MovimentoPossivel();
            
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (Mat[i, j])
                        return true;
                }
            }
            return false;
        }
        
        public void IncrementarMovimento()
        {
            QteMovimentos++;
        }
        
        public void DecrementarMovimento()
        {
            QteMovimentos--;
        }
        
        public bool PodeMoverParaDestino(Posicao destino)
        {
            return MovimentoPossivel()[destino.linha, destino.coluna];
        }
        
        public abstract bool[,] MovimentoPossivel();
    }
}