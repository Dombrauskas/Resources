using tabuleiro;

namespace xadrez
{
    class PartidaXadrez
    {
        public Tabuleiro Tab { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }
        
        public PartidaXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branco;
            Terminada = false;
            ColocarPecas();
        }
        
        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RemoverPeca(origem);
            p.IncrementarMovimento();
            Peca PecaCapturada = Tab.RemoverPeca(destino);
            Tab.ColocarPeca(p, destino);
        }
        
        public void RealizaMovimento(Posicao origem, Posicao destino)
        {
            ExecutarMovimento(origem, destino);
            Turno++;
            MudarVezJogador();
        }
        
        private void MudarVezJogador()
        {
            JogadorAtual = (Turno % 2 == 1) ? Cor.Branco : Cor.Preto;
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
        
        public void ValidarPosicaoDestino(Posicao origem, Posicao destino)
        {
            if (!Tab.Peca(origem).PodeMoverParaDestino(destino))
                throw new TabuleiroException("Posição de destino inválida.");
        }
        
        private void ColocarPecas()
        {
            // Peças Branca
            Tab.ColocarPeca(new Rei(Tab, Cor.Branco), new PosicaoXadrez('e', 1).ParaPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branco), new PosicaoXadrez('h', 1).ParaPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branco), new PosicaoXadrez('a', 1).ParaPosicao());
            
            // Peças Pretas
            Tab.ColocarPeca(new Torre(Tab, Cor.Preto), new PosicaoXadrez('a', 8).ParaPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preto), new PosicaoXadrez('h', 8).ParaPosicao());
            Tab.ColocarPeca(new Rei(Tab, Cor.Preto), new PosicaoXadrez('e', 8).ParaPosicao());
        }
    }
}