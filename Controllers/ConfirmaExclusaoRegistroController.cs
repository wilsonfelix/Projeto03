using Projeto03.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Projeto03.Inputs;
using Projeto03.Entities;

namespace Projeto03.Controllers
{
    public class ConfirmaExclusaoRegistroController
    {


        public void ConfirmaExclusao()
        {
            try {
                    var funcionario = new Funcionario();
                    var funcionarioRepository = new FuncionarioRepository();
                    var sim = ExcluiRegistroInput.LerExcluiRegistro();

                    if (sim.Equals("S", StringComparison.OrdinalIgnoreCase))
                        {
                            funcionarioRepository.Excluir(funcionario);
                            Console.WriteLine("\nFuncionário excuido com sucesso!");
                        }

                }
            catch (Exception e)
                {
                    Console.WriteLine("\nErro: " + e.Message);

                }
        
        }
    }
}
