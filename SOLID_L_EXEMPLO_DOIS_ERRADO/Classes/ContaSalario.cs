using System;

namespace SOLID_L_EXEMPLO_DOIS_ERRADO.Classes
{
    public class ContaSalario : ContaCorrente
    {
        public override void Render()
        {
            throw new Exception("Essa conta não tem rendimentos");
        }
    }
}
