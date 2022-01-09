namespace PsicoHelpApi.Model
{
    public class Post
    {
        public int Id { get; set; }

        public DateTime DataCriacao { get; set; }

        public string? Descricao { get; set; }

        public List<string>? Anexos { get; set; }

        public List<PostCurtida>? Curtidas { get; set; }

        public List<PostComentario>? Comentarios { get; set; }

        public int UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }
    }
}
