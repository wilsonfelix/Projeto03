using System;
using System.Collections.Generic;
using System.Text;
using Projeto03.Entities;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace Projeto03.Repositories
{
    public class FuncionarioRepository
    {
        //atributo (dado / campo)
        private readonly string connectionString;

        //metodo contrutor (ctor + 2x[Tab])

        public FuncionarioRepository()
        {
            //inicializar o atributo connectionstring
            connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projeto03;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        //metodo para inserir um funcionario na base de dados
        public void Inserir(Funcionario funcionario)
        {
            //escreve uma query sql...
            var query = "insert into Funcionário(Nome, Cpf, DataAdmissao, TipoContratacao)" +
                "Values(@Nome, @Cpf, @DataAdmissao, @TipoContratacao)";
            //conectar-se ao banco de dados...
            using (var connection = new SqlConnection(connectionString))
            {
                //insere registro
                connection.Execute(query, funcionario);
                
            }
        }
        public void Atualizar(Funcionario funcionario)
        {
            //escreve uma query sql...
            var query = "update Funcionario set Nome = @Nome, Cpf = @Cpf, DataAdmissao = @DataAdmissao, " +
                "TipoContratacao = @TipoContratacao where Id = @Id";
            //conectar-se ao banco de dados...
            using (var connection = new SqlConnection(connectionString))
            {
                //atualiza registro
                connection.Execute(query, funcionario);

            }
        }

        public void Excluir(Funcionario funcionario)
        {
            //escreve uma query sql...
            var query = "delete from Funcionario where Id = @Id";
            //conectar-se ao banco de dados...
            using (var connection = new SqlConnection(connectionString))
            {
                //exclui registro
                connection.Execute(query, funcionario);

            }
        }

        public List<Funcionario> ConsultarTodos()
        {
            //escreve uma query sql...
            var query = "select * from Funcionário";
            //conectar-se ao banco de dados...
            using (var connection = new SqlConnection(connectionString))
            {
                //consulta TODOS registros
                return connection.Query<Funcionario>(query).ToList();

            }
        }

        public Funcionario ObterPorId(int Id)
        {
            //escreve uma query sql...
            var query = "select * from Funcionário where Id = @Id";
            //conectar-se ao banco de dados...
            using (var connection = new SqlConnection(connectionString))
            {
                //consulta registros pelo Id
                return connection.Query<Funcionario>(query, new { Id }).FirstOrDefault();

            }
        }
    }
}
