using System;
using System.Collections.Generic;

namespace exerLista
{
    class Program : Item
    {
        public static List<Item> listaItem = new List<Item>();

        static void Main(string[] args)
        {
            byte opcao = default;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("|                 MENU                   |");
                Console.WriteLine("| Seja bem vindo ao sistema.             |");
                Console.WriteLine("| Informe a opção que desejar            |");
                Console.WriteLine("| 1 - Adicionar Item na lista            |");
                Console.WriteLine("| 2 - Adicionar Item no inicio da lista  |");
                Console.WriteLine("| 3 - Adicionar Item na i-esima posição  |");
                Console.WriteLine("| 4 - Informações da lista               |");
                Console.WriteLine("| 5 - Retirar primeiro item              |");
                Console.WriteLine("| 6 - Retirar i-ésimo item               |");
                Console.WriteLine("| 7 - Retirar primeira ocorrencia        |");
                Console.WriteLine("| 8 - Localizar primeira ocorrencia      |");
                Console.WriteLine("| 9 - Copiar lista                       |");
                Console.WriteLine("| 0 - Sair                               |");
                Console.WriteLine("-----------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;

                opcao = Convert.ToByte(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Adicionar();
                        break;
                    case 2:
                        AdicionarInicio();
                        break;
                    case 3:
                        AdicionarIesimo();
                        break;
                    case 4:
                        InfoLista();
                        break;
                    case 5:
                        RemoverPrimeiroItem();
                        break;
                    case 6:
                        RemoverIesimoItem();
                        break;
                    case 7:
                        RetirarPrimeiraOcorrencia();
                        break;
                    case 8:
                        LocalizarPrimeiraOcorrencia();
                        break;
                    case 9:
                        CopiarLista();
                        break;
                    default:
                        Console.WriteLine("Opção digitada não existe, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }
        public static void Adicionar()
        {
            Item inserirLista = new Item();
            System.Console.WriteLine("Insira o Item na lista");
            inserirLista.Conteudo = Console.ReadLine();

            listaItem.Add(inserirLista);
            System.Console.WriteLine("Aperte qualquer tecla para continuar:");
            Console.ReadKey();
            Console.Clear();
        }
        public static void AdicionarInicio()
        {
            Item inserirInicio = new Item();
            System.Console.WriteLine("Insira o Item na lista");
            inserirInicio.Conteudo = Console.ReadLine();

            listaItem.Insert(0, inserirInicio);
            System.Console.WriteLine("Aperte qualquer tecla para continuar:");
            Console.ReadKey();
            Console.Clear();
        }
        public static void AdicionarIesimo()
        {
            Item inserirIesimo = new Item();
            Console.WriteLine("Selecione a posição que deseja inserir um item");
            byte pos = Byte.TryParse(Console.ReadLine(), out byte auxpos) ? auxpos : default;
            Console.WriteLine("Insira o item na lista");
            inserirIesimo.Conteudo = Console.ReadLine();

            listaItem.Insert(pos, inserirIesimo);
            System.Console.WriteLine("Aperte qualquer tecla para continuar:");
            Console.ReadKey();
            Console.Clear();
        }

        public static void InfoLista()
        {
            if (listaItem.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----------------EXIBINDO------------------");
                Console.ForegroundColor = ConsoleColor.White;

                foreach (var Item in listaItem)
                {
                    Console.WriteLine(Item.Exibir());
                }
                Console.WriteLine("Quantidade de itens na lista: {0}", listaItem.Count());
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Aperte em qualquer tecla para continuar");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Não há itens, aperte em qualquer tecla para continuar");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void RemoverPrimeiroItem()
        {
            listaItem.RemoveAt(0);
            System.Console.WriteLine("Removido, aperte qualquer tecla para continuar:");
            Console.ReadKey();
            Console.Clear();
        }
        public static void RemoverIesimoItem()
        {
            Console.WriteLine("Informe a posiçao que deseja remover:");
            byte pos = Byte.TryParse(Console.ReadLine(), out byte auxpos) ? auxpos : default;
            listaItem.RemoveAt(pos);
            System.Console.WriteLine($"Item na posição {pos} removido, aperte qualquer tecla para continuar:");
            Console.ReadKey();
            Console.Clear();
        }
        public static void RetirarPrimeiraOcorrencia()
        {
            Item Ocorrencia = new Item();
            Console.WriteLine("Digite o item que deseja remover:");
            Ocorrencia.Conteudo = Console.ReadLine();
            int pos = listaItem.FindIndex(item => item.Conteudo == Ocorrencia.Conteudo);
            listaItem.RemoveAt(pos);
            System.Console.WriteLine("Primeira ocorrência removida, aperte qualquer tecla para continuar:");
            Console.ReadKey();
            Console.Clear();
        }
        public static void LocalizarPrimeiraOcorrencia()
        {
            Item Ocorrencia = new Item();
            Console.WriteLine("Digite o item que deseja localizar:");
            Ocorrencia.Conteudo = Console.ReadLine();
            int pos = listaItem.FindIndex(item => item.Conteudo == Ocorrencia.Conteudo);
            if (pos != -1)
            {
                Console.WriteLine($"Item {Ocorrencia.Conteudo} encontrado na posição {pos}");
            }
            else
            {
                Console.WriteLine("Item não encontrado na lista.");
            }
            Console.WriteLine("Aperte qualquer tecla para continuar:");
            Console.ReadKey();
            Console.Clear();
        }
        public static void CopiarLista()
        {
            List<Item> CopiaLista = new List<Item>();
            CopiaLista.AddRange(listaItem);
            foreach (var item in CopiaLista)
            {
                Console.WriteLine(item.Exibir());
            }
            Console.WriteLine("Aperte qualquer tecla para continuar:");
            Console.ReadKey();
            Console.Clear();
        }

    }

}