using System;

namespace ConsoleApp1
{
    class Program
    {

        class JogoDaVelha
        {
            int ContJogador1 = 0;
            int ContJogador2 = 0;
            int ContPartida = 1;

            public int PartidasJogadas
            {
                get { return ContPartida; }
                set { ContPartida = value; }
            }

            public int Jogador1Pontos
            {
                get { return ContJogador1; }
                set { ContJogador1 = value; }
            }

            public int Jogador2Pontos
            {
                get { return ContJogador2; }
                set { ContJogador2 = value; }
            }

            public int RetornaVitoria(char[] arrayColunas)
            {
                //  Horizontal - 1
                if (arrayColunas[1] == arrayColunas[2] && arrayColunas[2] == arrayColunas[3])
                {
                    ContPartida++;
                    if (arrayColunas[1] == 'x')
                    {
                        ContJogador1++;
                        return 1;
                    }
                    else
                    {
                        ContJogador2++;
                        return 1;
                    }
                }

                //  Horizontal - 2
                else if (arrayColunas[4] == arrayColunas[5] && arrayColunas[5] == arrayColunas[6])
                {
                    ContPartida++;
                    if (arrayColunas[4] == 'x')
                    {
                        ContJogador1++;
                        return 1;
                    }
                    else
                    {
                        ContJogador2++;
                        return 1;
                    }
                }

                //  Horizontal - 3
                else if (arrayColunas[6] == arrayColunas[7] && arrayColunas[7] == arrayColunas[8])
                {
                    ContPartida++;
                    if (arrayColunas[6] == 'x')
                    {
                        ContJogador1++;
                        return 1;
                    }
                    else
                    {
                        ContJogador2++;
                        return 1;
                    }
                }

                //  Vertical - 1
                else if (arrayColunas[1] == arrayColunas[4] && arrayColunas[4] == arrayColunas[7])
                {
                    ContPartida++;
                    if (arrayColunas[1] == 'x')
                    {
                        ContJogador1++;
                        return 1;
                    }
                    else
                    {
                        ContJogador2++;
                        return 1;
                    }
                }

                //  Vertical - 2
                else if (arrayColunas[2] == arrayColunas[5] && arrayColunas[5] == arrayColunas[8])
                {
                    ContPartida++;
                    if (arrayColunas[2] == 'x')
                    {
                        ContJogador1++;
                        return 1;
                    }
                    else
                    {
                        ContJogador2++;
                        return 1;
                    }
                }
                //  Vertical - 3
                else if (arrayColunas[3] == arrayColunas[6] && arrayColunas[6] == arrayColunas[9])
                {
                    ContPartida++;
                    if (arrayColunas[3] == 'x')
                    {
                        ContJogador1++;
                        return 1;
                    }
                    else
                    {
                        ContJogador2++;
                        return 1;
                    }
                }


                //  Diagonal - 1
                else if (arrayColunas[1] == arrayColunas[5] && arrayColunas[5] == arrayColunas[9])
                {
                    ContPartida++;
                    if (arrayColunas[1] == 'x')
                    {
                        ContJogador1++;
                        return 1;
                    }
                    else
                    {
                        ContJogador2++;
                        return 1;
                    }
                }

                //  Diagonal - 2
                else if (arrayColunas[3] == arrayColunas[5] && arrayColunas[5] == arrayColunas[7])
                {
                    ContPartida++;
                    if (arrayColunas[3] == 'x')
                    {
                        ContJogador1++;
                        return 1;
                    }
                    else
                    {
                        ContJogador2++;
                        return 1;
                    }
                }

                //  Empate
                else if (arrayColunas[1] != '1' && arrayColunas[2] != '2' && arrayColunas[3] != '3' && arrayColunas[4] != '4' && arrayColunas[5] != '5' && arrayColunas[6] != '6' && arrayColunas[7] != '7' && arrayColunas[8] != '8' && arrayColunas[9] != '9')
                {
                    ContPartida++;
                    return -1;
                }
                else
                {
                    return 0;
                }
            }

            public int VerificaCampo(int pos, char[] arrayColunas, int Jogador)
            {
                if (pos >= 1 && pos <= 9)
                {
                    if (arrayColunas[pos] != 'x' && arrayColunas[pos] != 'o')
                    {
                        if (Jogador % 2 == 0)
                        {
                            return arrayColunas[pos] = 'o';
                        }
                        else
                        {
                            return arrayColunas[pos] = 'x';
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return -1;
                }
            }
        }

        public static void Tabuleiro(char[] arrayColunas)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arrayColunas[1], arrayColunas[2], arrayColunas[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arrayColunas[4], arrayColunas[5], arrayColunas[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arrayColunas[7], arrayColunas[8], arrayColunas[9]);
            Console.WriteLine("     |     |      ");
        }

        static void Main(string[] args)
        {
            JogoDaVelha Jogo1 = new JogoDaVelha();
            do
            {
                char[] arrayColunas = { '0','1', '2', '3', '4', '5', '6', '7', '8', '9' };
                int Jogador = 1;
                int pos = 0;
                int retornoCampo = 0;
                int retornoVitoria = 0;

                Console.WriteLine("Partida: {0}\n", Jogo1.PartidasJogadas);

                Console.WriteLine("Jogador 1: {0} pontos  X  Jogador 2: {1} pontos\n", Jogo1.Jogador1Pontos, Jogo1.Jogador2Pontos);

                Tabuleiro(arrayColunas);

                Console.WriteLine("\nAperte qualquer tecla para começar o jogo!");
                Console.ReadKey();

                do
                {
                    do
                    {
                        Console.WriteLine("\nQual posição você quer marcar?");
                        pos = int.Parse(Console.ReadLine());

                        retornoCampo = Jogo1.VerificaCampo(pos, arrayColunas, Jogador);
                        if (retornoCampo == 0)
                        {
                            Console.WriteLine("\nEste campo já está marcado!");
                        }
                        else if (retornoCampo == -1)
                        {
                            Console.WriteLine("\nPosição inválida! Escolha um número entre 1 e 9.");
                        }
                        else
                        {
                            Console.Clear();
                            Jogador++;
                            Tabuleiro(arrayColunas);
                            Console.WriteLine("\nAperte qualquer tecla para próxima rodada!");
                            Console.ReadKey();
                        }
                    } while (retornoCampo == 0);

                    retornoVitoria = Jogo1.RetornaVitoria(arrayColunas);
                    

                } while (retornoVitoria != 1 && retornoVitoria != -1);

                if (retornoVitoria == 1)
                {
                    Console.WriteLine("\nJogador {0} ganhou esta rodada!", (Jogador % 2) + 1);
                }
                else
                {
                    Console.WriteLine("\nEmpate");
                }

                Console.WriteLine("\nAperte qualquer tecla para próxima partida!");
                Console.ReadKey();
                Console.Clear();
            } while (Jogo1.PartidasJogadas < 3);

            Console.WriteLine("\nFIM DE JOGO!");

            if (Jogo1.Jogador1Pontos > Jogo1.Jogador2Pontos)
            {
                Console.WriteLine("\nJogador 1 ganhou melhor de 3!");
            }
            else
            {
                Console.WriteLine("\nJogador 2 ganhou melhor de 3!");
            }
        }
    }
}
