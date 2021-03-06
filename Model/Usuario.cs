using Microsoft.AspNetCore.Identity;

namespace PsicoHelpApi.Model
{
    public class Usuario : IdentityUser
    {
        public string? Nome { get; set; }

        public int? Sexo { get; set; }

        public int? Idade { get; set; }

        public int? TipoCadastro { get; set; }

        public string? Foto { get; set; }
    }
}
