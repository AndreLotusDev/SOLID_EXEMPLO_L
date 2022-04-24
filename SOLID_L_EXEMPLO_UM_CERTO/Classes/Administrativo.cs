namespace SOLID_L_EXEMPLO_UM_ERRADO.Classes
{
    public class Administrativo : FuncionarioBase
    {
        public Administrativo(decimal salario, string nome) : base(salario, nome, "Administrativo") { }

        public override decimal RecebePagamento()
        {
            return 0;
        }
    }
}
