namespace PsicoHelpApi.Model
{
    public class PostComentario
    {
        public int Id { get; set; }

        public DateTime DataCriacao { get; set; }

        public string? Descricao { get; set; }

        public string? UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }
    }
}
