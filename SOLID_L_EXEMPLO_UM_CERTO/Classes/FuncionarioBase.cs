using System;

namespace SOLID_L_EXEMPLO_UM_ERRADO.Classes
{
    public abstract class FuncionarioBase
    {
        public decimal Salario { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public FuncionarioBase(decimal salario, string nome, string cargo)
        {
            Salario = salario;
            Nome = nome;
            Cargo = cargo;
        }
        /// <summary>
        /// Todos os funcionarios recebem o salário por esse metódo
        /// </summary>
        /// <returns></returns>
        public abstract decimal RecebePagamento();

        public void MostraInformacao()
        {
            Console.WriteLine($"Nome do funcionário: {Nome}");
            Console.WriteLine($"Cargo do funcionário: {Cargo}");
            Console.WriteLine("===================================");
        }
    }
}
