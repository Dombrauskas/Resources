using tabuleiro;

namespace xadrez
{
    class PartidaXadrez
    {
        public Tabuleiro Tab { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        
        public PartidaXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branco;
            ColocarPecas();
        }
        
        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RemoverPeca(origem);
            p.IncrementarMovimento();
            Peca PecaCapturada = Tab.RemoverPeca(destino);
            Tab.ColocarPeca(p, destino);
        }
        
        private void ColocarPecas()
        {
            Tab.ColocarPeca(new Torre(Tab, Cor.Preto), new PosicaoXadrez('a', 0).ParaPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preto), new PosicaoXadrez('b', 3).ParaPosicao());
            Tab.ColocarPeca(new Rei(Tab, Cor.Preto), new PosicaoXadrez('c', 4).ParaPosicao());

        }
    }
}