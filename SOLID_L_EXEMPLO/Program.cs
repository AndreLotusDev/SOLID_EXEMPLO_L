using SOLID_L_EXEMPLO_UM_CERTO.Classes;
using SOLID_L_EXEMPLO_UM_CERTO.Interfaces;
using System;
using System.Collections.Generic;

namespace SOLID_L_EXEMPLO
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

            Console.WriteLine("=====================================");

            Console.WriteLine("Digite o nome do administrativo");
            var nomeDoAdministrativo = Console.ReadLine();

            Console.WriteLine("Digite o salário do administrativo");
            var salarioDoAdministrativo = decimal.Parse(Console.ReadLine());

            Administrativo administrativo = new Administrativo(salarioDoAdministrativo, nomeDoAdministrativo);

            funcionariosDaEmpresa.Add(gerente);
            funcionariosDaEmpresa.Add(administrativo);

            foreach (var funcionario in funcionariosDaEmpresa)
            {
                Console.WriteLine("=====================================");
                if (funcionario is IRecebePagamento)
                {
                    var pagamentoAReceber = (funcionario as IRecebePagamento).RecebePagamento();
                    Console.WriteLine($"Pagamento recebido {pagamentoAReceber}");
                }
                else
                {
                    Console.WriteLine("Funcionário recebe o pagamento por fora!");
                }

                (funcionario as IMostraInformacao).MostraInformacao();
                Console.WriteLine("=====================================");
            }

            Console.ReadLine();
        }
    }
}
