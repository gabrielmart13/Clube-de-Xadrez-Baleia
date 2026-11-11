
using Microsoft.EntityFrameworkCore;
using XadrezBaleia.Domain.Models;

namespace XadrezBaleia.Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<ClassEnrollments> ClassEnrollments { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<EventRegistros> EventRegistros { get; set; }
        public DbSet<Partidas> Partidas { get; set; }
        public DbSet<HistoricoRating> HistoricoRating { get; set; }
        public DbSet<EventImagens> EventImagens { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Nomes das tabelas
            modelBuilder.Entity<Usuarios>().ToTable("usuarios");
            modelBuilder.Entity<Classes>().ToTable("classes");
            modelBuilder.Entity<ClassEnrollments>().ToTable("class_enrollments");
            modelBuilder.Entity<Eventos>().ToTable("eventos");
            modelBuilder.Entity<EventRegistros>().ToTable("event_registros");
            modelBuilder.Entity<Partidas>().ToTable("partidas");
            modelBuilder.Entity<HistoricoRating>().ToTable("historico_rating");
            modelBuilder.Entity<EventImagens>().ToTable("event_imagens");


            // USUARIOS

            modelBuilder.Entity<Usuarios>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<Usuarios>()
                .HasIndex(u => u.Rating);


            // CLASSES

            modelBuilder.Entity<Classes>()
                .HasOne(c => c.Instrutor)
                .WithMany()
                .HasForeignKey(c => c.InstrutorId)
                .OnDelete(DeleteBehavior.Restrict);


            // CLASS ENROLLMENTS

            modelBuilder.Entity<ClassEnrollments>()
                .HasOne(c => c.Usuario)
                .WithMany()
                .HasForeignKey(c => c.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ClassEnrollments>()
                .HasOne(c => c.Classes)
                .WithMany()
                .HasForeignKey(c => c.ClassesId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ClassEnrollments>()
                .HasIndex(c => new { c.ClassesId, c.Status, c.DataSolicitacao });


            // EVENTOS

            modelBuilder.Entity<Eventos>()
                .HasOne(e => e.CriadoPor)
                .WithMany()
                .HasForeignKey(e => e.CriadoPorId)
                .OnDelete(DeleteBehavior.Restrict);


            // EVENT REGISTROS

            modelBuilder.Entity<EventRegistros>()
                .HasOne(e => e.Usuario)
                .WithMany()
                .HasForeignKey(e => e.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EventRegistros>()
                .HasOne(e => e.Evento)
                .WithMany()
                .HasForeignKey(e => e.EventoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EventRegistros>()
                .HasIndex(e => new { e.EventoId, e.UsuarioId });


            // PARTIDAS

            modelBuilder.Entity<Partidas>()
                .HasOne(p => p.JogadorBrancas)
                .WithMany()
                .HasForeignKey(p => p.JogadorBrancasId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Partidas>()
                .HasOne(p => p.JogadorPretas)
                .WithMany()
                .HasForeignKey(p => p.JogadorPretasId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Partidas>()
                .HasOne(p => p.RegistradoPor)
                .WithMany()
                .HasForeignKey(p => p.RegistradoPorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Partidas>()
                .HasOne(p => p.Evento)
                .WithMany()
                .HasForeignKey(p => p.EventoId)
                .OnDelete(DeleteBehavior.Restrict);


            // HISTORICO RATING

            modelBuilder.Entity<HistoricoRating>()
                .HasOne(h => h.Usuario)
                .WithMany()
                .HasForeignKey(h => h.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HistoricoRating>()
                .HasOne(h => h.Partida)
                .WithMany()
                .HasForeignKey(h => h.PartidaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HistoricoRating>()
                .HasIndex(h => new { h.UsuarioId, h.DataRegistro });


            // EVENT IMAGENS

            modelBuilder.Entity<EventImagens>()
                .HasOne(i => i.Evento)
                .WithMany()
                .HasForeignKey(i => i.EventoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EventImagens>()
                .HasOne(i => i.EnviadoPor)
                .WithMany()
                .HasForeignKey(i => i.EnviadoPorId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
