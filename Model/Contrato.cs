namespace PsicoHelpApi.Model
{
    public class Contrato
    {
        public int Id { get; set; }

        public DateTime DataCriacao { get; set; }

        public int UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }
    }
}
