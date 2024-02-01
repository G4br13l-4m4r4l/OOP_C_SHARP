using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class Computador
    {
        String placa_mae;
        String Processador;
        String Armazenamento;
        String placa_video = "nenhuma";
        int RAM;
        bool ligada = false;

        public Computador(String placa_mae, String Processador, String Armazenamento, int RAM)
        {
            this.placa_mae = placa_mae;
            this.Processador = Processador;
            this.Armazenamento = Armazenamento;
            this.RAM = RAM;
            try
            {
                Console.WriteLine("Existe placa de vídeo? (s/n)");
                String resp = Console.ReadLine();
                if(resp == "s")
                {
                    Console.WriteLine("qual a sua placa? ");
                    this.placa_video = Console.ReadLine();
                }
                Console.WriteLine("Máquina montada!!!!");
            }catch (FormatException f)
            {
                Console.WriteLine(f.Message);
            }
        }

        public void Upgrade() {
            try
            {
                Console.Write("Qual componente deseja realizar upgrade?\n1-Placa mãe\n2-Processador\n3-Armazenamento\n4-RAM\n5-Placa de Vídeo\n");
                int componente = Convert.ToInt32(Console.ReadLine());
                switch (componente)
                {
                    case 1:
                        Console.Write("Digite qual é a placa que deseja colocar: ");
                        placa_mae = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Digite qual é o processador que deseja: ");
                        Processador = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Digite qual é o armazenamento que deseja: ");
                        Armazenamento = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Digite qual é a RAM que deseja: ");
                        RAM = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.Write("Digite qual é a placa de vídeo que deseja: ");
                        placa_video = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Command not found!");
                        break;
                }
            }catch (ArithmeticException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (FormatException f)
            {
                Console.WriteLine(f.Message);
            }
        }

        public void Ligar_desligar()
        {
            if (ligada)
            {
                Console.WriteLine("Máquina está ligada ===> desligando...");
                for (int i = 0; i <= 100; i++)
                {
                    AtualizarLoading(i);
                    Thread.Sleep(50);
                }
                Console.WriteLine("\nProcesso concluido!\nmáquina desligada!\n");
                ligada = false;
            }
            else
            {
                Console.WriteLine("Máquina está desligada ===> ligando...");
                for (int i = 0; i <= 100; i++)
                {
                    AtualizarLoading(i);
                    Thread.Sleep(50);
                }
                ligada = true;
                Console.WriteLine("\nProcesso concluído!\n Máquina ligada!\n");
            }
        }

        //fazendo loading
        static void AtualizarLoading(int percentual)
        {
            int tamanhoBarra = Console.WindowWidth - 20; 
            int quantidadeCaracteres = (int)Math.Ceiling((percentual / 100.0) * tamanhoBarra);

            string barraDeProgresso = new string('=', quantidadeCaracteres);
            string espacos = new string(' ', tamanhoBarra - quantidadeCaracteres);

            Console.Write($"\r[{barraDeProgresso}{espacos}] {percentual}%");
        }

        public void utilizar()
        {
            Console.WriteLine("Deseja navegar na internet? (s/n)");
            String resp = Console.ReadLine();
            if(resp == "s")
            {
                bool sair = false;
                while(sair!= true)
                {
                    Console.WriteLine("____navegando____");
                    Console.Write("Continuar? (s/n) ");
                    String resp_2 = Console.ReadLine();
                    if(resp_2 != "s")
                    {
                        sair = true;
                        Console.WriteLine("Não está mais navegando!\n");
                    }
                }
            }
        }
        public void Mostrar()
        {
            Console.WriteLine("\n=================================\n\tESPECIFICAÇÕES\n=================================\n");
            Console.WriteLine($"Placa mãe: {placa_mae}");
            Console.WriteLine($"Processador: {Processador}");
            Console.WriteLine($"Armazenamento: {Armazenamento}");
            Console.WriteLine($"Memória RAM: {RAM}GB");
            Console.WriteLine($"placa de vídeo: {placa_video}");
            Console.WriteLine($"ON/OFF: {ligada}\n");
        }
    }
}
