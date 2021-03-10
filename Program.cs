using System;
using Projeto03.Controllers;

namespace Projeto03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\n----- CONTROLE DE FUNCIOÁRIOS -----\n");
                Console.WriteLine("(1) Cadastrar funcionário: ");
                Console.WriteLine("(2) Atualizar funcionário: ");
                Console.WriteLine("(3) Excluír funcionário: ");
                Console.WriteLine("(4) Consultar funcionário: ");

                Console.Write("\nEntre com uma opção....: ");
                var opcao = int.Parse(Console.ReadLine());
                var funcionarioController = new FuncionarioController();
                switch (opcao)
                {
                    case 1:
                        funcionarioController.CadastrarFuncionario();
                        break;
                    case 2:
                        funcionarioController.AtualizarFuncionario();
                        break;
                    case 3:
                        funcionarioController.ExcluirFuncionario();
                        break;
                    case 4:
                        funcionarioController.ConsultarFuncionarios();
                        break;
                    case 5:
                        Console.WriteLine("\nOpção inválida!!!");
                        break;
                }

                Console.WriteLine("\nDeseja continuar? (S ou N)...: ");
                var confirmacao = Console.ReadLine();

                if (confirmacao.Equals("S", StringComparison.OrdinalIgnoreCase())
                {
                    Console.Clear();
                    Main(args);
                }
                else
                {
                    Console.WriteLine("\nFIM do Programa");
                }
            }
            catch (Exception)
            {

                throw;
            }
            Console.ReadKey();
            
        }
    }
}
