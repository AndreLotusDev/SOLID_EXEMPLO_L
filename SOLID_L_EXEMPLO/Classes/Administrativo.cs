using SOLID_L_EXEMPLO_UM_CERTO.Interfaces;
using System;

namespace SOLID_L_EXEMPLO_UM_CERTO.Classes
{
    class Administrativo : FuncionarioBase, IMostraInformacao
    {
        public Administrativo(decimal salario, string nome) : base(salario, nome, "Administrativo") { }

        public void MostraInformacao()
        {
            Console.WriteLine($"Tipo de cargo: {Cargo}");
            Console.WriteLine($"Salário: {Salario}");
        }
    }
}
