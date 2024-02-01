using System;
using System.Diagnostics;

namespace Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            
            Console.WriteLine("=======================================\n\tW3lc8m3_T8_Cyberworld!\n=======================================\n");
            Console.WriteLine(" _     _  _______  ___      _______  _______  __   __  _______");
            Console.WriteLine("| | _ | ||       ||   |    |       ||       ||  |_|  ||       |");
            Console.WriteLine("| || || ||    ___||   |    |       ||   _   ||       ||    ___|");
            Console.WriteLine("|       ||   |___ |   |    |       ||  | |  ||       ||   |___");
            Console.WriteLine("|       ||    ___||   |___ |      _||  |_|  ||       ||    ___|");
            Console.WriteLine("|   _   ||   |___ |       ||     |_ |       || ||_|| ||   |___");
            Console.WriteLine("|__| |__||_______||_______||_______||_______||_|   |_||_______|\n");
            Console.Beep();


            Console.Write("Digite o seu nome: ");
            String name = Console.ReadLine();

            Console.WriteLine($"Olá {name}");
            Console.Write("Deseja montar um computador? (s/n) ");
            String resp = Console.ReadLine();


            if (resp == "s")
            {
                Console.Write("Digite qual a sua placa mãe: ");
                String placa = Console.ReadLine();
                Console.Write("Digite qual o seu processador: ");
                String processador = Console.ReadLine();
                Console.Write("Digite qual o tipo de armazenamento: ");
                String armazenamento = Console.ReadLine();
                Console.Write("Digite a quantidade de RAM: ");
                int RAM = Convert.ToInt32(Console.ReadLine());

                Computador computer = new Computador(placa, processador, armazenamento, RAM);
                while (continuar)
                {
                    try
                    {
                        Console.WriteLine("O que deseja fazer agora? (1-ligar_Desligar/2-Navegar/3-Especificações/4-Upgrade/5-Sair)");
                        int actions = Convert.ToInt32(Console.ReadLine());
                        switch (actions)
                        {
                            case 1:
                                computer.Ligar_desligar();
                                break;
                            case 2:
                                computer.utilizar();
                                break;
                            case 3:
                                computer.Mostrar();
                                break;
                            case 4:
                                computer.Upgrade();
                                break;
                            case 5:
                                continuar = false;
                                Console.WriteLine($"Até mais {name} !");
                                Console.WriteLine("\n=================================\n\tExiting program\n=================================\n");
                                break;
                            default:
                                Console.WriteLine("Command not found!");
                                break;
                        }
                    }
                    catch (FormatException f)
                    {
                        Console.WriteLine(f.ToString());
                    }
                }
            }
 

            Console.ReadKey();
        }
    }
}