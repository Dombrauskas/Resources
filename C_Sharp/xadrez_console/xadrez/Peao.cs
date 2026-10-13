using tabuleiro;

namespace xadrez
{
    class Peao : Peca
    {
        private PartidaXadrez Partida;
        
        public Peao(Tabuleiro tab, Cor cor, PartidaXadrez partida) : base(tab, cor)
        {
            Partida = partida;
        }
        
        private bool CasaLivre(Posicao posicao)
        {
            return tabuleiro.Peca(posicao) == null;
        }
        
        private bool ExisteAdversario(Posicao posicao)
        {
            Peca p = tabuleiro.Peca(posicao);
            return p != null && p.cor != cor;
        }
        
        public override bool[,] MovimentoPossivel()
        {
            bool[,] Mat = new bool[tabuleiro.Linhas, tabuleiro.Colunas];
            Posicao pos = new(0, 0);
            
            if (cor == Cor.Branco)
            {
                // movimento básico
                pos.DefinirValor(posicao.linha - 1, posicao.coluna);
                if (tabuleiro.PosicaoValida(pos) && CasaLivre(pos))
                    Mat[pos.linha, pos.coluna] = true;
                
                // primeiro movimento possível
                pos.DefinirValor(posicao.linha - 2, posicao.coluna);
                if (tabuleiro.PosicaoValida(pos) && QteMovimentos == 0)
                    Mat[pos.linha, pos.coluna] = true;
                
                // capturar adversário diagonal
                pos.DefinirValor(posicao.linha - 1, posicao.coluna - 1);
                if (tabuleiro.PosicaoValida(pos) && ExisteAdversario(pos))
                    Mat[pos.linha, pos.coluna] = true;
                
                // capturar adversário diagonal
                pos.DefinirValor(posicao.linha - 1, posicao.coluna + 1);
                if (tabuleiro.PosicaoValida(pos) && ExisteAdversario(pos))
                    Mat[pos.linha, pos.coluna] = true;
                    
                // En Passant
                if (posicao.linha == 3)
                {
                    Posicao Esquerda = new Posicao(posicao.linha, posicao.coluna - 1);
                    if (tabuleiro.PosicaoValida(Esquerda) && ExisteAdversario(Esquerda) 
                        && tabuleiro.Peca(Esquerda) == Partida.EnPassant)
                    {
                        Mat[Esquerda.linha, Esquerda.coluna] = true;
                    }
                    
                    Posicao Direita = new Posicao(posicao.linha, posicao.coluna + 1);
                    if (tabuleiro.PosicaoValida(Direita) && ExisteAdversario(Direita) 
                        && tabuleiro.Peca(Direita) == Partida.EnPassant)
                    {
                        Mat[Direita.linha, Direita.coluna] = true;
                    }
                }
            }
            else
            {
                // movimento básico
                pos.DefinirValor(posicao.linha + 1, posicao.coluna);
                if (tabuleiro.PosicaoValida(pos) && CasaLivre(pos))
                    Mat[pos.linha, pos.coluna] = true;
                
                // primeiro movimento possível
                pos.DefinirValor(posicao.linha + 2, posicao.coluna);
                if (tabuleiro.PosicaoValida(pos) && QteMovimentos == 0)
                    Mat[pos.linha, pos.coluna] = true;
                
                // capturar adversário diagonal
                pos.DefinirValor(posicao.linha + 1, posicao.coluna - 1);
                if (tabuleiro.PosicaoValida(pos) && ExisteAdversario(pos))
                    Mat[pos.linha, pos.coluna] = true;
                
                // capturar adversário diagonal
                pos.DefinirValor(posicao.linha + 1, posicao.coluna + 1);
                if (tabuleiro.PosicaoValida(pos) && ExisteAdversario(pos))
                    Mat[pos.linha, pos.coluna] = true;
                
                // En Passant
                if (posicao.linha == 4)
                {
                    Posicao Esquerda = new Posicao(posicao.linha, posicao.coluna - 1);
                    if (tabuleiro.PosicaoValida(Esquerda) && ExisteAdversario(Esquerda) 
                        && tabuleiro.Peca(Esquerda) == Partida.EnPassant)
                    {
                        Mat[Esquerda.linha, Esquerda.coluna] = true;
                    }
                    
                    Posicao Direita = new Posicao(posicao.linha, posicao.coluna + 1);
                    if (tabuleiro.PosicaoValida(Direita) && ExisteAdversario(Direita) 
                        && tabuleiro.Peca(Direita) == Partida.EnPassant)
                    {
                        Mat[Direita.linha, Direita.coluna] = true;
                    }
                }
            }
            
            return Mat;
        }
        
        public override string ToString()
        {
            return "P";
        }
    }
}