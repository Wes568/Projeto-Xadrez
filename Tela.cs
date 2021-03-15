﻿using System;
using tabuleiro;
namespace Xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for(int y=0; y < tab.colunas; y++)
                {
                    if (tab.peca(i, y) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, y) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}