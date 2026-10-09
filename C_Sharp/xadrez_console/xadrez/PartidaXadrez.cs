using tabuleiro;

namespace xadrez
{
    class PartidaXadrez
    {
        public Tabuleiro Tab { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
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
        
        private void ColocarPecas()
        {
            Tab.ColocarPeca(new Torre(Tab, Cor.Preto), new PosicaoXadrez('a', 8).ParaPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preto), new PosicaoXadrez('h', 8).ParaPosicao());
            Tab.ColocarPeca(new Rei(Tab, Cor.Preto), new PosicaoXadrez('e', 8).ParaPosicao());
        }
    }
}