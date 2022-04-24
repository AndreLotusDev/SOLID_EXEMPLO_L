using SOLID_L_EXEMPLO_DOIS_ERRADO.Classes;
using System;
using System.Collections.Generic;

namespace SOLID_L_EXEMPLO_DOIS_ERRADO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ContaCorrente> contas = new List<ContaCorrente>();

            const double CEM_REAIS = 100;

            var contaCorrente = new ContaCorrente();
            contaCorrente.Depositar(CEM_REAIS);

            var contaSalario = new ContaSalario();
            contaSalario.Depositar(CEM_REAIS);

            contas.Add(contaCorrente);
            contas.Add(contaSalario);

            //Passou um mes
            foreach (var conta in contas)
            {

                conta.Render();

                conta.MostraInformacoesConta();

            }

            Console.ReadLine();
        }
    }
}
