using System;
using tabuleiro;

namespace jogo_xadrez_terminal
{
    class Tela
    {

        public static void imprimirTabuleiro(Tabuleiro tab)
        {

            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.Write("  a b c d e f g h");
        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor; //pega a cor do sistema "branco" e salva em aux
                Console.ForegroundColor = ConsoleColor.Yellow; //coloca amarelo na peça
                Console.Write(peca); //imprime
                Console.ForegroundColor = aux; //volta a peça na cor do sistema
            }
        }
    }
}