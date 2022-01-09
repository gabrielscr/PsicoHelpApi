namespace PsicoHelpApi.Model
{
    public class Video
    {
        public int Id { get; set; }

        public DateTime DataCriacao { get; set; }

        public string? Link { get; set; }

        public string? UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }
    }
}
