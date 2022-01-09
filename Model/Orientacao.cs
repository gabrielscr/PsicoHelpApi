namespace PsicoHelpApi.Model
{
    public class Orientacao
    {
        public int Id { get; set; }

        public DateTime DataCriacao { get; set; }

        public string? Descricao { get; set; }

        public List<OrientacaoAnexo>? Anexos { get; set; }

        public string? UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }
    }
}
