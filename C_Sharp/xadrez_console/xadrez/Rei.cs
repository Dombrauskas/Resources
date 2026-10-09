using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }
        
        private bool PodeMover(Posicao pos)
        {
            Peca p = tabuleiro.Peca(pos);
            return p == null || p.cor != cor;
        }
        
        public override bool[,] MovimentoPossivel()
        {
            bool[,] Mat = new bool[tabuleiro.Linhas, tabuleiro.Colunas];
            
            Posicao pos = new Posicao(0, 0);
            
            // acima
            pos.DefinirValor(posicao.linha + 1, posicao.coluna);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.linha, pos.coluna] = true;
            }
            
            // diagonal superior direita
            pos.DefinirValor(posicao.linha + 1, posicao.coluna + 1);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.linha, pos.coluna] = true;
            }
            
            // direita
            pos.DefinirValor(posicao.linha, posicao.coluna + 1);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.linha, pos.coluna] = true;
            }
            
            // diagonal inferior direita
            pos.DefinirValor(posicao.linha - 1, posicao.coluna + 1);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.linha, pos.coluna] = true;
            }
            
            // abaixo
            pos.DefinirValor(posicao.linha - 1, posicao.coluna);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.linha, pos.coluna] = true;
            }
            
            // diagonal inferior esquerda
            pos.DefinirValor(posicao.linha - 1, posicao.coluna - 1);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.linha, pos.coluna] = true;
            }
            
            // Esquerda
            pos.DefinirValor(posicao.linha, posicao.coluna - 1);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.linha, pos.coluna] = true;
            }
            
            // diagonal superior esquerda
            pos.DefinirValor(posicao.linha + 1, posicao.coluna - 1);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.linha, pos.coluna] = true;
            }
            
            return Mat;
        }

        public override string ToString()
        {
            return "R";
        }
    }
}