using SOLID_L_EXEMPLO_UM_CERTO.Interfaces;
using System;

namespace SOLID_L_EXEMPLO_UM_CERTO.Classes
{
    public class Gerente : FuncionarioBase, IRecebePagamento, IMostraInformacao
    {
        public Gerente(decimal salario, string nome) : base(salario, nome, "Gerente") {}

        public void MostraInformacao()
        {
            Console.WriteLine($"Tipo de cargo: {Cargo}");
            Console.WriteLine($"Salário: {Salario}");
        }

        public decimal RecebePagamento()
        {
            return Salario;
        }
    }
}
