using tabuleiro;

namespace xadrez
{
    class Bispo : Peca
    {
        public Bispo(Tabuleiro tab, Cor cor) : base(tab, cor) {}
        
        private bool PodeMover(Posicao pos)
        {
            Peca p = tabuleiro.Peca(pos);
            return p == null || p.cor != cor;
        }
        
        public override bool[,] MovimentoPossivel()
        {
            bool[,] Mat = new bool[tabuleiro.Linhas, tabuleiro.Colunas];
            Posicao pos = new Posicao(0, 0);
            
            // diagonal superior direita
            pos.DefinirValor(posicao.linha + 1, posicao.coluna + 1);
            while (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.Peca(pos) != null && tabuleiro.Peca(pos).cor != cor)
                    break;
                
                pos.DefinirValor(pos.linha + 1, pos.coluna + 1);
            }
            
            // diagonal inferior direita
            pos.DefinirValor(posicao.linha - 1, posicao.coluna + 1);
            while (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.Peca(pos) != null && tabuleiro.Peca(pos).cor != cor)
                    break;
                
                pos.DefinirValor(pos.linha - 1, pos.coluna + 1);
            }
            
            // diagonal superior esquerda
            pos.DefinirValor(posicao.linha + 1, posicao.coluna - 1);
            while (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.Peca(pos) != null && tabuleiro.Peca(pos).cor != cor)
                    break;
                
                pos.DefinirValor(pos.linha + 1, pos.coluna - 1);
            }
            
            // diagonal inferior esquerda
            pos.DefinirValor(posicao.linha - 1, posicao.coluna - 1);
            while (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.Peca(pos) != null && tabuleiro.Peca(pos).cor != cor)
                    break;
                
                pos.DefinirValor(pos.linha - 1, pos.coluna - 1);
            }
            
            return Mat;
        }
        
        public override string ToString()
        {
            return "B";
        }
    }
}