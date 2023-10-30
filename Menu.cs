using exerLista;
using System.Collections.Generic;

namespace exerLista
{

    partial class Menu : Funcional
    {
        public Menu()
        {
            menu();
        }
        public void menu()
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

                opcao = byte.TryParse(Console.ReadLine(), out byte auxopcao)? auxopcao : default;
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
                    case 0:
                        break;    
                    default:
                        Console.WriteLine("Opção digitada não existe, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }
    }
}