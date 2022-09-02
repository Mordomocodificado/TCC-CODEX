using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TCC_CODEX.Model
{
    public partial class TCC_CODEXContext : DbContext
    {
        public TCC_CODEXContext()
        {
        }

        public TCC_CODEXContext(DbContextOptions<TCC_CODEXContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Post> Posts { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=SNCCHLAB02F20\\TEW_SQLEXPRESS;Initial Catalog=TCC_CODEX;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Conteudo).IsUnicode(false);

                entity.Property(e => e.Momento).HasColumnType("datetime");

                entity.Property(e => e.Publicante)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
