using SOLID_L_EXEMPLO_UM_ERRADO.Classes;
using System;
using System.Collections.Generic;

namespace SOLID_L_EXEMPLO_UM_ERRADO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<FuncionarioBase> funcionariosDaEmpresa = new List<FuncionarioBase>();

            Console.WriteLine("Digite o nome do gerente");
            var nomeDoGerente = Console.ReadLine();

            Console.WriteLine("Digite o salário do gerente");
            var salarioDoGerente = decimal.Parse(Console.ReadLine());

            Gerente gerente = new Gerente(salarioDoGerente, nomeDoGerente);

            Console.WriteLine("Digite o nome do administrativo");
            var nomeDoAdministrativo = Console.ReadLine();

            Console.WriteLine("Digite o salário do administrativo");
            var salarioDoAdministrativo = decimal.Parse(Console.ReadLine());

            Administrativo administrativo = new Administrativo(salarioDoAdministrativo , nomeDoAdministrativo);

            funcionariosDaEmpresa.Add(gerente);
            funcionariosDaEmpresa.Add(administrativo);

            foreach (var funcionario in funcionariosDaEmpresa)
            {
                funcionario.MostraInformacao();

                var pagamentoAReceber = funcionario.RecebePagamento();
                Console.WriteLine($"Pagamento recebido {pagamentoAReceber}");
            }

            Console.ReadLine();
        }
    }
}
