namespace PsicoHelpApi.Model
{
    public class Dieta
    {
        public int Id { get; set; }

        public DateTime DataCriacao { get; set; }

        public string? Titulo { get; set; }

        public string? Descricao { get; set; }

        public int Calorias { get; set; }

        public int UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }
    }
}
