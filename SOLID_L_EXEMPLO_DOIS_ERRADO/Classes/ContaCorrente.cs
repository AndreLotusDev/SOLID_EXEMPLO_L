using System;

namespace SOLID_L_EXEMPLO_DOIS_ERRADO.Classes
{
    public class ContaCorrente
    {
        private const double DOIS_POR_CENTO = 0.02;
        protected double Saldo { get; set; }

        public ContaCorrente()
        {
            Saldo  = 0;
        }

        public void Depositar(double valor)
        {
            Saldo  += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                throw new Exception("Saldo insuficiente.");
            }
        }

        public void MostraInformacoesConta()
        {
            Console.WriteLine($"Saldo atual: {Saldo}");
        }

        public virtual void Render()
        {
            Saldo = Saldo + (Saldo * DOIS_POR_CENTO);
        }
    }
}
