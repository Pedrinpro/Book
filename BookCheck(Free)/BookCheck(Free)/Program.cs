using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookCheck_Free_
{
    internal class Program
    {
        static Dictionary<string, List<int>> Livros = new Dictionary<string, List<int>>();
        static Dictionary<string, List<int>> NOMES_EMP = new Dictionary<string, List<int>>();


        static void Main(string[] args)
        {
            logo();
            menu();
        }
        static void logo()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"██████╗░░█████╗░░█████╗░██╗░░██╗░█████╗░██╗░░██╗███████╗░█████╗░██╗░░██╗
██╔══██╗██╔══██╗██╔══██╗██║░██╔╝██╔══██╗██║░░██║██╔════╝██╔══██╗██║░██╔╝
██████╦╝██║░░██║██║░░██║█████═╝░██║░░╚═╝███████║█████╗░░██║░░╚═╝█████═╝░
██╔══██╗██║░░██║██║░░██║██╔═██╗░██║░░██╗██╔══██║██╔══╝░░██║░░██╗██╔═██╗░
██████╦╝╚█████╔╝╚█████╔╝██║░╚██╗╚█████╔╝██║░░██║███████╗╚█████╔╝██║░╚██╗
╚═════╝░░╚════╝░░╚════╝░╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝╚══════╝░╚════╝░╚═╝░░╚═╝");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void menu()
        {

            Console.WriteLine("Seja bem vindo ao BOOKCHECK.");
            Console.WriteLine("O que deseja fazer? (Escreva no modelo [01], [02])");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[01] Adicionar um livro");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[02] Emprestar um livro");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("[03] Definir tempo de devolução");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[04] Marcar como devolvido");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[05] Anotar nomes");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[06] Ver os livros listados ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("[07 Ver nomes]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[00] Sair");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("$_Opção: ");
            String rep = Console.ReadLine();

            switch (rep)
            {
                case "01":
                    add();
                    break;
                case "02":
                    emp();
                    break;
                case "03":
                    temp();
                    break;
                case "04":
                    mark();
                    break;
                case "05":
                    nome();
                    break;
                case "06":
                    lista();
                    break;
                case "07":
                    LIST_NOME();
                    break;
                default:
                    erro();
                    break;

            }
        }
        static void add()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Qual Livro deseja adicionar?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("$_nome: ");
            String NOM_LIVRO = Console.ReadLine();
            Livros.Add(NOM_LIVRO, new List<int>());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Livro {NOM_LIVRO} adicionado!");
            Thread.Sleep(2000);
            Console.Clear();
            Thread.Sleep(500);
            logo();
            menu();

        }
        static void emp()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Que livro você deseja marcar?");
            Console.WriteLine("$_livro:");
            string EMP = Console.ReadLine();

            if (Livros.ContainsKey(EMP)) // Verifica se a chave está presente no dicionário
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Marque como [E/NE]");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("$_");
                string tempo = Console.ReadLine();
                logo();
                menu();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nome não encontrado na lista.");
                Console.Clear();
                logo();
                menu();
            }
        }
        static void mark()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Que livro você deseja marcar?");
            Console.WriteLine("$_livro:");
            string LVR_EMP = Console.ReadLine();

            if (Livros.ContainsKey(LVR_EMP)) // Verifica se a chave está presente no dicionário
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Marque como [D/ND]");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("$_");
                string tempo = Console.ReadLine();
                logo();
                menu();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nome não encontrado na lista de empréstimos.");
                Console.Clear();
                logo();
                menu();
            }
        }
        static void lista()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            int contador = 1;
            foreach (string l in Livros.Keys)
            {
                Console.WriteLine($"Livro_{contador}: {l}");
                contador++;

            }
            Console.WriteLine("Pressione enter para voltar ao menu");
            Console.ReadLine();
            Console.Clear();
            Thread.Sleep(500);
            logo();
            menu();

        }
        static void nome()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("$_Nome do cliente: ");
            String NOME = Console.ReadLine();
            NOMES_EMP.Add(NOME, new List<int>());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{NOME} foi registrado no sistema:");
            Thread.Sleep(2000);
            Console.Clear();
            logo();
            menu();
        }
        static void erro()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Insira um valor!");
            Thread.Sleep(2000);
            Console.Clear();
            logo();
            menu();
        }
        static void LIST_NOME()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            int contador = 1;
            foreach (string l in NOMES_EMP.Keys)
            {
                Console.WriteLine($"Pessoa_{contador}: {l}");
                contador++;

            }
            Console.WriteLine("Pressione enter para voltar ao menu");
            Console.ReadLine();
            Console.Clear();
            Thread.Sleep(500);
            logo();
            menu();
        }
        static void temp()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Quem você deseja adicionar o tempo?");
            Console.WriteLine("$_Nome");
            string NOME_TEMP = Console.ReadLine();

            if (NOMES_EMP.ContainsKey(NOME_TEMP)) // Verifica se a chave está presente no dicionário
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Quanto tempo deseja dar para devolução?");
                string tempo = Console.ReadLine();

                Console.WriteLine("Data de hoje: ");
                string data = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{NOME_TEMP} foi adicionado com {tempo} para devolver. A data de início foi {data}");
                Console.Clear();
                logo();
                menu();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nome não encontrado na lista de empréstimos.");
                Console.Clear();
                logo();
                menu();
            }
        }

    }
}
