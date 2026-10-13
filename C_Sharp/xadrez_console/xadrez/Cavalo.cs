using tabuleiro;

namespace xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor) {}
        
        private bool PodeMover(Posicao pos)
        {
            Peca p = tabuleiro.Peca(pos);
            return p == null || p.cor != cor;
        }
        
        public override bool[,] MovimentoPossivel()
        {
            bool[,] Mat = new bool[tabuleiro.Linhas, tabuleiro.Colunas];
            Posicao pos = new Posicao(0, 0);
            
            // frente-direita
            pos.DefinirValor(posicao.linha - 2, posicao.coluna - 1);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
                Mat[pos.linha, pos.coluna] = true;
            
            // direita-cima
            pos.DefinirValor(posicao.linha - 1, posicao.coluna - 2);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
                Mat[pos.linha, pos.coluna] = true;
            
            // direita-baixo
            pos.DefinirValor(posicao.linha + 1, posicao.coluna - 2);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
                Mat[pos.linha, pos.coluna] = true;
            
            // baixo-direita
            pos.DefinirValor(posicao.linha + 2, posicao.coluna - 1);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
                Mat[pos.linha, pos.coluna] = true;
            
            // baixo-esquerda
            pos.DefinirValor(posicao.linha + 2, posicao.coluna + 1);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
                Mat[pos.linha, pos.coluna] = true;
            
            // esquerda-baixo
            pos.DefinirValor(posicao.linha + 1, posicao.coluna + 2);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
                Mat[pos.linha, pos.coluna] = true;
            
            // esquerda-cima
            pos.DefinirValor(posicao.linha - 1, posicao.coluna + 2);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
                Mat[pos.linha, pos.coluna] = true;
            
            // frente-esquerda
            pos.DefinirValor(posicao.linha - 2, posicao.coluna + 1);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
                Mat[pos.linha, pos.coluna] = true;
            
            return Mat;
        }
        
        public override string ToString()
        {
            return "C";
        }
    }
}