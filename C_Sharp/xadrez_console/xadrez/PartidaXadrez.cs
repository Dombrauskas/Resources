using tabuleiro;

namespace xadrez
{
    class PartidaXadrez
    {
        public Tabuleiro Tab { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }
        private HashSet<Peca> PecasJogo;
        private HashSet<Peca> PecasCapturadas;
        public bool Xeque { get; private set; }
        public Peca EnPassant { get; private set; }
        
        
        public PartidaXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branco;
            Terminada = false;
            Xeque = false;
            EnPassant = null;
            PecasJogo = new HashSet<Peca>();
            PecasCapturadas = new HashSet<Peca>();
            ColocarPecas();
        }
        
        
        public HashSet<Peca> CapturadaPorCor(Cor cor)
        {
            HashSet<Peca> Aux = [];
            
            foreach (Peca p in PecasCapturadas)
                if (p.cor == cor)
                    Aux.Add(p);
                    
            return Aux;
        }
        
        public void DesfazMovimento(Posicao origem, Posicao destino, Peca peca)
        {
            Peca p = Tab.RemoverPeca(destino);
            p.DecrementarMovimento();
            if (peca != null) {
                Tab.ColocarPeca(peca, destino);
                PecasCapturadas.Remove(peca);
            }
            Tab.ColocarPeca(p, origem);
            
            // Jogada Roque Pequeno
            if (p is Rei && destino.coluna == origem.coluna + 2)
            {
                Posicao OrigemTorre = new Posicao(origem.linha, origem.coluna + 3);
                Posicao DestinoTorre = new Posicao(origem.linha, origem.coluna + 1);
                Peca T = Tab.RemoverPeca(OrigemTorre);
                T.DecrementarMovimento();
                Tab.ColocarPeca(T, DestinoTorre);
            }

            // Jogada Roque Grande
            if (p is Rei && destino.coluna == origem.coluna - 2)
            {
                Posicao OrigemTorre = new Posicao(origem.linha, origem.coluna - 4);
                Posicao DestinoTorre = new Posicao(origem.linha, origem.coluna - 1);
                Peca T = Tab.RemoverPeca(OrigemTorre);
                T.DecrementarMovimento();
                Tab.ColocarPeca(T, DestinoTorre);
            }
            
            // Jogada En Passant
            if (p is Peao)
            {
                if (origem.coluna != destino.coluna && peca == EnPassant)
                {
                    Peca Peao = Tab.RemoverPeca(destino);
                    Posicao PosicaoPeao;
                    if (p.cor == Cor.Branco)
                    {
                        PosicaoPeao = new Posicao(3, destino.coluna);
                    }
                    else
                    {
                        PosicaoPeao = new Posicao(4, destino.coluna);
                    }
                    Tab.ColocarPeca(Peao, PosicaoPeao);
                }
            }
        }
        
        public HashSet<Peca> EmJogoPorCor(Cor cor)
        {
            HashSet<Peca> Aux = [];
            
            foreach (Peca p in PecasJogo)
                if (p.cor == cor)
                    Aux.Add(p);
                    
            Aux.ExceptWith(CapturadaPorCor(cor));
            return Aux;
        }
        
        public Peca ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RemoverPeca(origem);
            p.IncrementarMovimento();
            Peca PecaCapturada = Tab.RemoverPeca(destino);
            Tab.ColocarPeca(p, destino);
            
            if (PecaCapturada != null)
                PecasCapturadas.Add(PecaCapturada);
            
            // Jogada Roque Pequeno
            if (p is Rei && destino.coluna == origem.coluna + 2)
            {
                Posicao OrigemTorre = new Posicao(origem.linha, origem.coluna + 3);
                Posicao DestinoTorre = new Posicao(origem.linha, origem.coluna + 1);
                Peca T = Tab.RemoverPeca(OrigemTorre);
                T.IncrementarMovimento();
                Tab.ColocarPeca(T, DestinoTorre);
            }
            
