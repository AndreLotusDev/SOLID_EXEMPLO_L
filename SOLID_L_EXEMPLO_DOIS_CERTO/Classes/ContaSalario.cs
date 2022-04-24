using SOLID_L_EXEMPLO_DOIS_CERTO.Interface;
using System;

namespace SOLID_L_EXEMPLO_DOIS_CERTO.Classes
{
    public class ContaSalario : IConta
    {

        private GerenciadorDeContas gerenciador;

        public ContaSalario()
        {
            this.gerenciador = new GerenciadorDeContas();
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

        public void MostraInformacoes()
        {
            Console.WriteLine($"Saldo atual: {PegaSaldo()}");
        }
    }
}
