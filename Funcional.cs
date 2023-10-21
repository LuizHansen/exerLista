using System;
using System.Collections.Generic;

namespace exerLista
{
    class Funcional : Item
    {
        public static List<Item> listaItem = new List<Item>();

        public static void Adicionar()
        {
            Item inserirLista = new Item();
            Console.WriteLine("Insira o Item na lista");
            inserirLista.Conteudo = Console.ReadLine();

            listaItem.Add(inserirLista);
            Console.WriteLine("Aperte qualquer tecla para continuar:");
            Console.ReadKey();
            Console.Clear();
        }
        public static void AdicionarInicio()
        {
            Item inserirInicio = new Item();
            Console.WriteLine("Insira o Item na lista");
            inserirInicio.Conteudo = Console.ReadLine();

            listaItem.Insert(0, inserirInicio);
            Console.WriteLine("Aperte qualquer tecla para continuar:");
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
            Console.WriteLine("Aperte qualquer tecla para continuar:");
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
            Console.WriteLine("Removido, aperte qualquer tecla para continuar:");
            Console.ReadKey();
            Console.Clear();
        }
        public static void RemoverIesimoItem()
        {
            Console.WriteLine("Informe a posiçao que deseja remover:");
            byte pos = Byte.TryParse(Console.ReadLine(), out byte auxpos) ? auxpos : default;
            listaItem.RemoveAt(pos);
            Console.WriteLine($"Item na posição {pos} removido, aperte qualquer tecla para continuar:");
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
            Console.WriteLine("Primeira ocorrência removida, aperte qualquer tecla para continuar:");
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