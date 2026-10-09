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
                    try {
                        Console.Clear();
                        Tela.ImprimirPartida(Partida);
                        
                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao Origem = Tela.LerPosicaoXadrex().ParaPosicao();
                        
                        Partida.ValidarPosicaoOrigem(Origem);
                        
                        bool[,] PosicoesPossiveis = Partida.Tab.Peca(Origem).MovimentoPossivel();
                        
                        Console.Clear();
                        Tela.ImprimirTabuleiro(Partida.Tab, PosicoesPossiveis);
                        
                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao Destino = Tela.LerPosicaoXadrex().ParaPosicao();
                        Partida.ValidarPosicaoDestino(Origem, Destino);
                        
                        Partida.RealizaMovimento(Origem, Destino);
                    }
                    catch (TabuleiroException te)
                    {
                        Console.WriteLine(te.Message);
                        Console.ReadLine();
                    }
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