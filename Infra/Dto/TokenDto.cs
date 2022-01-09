namespace PsicoHelpApi.Infra.Dto
{
    public class TokenDto
    {
        public bool? Autenticado { get; set; }

        public string? CriadoEm { get; set; }

        public string? ExpiraEm { get; set; }

        public string? Token { get; set; }

        public string? Mensagem { get; set; }
    }
}
