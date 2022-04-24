using System;

namespace SOLID_L_EXEMPLO_DOIS_CERTO.Classes
{
    public class GerenciadorDeContas
    {

        public double Saldo { get; private set; }

        public void Depositar(double valor)
        {
            Saldo += valor;
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

        public void Render(double taxa)
        {
            Saldo = Saldo + (Saldo * taxa);
        }
    }
}
