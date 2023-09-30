using EnglishDictTester.Data.Common;
using EnglishDictTester.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EnglishDictTester.Data
{
    public class EnglishDictTesterContext : DbContext
    {
        public EnglishDictTesterContext()
        {
                
        }
        public DbSet<WordBg>? WordBgs { get; set; }
        public DbSet<WordEn>? WordEns { get; set; }
        public DbSet<WordsEnBg>? WordsEnBgs { get; set; }
        public DbSet<Tests>? Tests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Sett default connection string
                // Someone used empty constructor of our DbContext
                optionsBuilder.UseSqlServer(DbConfig.ConnectionString);

            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<WordsEnBg>()
                .HasKey(wEnBg => new { wEnBg.WordEnId, wEnBg.WordBgId });

            modelBuilder.Entity<WordsEnBg>()
                    .HasOne<WordEn>(wEn => wEn.WordEn)
                    .WithMany(wEnBg => wEnBg.WordsEnBgs);

            modelBuilder.Entity<WordsEnBg>()
                    .HasOne<WordBg>(wEn => wEn.WordBg)
                    .WithMany(wEnBg => wEnBg.WordsEnBgs);

            modelBuilder.Entity<Tests>()
                .HasKey(t => new { t.testId });

        }
    }
}