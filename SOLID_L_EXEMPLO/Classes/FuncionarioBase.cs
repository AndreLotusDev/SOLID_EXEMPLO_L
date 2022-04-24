namespace SOLID_L_EXEMPLO_UM_CERTO.Classes
{
    public class FuncionarioBase
    {
        protected decimal Salario { get; set; }
        protected string Nome { get; set; }
        protected string Cargo { get; set; }
        public FuncionarioBase(decimal salario, string nome, string cargo)
        {
            Salario = salario;
            Nome = nome;
            Cargo = cargo;
        }
    }
}
