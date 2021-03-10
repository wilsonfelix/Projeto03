using Projeto03.Entities;
using Projeto03.Inputs;
using Projeto03.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto03.Controllers
{
    public class FuncionarioController
    {
        private readonly FuncionarioRepository funcionarioRepository;

        public FuncionarioController()
        {
            funcionarioRepository = new FuncionarioRepository();
        }

        public void CadastrarFuncionario()
        {
            try
            {


                Console.WriteLine("\n---  CADASTRO DE FUNCIONÁRIO   ---\n");
                var funcionario = new Funcionario();
                funcionario.Nome = FuncionarioInput.LerNome();
                funcionario.Cpf = FuncionarioInput.LerCpf();
                funcionario.DataAdminssao = FuncionarioInput.LerData();
                funcionario.TipoContratacao = (TipoContratacao)FuncionarioInput.LerTipoContratacao();

                funcionarioRepository.Inserir(funcionario);
                Console.WriteLine("\nFuncionário cadastrado com sucesso!!!");


            }
            catch (Exception e)
            {

                Console.WriteLine("\nErro: " + e.Message);
            }
        }


        public void AtualizarFuncionario()
        {
            try
            {
                Console.WriteLine("\n---  ATUALIZAR FUNCIONÁRIO   ---\n");
                var id = FuncionarioInput.LerId();
                var funcionario = funcionarioRepository.ObterPorId(id);
                if(funcionario != null)
                {
                    funcionario.Nome = FuncionarioInput.LerNome();
                    funcionario.Cpf = FuncionarioInput.LerCpf();
                    funcionario.DataAdminssao = FuncionarioInput.LerData();
                    funcionario.TipoContratacao = (TipoContratacao)FuncionarioInput.LerTipoContratacao();

                    funcionarioRepository.Atualizar(funcionario);
                    Console.WriteLine("\nFuncionário cadastrado com sucesso!");
                }
                else
                {
                    Console.WriteLine("\nFuncionário não encontrado na base.");
                }
                
                Console.WriteLine("\nFuncionário cadastrado com sucesso!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);

            }
        }


        public void ExcluirFuncionario()
        {
            try
            {
                Console.WriteLine("\n---  EXCLUI FUNCIONÁRIO   ---\n");
                var id = FuncionarioInput.LerId();
                var funcionario = funcionarioRepository.ObterPorId(id);
                var confirmaExclusaoRegistro = new ConfirmaExclusaoRegistro();
                if (funcionario != null)
                {
                    funcionario.Nome = FuncionarioInput.LerNome();
                    funcionario.Cpf = FuncionarioInput.LerCpf();
                    funcionario.DataAdminssao = FuncionarioInput.LerData();
                    funcionario.TipoContratacao = (TipoContratacao)FuncionarioInput.LerTipoContratacao();
                    confirmaExclusaoRegistro.SimNao = ExcluiRegistroInput.LerExcluiRegistro();
                    
                    
                }
                else
                {
                    Console.WriteLine("\nFuncionário não encontrado na base.");
                }

               
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);

            }
        }

        public void ConsultarFuncionarios()
        {
            try
            {
                Console.WriteLine("\n---  CONSULTAR FUNCIONÁRIO   ---\n");
                var lista = funcionarioRepository.ConsultarTodos();
                Console.WriteLine("Quantidade de funcionários cadastrados: " + lista.Count);
                //percorrer cada registro da List
                foreach (var item in lista)
                {
                    Console.WriteLine("Id...................: " + item.IdFuncionario);
                    Console.WriteLine("Nome.................: " + item.Nome);
                    Console.WriteLine("CPF..................: " + item.Cpf);
                    Console.WriteLine("Data de Admissão.....: " + item.DataAdminssao.ToString("dd/MM/yyyy"));
                    Console.WriteLine("Tipo de Contratação..: " + item.TipoContratacao);
                    Console.WriteLine("-----------");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);

            }
        }
    }
}
