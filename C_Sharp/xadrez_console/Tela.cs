using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j=0; j < tab.Colunas; j++)
                {
                    ImprimirPeca(tab.Peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        
        public static void ImprimirTabuleiro(Tabuleiro tab, bool[,] posicoes)
        {
            ConsoleColor FundoOriginal = Console.BackgroundColor;
            ConsoleColor FundoAlterado = ConsoleColor.DarkGray;
            
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j=0; j < tab.Colunas; j++)
                {
                    Console.BackgroundColor = (posicoes[i, j]) ? FundoAlterado : FundoOriginal;
                    ImprimirPeca(tab.Peca(i, j));
                    Console.BackgroundColor = FundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = FundoOriginal;
            Console.WriteLine(posicoes);
        }
        
        public static void ImprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else {
                if (peca.cor == Cor.Branco)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
        
        public static PosicaoXadrez LerPosicaoXadrex()
        {
            string Input = Console.ReadLine();
            char Coluna = Input[0];
            int Linha = int.Parse(Input[1] + "");
            return new PosicaoXadrez(Coluna, Linha);
        }
    }
}