using tabuleiro;

namespace xadrez
{
    class Rainha : Peca
    {
        public Rainha(Tabuleiro tab, Cor cor) : base(tab, cor) {}
        
        private bool PodeMover(Posicao pos)
        {
            Peca p = tabuleiro.Peca(pos);
            return p == null || p.cor != cor;
        }
        
        public override bool[,] MovimentoPossivel()
        {
            bool[,] Mat = new bool[tabuleiro.Linhas, tabuleiro.Colunas];
            Posicao pos = new(0, 0);
            
            // acima
            pos.DefinirValor(posicao.linha + 1, posicao.coluna);
            while (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.Peca(pos) != null && tabuleiro.Peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha++;
            }
            
            // abaixo
            pos.DefinirValor(posicao.linha - 1, posicao.coluna);
            while (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.Peca(pos) != null && tabuleiro.Peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha--;
            }
            
            // direita
            pos.DefinirValor(posicao.linha, posicao.coluna + 1);
            while (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.Peca(pos) != null && tabuleiro.Peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna++;
            }
            
            // Esquerda
            pos.DefinirValor(posicao.linha, posicao.coluna - 1);
            while (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.Peca(pos) != null && tabuleiro.Peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna--;
            }
            
            
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
            return "Q";
        }
    }
}