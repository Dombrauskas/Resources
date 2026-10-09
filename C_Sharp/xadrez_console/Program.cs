using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaXadrez Partida = new PartidaXadrez();
                
                while (!Partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(Partida.Tab);
                    
                    Console.Write("Origem: ");
                    Posicao Origem = Tela.LerPosicaoXadrex().ParaPosicao();
                    Console.Write("Destino: ");
                    Posicao Destino = Tela.LerPosicaoXadrex().ParaPosicao();
                    
                    Partida.ExecutarMovimento(Origem, Destino);
                }
            }
            catch (TabuleiroException te)
            {
                Console.WriteLine(te.Message);
            }
            Console.WriteLine();
        }
    }
}