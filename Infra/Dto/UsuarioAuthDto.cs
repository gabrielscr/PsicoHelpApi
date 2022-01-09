using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicoHelpApi.Infra.Dto
{
    public class UsuarioAuthDto
    {
        public string? Email { get; set; }

        public string? Senha { get; set; }
    }
}
