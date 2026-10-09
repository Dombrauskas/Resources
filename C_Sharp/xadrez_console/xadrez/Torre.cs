using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
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
            Console.WriteLine("Matriz " + Mat);
            return Mat;
        }

        public override string ToString()
        {
            return "T";
        }        
    }
}