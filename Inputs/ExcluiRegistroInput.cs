using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto03.Inputs
{
    public class ExcluiRegistroInput
    {
        public static string LerExcluiRegistro()
        {
            Console.WriteLine("\nO registro para esse funcionário será deletado permanentemente!!!");
            Console.WriteLine("\nDeseja continuar? ");
            return Console.ReadLine();
        }
    }
}
