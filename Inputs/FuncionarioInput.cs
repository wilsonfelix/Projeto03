using System;
using System.Collections.Generic;
using System.Text;
using Projeto03.Entities;

namespace Projeto03.Inputs
{
    public class FuncionarioInput
    {
        //metodo para ler o Id do funcionario
        public static int LerId()
        {
            Console.WriteLine("Id do Funcionário.................: ");
            return int.Parse(Console.ReadLine());
        }
        //metodo para ler o nome do funcionario
        public static string LerNome()
        {
            Console.WriteLine("Nome do Funcionário...............: ");
            return Console.ReadLine();
        }
        //metodo para ler o CPF do funcionario
        public static string LerCpf()
        {
            Console.WriteLine("CPF do Funcionário...............: ");
            return Console.ReadLine();
        }
        //metodo para ler a Data do funcionario
        public static DateTime LerData()
        {
            Console.WriteLine("Data de Admissão...............: ");
            return DateTime.Parse(Console.ReadLine());
        }

        public static int LerTipoContratacao()
        {
            Console.WriteLine("Tipo de contratação 1 CLT");
            Console.WriteLine("Tipo de contratação 2 Terceirizado");
            Console.WriteLine("Tipo de contratação 3 Estágio");

            Console.WriteLine("Tipo de contratação...............: ");
            return int.Parse(Console.ReadLine());
        }

       
    }
}
