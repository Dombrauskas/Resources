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
        
        
        public PartidaXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branco;
            Terminada = false;
            Xeque = false;
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
            
            if (PartidaEmXeque(JogadorAtual))
            {
                DesfazMovimento(origem, destino, PecaCapturada);
                throw new TabuleiroException("O rei ficará em xeque!");
            }
            
            Xeque = PartidaEmXeque(Adversario(JogadorAtual)) ? true : false;
            Turno++;
            MudarVezJogador();
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
            ColocarNovaPeca(1, 'e', new Rei(Tab, Cor.Branco));
            ColocarNovaPeca(1, 'a', new Torre(Tab, Cor.Branco));
            ColocarNovaPeca(1, 'h', new Torre(Tab, Cor.Branco));
            
            // Peças Pretas
            ColocarNovaPeca(8, 'e', new Rei(Tab, Cor.Preto));
            ColocarNovaPeca(8, 'a', new Torre(Tab, Cor.Preto));
            ColocarNovaPeca(8, 'h', new Torre(Tab, Cor.Preto));
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