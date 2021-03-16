using System;
using tabuleiro;
using Xadrez;

namespace Xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write((8-i)+" ");

                for(int y=0; y < tab.colunas; y++)
                {
                    if (tab.peca(new Posicao(i, y)) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Tela.imprimirPeca(tab.peca(new Posicao(i, y)));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F H G");
        }

        public static void imprimirPeca(Peca peca)
        {
            if(peca.cor== Cor.Branca)
            {
                Console.Write(peca);

            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }
    }
}
