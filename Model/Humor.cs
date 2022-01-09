namespace PsicoHelpApi.Model
{
    public class Humor
    {
        public int Id { get; set; }

        public DateTime DataCriacao { get; set; }

        public string? Descricao { get; set; }

        public int UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }
    }
}
