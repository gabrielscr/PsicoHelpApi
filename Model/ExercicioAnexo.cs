namespace PsicoHelpApi.Model
{
    public class ExercicioAnexo
    {
        public int Id { get; set; }

        public string? Link { get; set; }

        public string? UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }
    }
}
