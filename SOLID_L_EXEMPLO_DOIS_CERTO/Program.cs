using SOLID_L_EXEMPLO_DOIS_CERTO.Classes;
using SOLID_L_EXEMPLO_DOIS_CERTO.Interface;
using System;
using System.Collections.Generic;

namespace SOLID_L_EXEMPLO_DOIS_CERTO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IConta> contas = new List<IConta>();

            const double CEM_REAIS = 100;

            var contaCorrente = new ContaCorrenteComum();
            contaCorrente.Depositar(CEM_REAIS);

            var contaSalario = new ContaSalario();
            contaSalario.Depositar(CEM_REAIS);

            contas.Add(contaCorrente);
            contas.Add(contaSalario);

            //Passou um mes
            foreach (var conta in contas)
            {

                if (conta is ContaCorrenteComum)
                {
                    (conta as ContaCorrenteComum).Render();
                }

                conta.MostraInformacoes();

            }

            Console.ReadLine();
        }
    }
}
