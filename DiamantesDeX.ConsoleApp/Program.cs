﻿using System;

namespace DiamantesDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Digite um número:");
                var numero = Convert.ToInt32(Console.ReadLine());

                while (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par, não será possível desenhar um diamante.");
                    Console.ReadLine();
                    Console.WriteLine("Digite um número:");
                    numero = Convert.ToInt32(Console.ReadLine());
                }
                if (numero % 2 == 1)
                {
                    for (int y = 1; y < numero * 2; y = y + 2)
                    {
                        var espacoEmBranco = (numero - y) / 2;

                        if (espacoEmBranco < 0)
                        {
                            espacoEmBranco = espacoEmBranco * -1;
                        }

                        for (int i = 0; i < espacoEmBranco; i++)
                        {
                            Console.Write(" ");
                        }

                        var metadeDiamante = (numero - 1) / 2;
                        var quantidadeX = ((metadeDiamante - espacoEmBranco) * 2) + 1;

                        for (int i = 0; i < quantidadeX; i++)
                        {
                            Console.Write("x");
                        }

                        for (int i = 0; i < espacoEmBranco; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                    Console.ReadLine();
                }
            }

        }
    }
}