            // Jogada Roque Grande
            if (p is Rei && destino.coluna == origem.coluna - 2)
            {
                Posicao OrigemTorre = new Posicao(origem.linha, origem.coluna - 4);
                Posicao DestinoTorre = new Posicao(origem.linha, origem.coluna - 1);
                Peca T = Tab.RemoverPeca(OrigemTorre);
                T.IncrementarMovimento();
                Tab.ColocarPeca(T, DestinoTorre);
            }
            
            // Jogada En Passant
            if (p is Peao)
            {
                if (origem.coluna != destino.coluna && PecaCapturada == null)
                {
                    Posicao PosicaoPeao;
                    if (p.cor == Cor.Branco)
                    {
                        PosicaoPeao = new Posicao(destino.linha + 1, destino.coluna);
                    }
                    else
                    {
                        PosicaoPeao = new Posicao(destino.linha - 1, destino.coluna);
                    }
                    PecaCapturada = Tab.RemoverPeca(PosicaoPeao);
                    PecasCapturadas.Add(PecaCapturada);
                }
            }
            
            return PecaCapturada;
        }
        
        public bool PartidaEmXeque(Cor cor)
        {
            Peca Rei = CorRei(cor) ?? throw new TabuleiroException($"Não há rei {cor} na partida.");
            
            foreach (Peca p in EmJogoPorCor(Adversario(cor)))
            {
                bool[,] Mat = p.MovimentoPossivel();
                if (Mat[Rei.posicao.linha, Rei.posicao.coluna])
                    return true;
            }
            return false;
        }
        
        public void RealizaMovimento(Posicao origem, Posicao destino)
        {
            Peca PecaCapturada = ExecutarMovimento(origem, destino);
            Peca p = Tab.Peca(destino);
            
            if (PartidaEmXeque(JogadorAtual))
            {
                DesfazMovimento(origem, destino, PecaCapturada);
                throw new TabuleiroException("O rei ficará em xeque!");
            }
            
            // Promoção
            if (p is Peao)
            {
                if ((p.cor == Cor.Branco && destino.linha == 0) || (p.cor == Cor.Preto && destino.linha == 7))
                {
                    p = Tab.RemoverPeca(destino);
                    PecasJogo.Remove(p);
                    Peca Rainha = new Rainha(Tab, p.cor);
                    Tab.ColocarPeca(Rainha, destino);
                    PecasJogo.Add(Rainha);
                }
            }
            
            Xeque = PartidaEmXeque(Adversario(JogadorAtual)) ? true : false;
            
            if (XequeMate(Adversario(JogadorAtual)))
                Terminada = true;
            else {
                Turno++;
                MudarVezJogador();
            }
            
            if (p is Peao && (destino.linha == origem.linha - 2 || destino.linha == origem.linha + 2))
                EnPassant = p;
        }
        
        
        public void ValidarPosicaoDestino(Posicao origem, Posicao destino)
        {
            if (!Tab.Peca(origem).PodeMoverParaDestino(destino))
                throw new TabuleiroException("Posição de destino inválida.");
        }
        
        public void ValidarPosicaoOrigem(Posicao pos)
        {
            if (Tab.Peca(pos) == null)
                throw new TabuleiroException("Não existe peça na posição escolhida.");
            
            if (JogadorAtual != Tab.Peca(pos).cor)
                throw new TabuleiroException("Esta peça não é sua.");
                
            if (!Tab.Peca(pos).ExisteMovimento())
                throw new TabuleiroException("Não há movimentos possíveis para esta peça.");
        }
        
        public bool XequeMate(Cor cor)
        {
            if (!PartidaEmXeque(cor))
                return false;
            
            foreach (Peca p in EmJogoPorCor(cor))
            {
                bool[,] Mat = p.MovimentoPossivel();
                for (int i = 0; i < Tab.Linhas; i++)
                {
                    for (int j = 0; j < Tab.Colunas; j++)
                    {
                        if (Mat[i, j])
                        {
                            Posicao Origem = p.posicao;
                            Posicao Destino = new Posicao(i, j);
                            Peca peca = ExecutarMovimento(Origem, Destino);
                            bool TesteXeque = PartidaEmXeque(cor);
                            DesfazMovimento(Origem, Destino, peca);
                            if (!TesteXeque) 
                                return false;
                        }
                    }
                }
            }
            return true;
        }
        
        private Cor Adversario(Cor cor)
        {
            return (cor == Cor.Branco) ? Cor.Preto : Cor.Branco;
        }
        
        public void ColocarNovaPeca(int linha, char coluna, Peca peca)
        {
            Tab.ColocarPeca(peca, new PosicaoXadrez(coluna, linha).ParaPosicao());
            PecasJogo.Add(peca);
        }
        
        
        private void ColocarPecas()
        {
            // Peças Branca
            ColocarNovaPeca(1, 'a', new Torre(Tab, Cor.Branco));
            ColocarNovaPeca(1, 'b', new Cavalo(Tab, Cor.Branco));
            ColocarNovaPeca(1, 'c', new Bispo(Tab, Cor.Branco));
            ColocarNovaPeca(1, 'd', new Rainha(Tab, Cor.Branco));
            ColocarNovaPeca(1, 'e', new Rei(Tab, Cor.Branco, this));
            ColocarNovaPeca(1, 'f', new Bispo(Tab, Cor.Branco));
            ColocarNovaPeca(1, 'g', new Cavalo(Tab, Cor.Branco));
            ColocarNovaPeca(1, 'h', new Torre(Tab, Cor.Branco));
            ColocarNovaPeca(2, 'a', new Peao(Tab, Cor.Branco, this));
            ColocarNovaPeca(2, 'b', new Peao(Tab, Cor.Branco, this));
            ColocarNovaPeca(2, 'c', new Peao(Tab, Cor.Branco, this));
            ColocarNovaPeca(2, 'd', new Peao(Tab, Cor.Branco, this));
            ColocarNovaPeca(2, 'e', new Peao(Tab, Cor.Branco, this));
            ColocarNovaPeca(2, 'f', new Peao(Tab, Cor.Branco, this));
            ColocarNovaPeca(2, 'g', new Peao(Tab, Cor.Branco, this));
            ColocarNovaPeca(2, 'h', new Peao(Tab, Cor.Branco, this));
            
            // Peças Pretas
            ColocarNovaPeca(8, 'a', new Torre(Tab, Cor.Preto));
            ColocarNovaPeca(8, 'b', new Cavalo(Tab, Cor.Preto));
            ColocarNovaPeca(8, 'c', new Bispo(Tab, Cor.Preto));
            ColocarNovaPeca(8, 'd', new Rainha(Tab, Cor.Preto));
            ColocarNovaPeca(8, 'e', new Rei(Tab, Cor.Preto, this));
            ColocarNovaPeca(8, 'f', new Bispo(Tab, Cor.Preto));
            ColocarNovaPeca(8, 'g', new Cavalo(Tab, Cor.Preto));
            ColocarNovaPeca(8, 'h', new Torre(Tab, Cor.Preto));
            ColocarNovaPeca(7, 'a', new Peao(Tab, Cor.Preto, this));
            ColocarNovaPeca(7, 'b', new Peao(Tab, Cor.Preto, this));
            ColocarNovaPeca(7, 'c', new Peao(Tab, Cor.Preto, this));
            ColocarNovaPeca(7, 'd', new Peao(Tab, Cor.Preto, this));
            ColocarNovaPeca(7, 'e', new Peao(Tab, Cor.Preto, this));
            ColocarNovaPeca(7, 'f', new Peao(Tab, Cor.Preto, this));
            ColocarNovaPeca(7, 'g', new Peao(Tab, Cor.Preto, this));
            ColocarNovaPeca(7, 'h', new Peao(Tab, Cor.Preto, this));
        }
        
        private Peca CorRei(Cor cor)
        {
            foreach (Peca p in EmJogoPorCor(cor))
                if (p is Rei)
                    return p;
            
            return null;
        }
        
        private void MudarVezJogador()
        {
            JogadorAtual = (Turno % 2 == 1) ? Cor.Branco : Cor.Preto;
        }
    }
}