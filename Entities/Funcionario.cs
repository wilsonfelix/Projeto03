using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto03.Entities
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataAdminssao { get; set; }
        public TipoContratacao TipoContratacao { get; set; }
    }
}
