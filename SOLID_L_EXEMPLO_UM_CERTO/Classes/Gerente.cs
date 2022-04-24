namespace SOLID_L_EXEMPLO_UM_ERRADO.Classes
{
    public class Gerente : FuncionarioBase
    {
        public Gerente(decimal salario, string nome) : base(salario, nome, "Gerente") { }
        public override decimal RecebePagamento()
        {
            return Salario;
        }
    }
}
