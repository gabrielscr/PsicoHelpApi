namespace PsicoHelpApi.Model
{
    public class Exercicio
    {
        public int Id { get; set; }

        public DateTime DataCriacao { get; set; }

        public string? Descricao { get; set; }

        public string? Titulo { get; set; }

        public string? Tipo { get; set; }

        public List<string>? Anexos { get; set; }

        public int UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }
    }
}
