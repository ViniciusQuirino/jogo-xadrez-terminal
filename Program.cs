﻿using System;
using jogo_xadrez_terminal;
using tabuleiro;
using xadrez;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('b', 8);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());

            Console.ReadLine();
           
            // try
            // {
            //     Tabuleiro tab = new Tabuleiro(8, 8);

            //     tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            //     tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            //     tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

            //     Tela.imprimirTabuleiro(tab);
            // }
            // catch (TabuleiroException e)
            // {
            //     Console.WriteLine(e.Message);
            // }

            // Console.ReadLine();
        }
    }
}