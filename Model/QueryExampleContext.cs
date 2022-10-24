using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ControllerExample.Model
{
    public partial class QueryExampleContext : DbContext
    {
        public QueryExampleContext()
        {
        }

        public QueryExampleContext(DbContextOptions<QueryExampleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Score> Scores { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=SNCCHLAB02F03\\TEW_SQLEXPRESS;Initial Catalog=QueryExample;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Score>(entity =>
            {
                entity.ToTable("Score");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Player1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Player2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ScorePlayer1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ScorePlayer2)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
