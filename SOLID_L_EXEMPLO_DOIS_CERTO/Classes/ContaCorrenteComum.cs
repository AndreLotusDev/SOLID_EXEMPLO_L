using SOLID_L_EXEMPLO_DOIS_CERTO.Interface;
using System;

namespace SOLID_L_EXEMPLO_DOIS_CERTO.Classes
{
    public class ContaCorrenteComum : IConta
    {

        private GerenciadorDeContas gerenciador;

        public ContaCorrenteComum()
        {
            gerenciador = new GerenciadorDeContas();
        }

        public void Depositar(double valor)
        {
            gerenciador.Depositar(valor);
        }

        public void Sacar(double valor)
        {
            gerenciador.Sacar(valor);
        }

        public double PegaSaldo()
        {
            return gerenciador.Saldo;
        }

        public void Render()
        {
            gerenciador.Render(0.02);
        }

        public void MostraInformacoes()
        {
            Console.WriteLine($"Saldo atual: {PegaSaldo()}");
        }
    }
}
