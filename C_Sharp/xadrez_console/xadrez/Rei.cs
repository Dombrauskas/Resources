using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        private PartidaXadrez Partida;
        
        public Rei(Tabuleiro tab, Cor cor, PartidaXadrez paritda) : base(tab, cor)
        {
            Partida = paritda;
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
            
            // roque pequeno
            if (QteMovimentos == 0 && !Partida.Xeque)
            {
                Posicao PosicaoTorre = new Posicao(posicao.linha, posicao.coluna + 3);
                if (TorreDisponivelParaRoque(PosicaoTorre))
                {
                    Posicao p1 = new Posicao(posicao.linha, posicao.coluna + 1);
                    Posicao p2 = new Posicao(posicao.linha, posicao.coluna + 2);
                    if (tabuleiro.Peca(p1) == null && tabuleiro.Peca(p2) == null)
                    {
                        Mat[posicao.linha, posicao.coluna + 2] = true;
                    }
                }
            }
            
            // roque grande
            if (QteMovimentos == 0 && !Partida.Xeque)
            {
                Posicao PosicaoTorre = new Posicao(posicao.linha, posicao.coluna - 4);
                if (TorreDisponivelParaRoque(PosicaoTorre))
                {
                    Posicao p1 = new Posicao(posicao.linha, posicao.coluna - 1);
                    Posicao p2 = new Posicao(posicao.linha, posicao.coluna - 2);
                    Posicao p3 = new Posicao(posicao.linha, posicao.coluna - 3);
                    if (tabuleiro.Peca(p1) == null && tabuleiro.Peca(p2) == null && tabuleiro.Peca(p3) == null)
                    {
                        Mat[posicao.linha, posicao.coluna - 2] = true;
                    }
                }
            }
            
            return Mat;
        }
        
        private bool TorreDisponivelParaRoque(Posicao posicao)
        {
            Peca p = tabuleiro.Peca(posicao);
            return p != null && p is Torre && p.cor == cor && p.QteMovimentos == 0;
        }

        public override string ToString()
        {
            return "R";
        }
    }
}