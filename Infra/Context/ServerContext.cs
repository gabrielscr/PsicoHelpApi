using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PsicoHelpApi.Model;

namespace PsicoHelpApi.Infra.Context
{
    public class ServerContext : IdentityDbContext<Usuario>
    {
        public ServerContext(DbContextOptions<ServerContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Anotacao>();

            //mb.Entity<Contrato>();

            mb.Entity<Dica>(opts =>
            {
                opts.HasMany(p => p.Anexos);
            });

            mb.Entity<Dieta>();

            mb.Entity<Exercicio>(opts =>
            {
                opts.HasMany(p => p.Anexos);
            });

            //mb.Entity<HorarioAtendimento>();

            mb.Entity<Humor>();

            //mb.Entity<Lembrete>();

            mb.Entity<Orientacao>(opts =>
            {
                opts.HasMany(p => p.Anexos);
            });

            mb.Entity<Post>(opts =>
            {
                opts.HasMany(p => p.Anexos);

                opts.HasMany(p => p.Curtidas);

                opts.HasMany(p => p.Comentarios);
            });

            mb.Entity<PostComentario>();

            mb.Entity<PostCurtida>(opts =>
            {
                opts.HasIndex(p => new { p.Id, p.UsuarioId });
            });

            mb.Entity<Usuario>();

            mb.Entity<Video>();

            base.OnModelCreating(mb);
        }
    }
}
