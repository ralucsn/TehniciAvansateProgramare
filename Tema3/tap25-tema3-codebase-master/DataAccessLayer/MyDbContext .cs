using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    //Install: Microsoft.EntityFrameworkCore.SqlServer, Microsoft.EntityFrameworkCore.Design
    // dotnet ef migrations add Initial
    // dotnet ef database update
    public class MyDbContext : DbContext
    {
        private readonly string _windowsConnectionString = @"Server=.\SQLExpress;Database=Lab5Database1;Trusted_Connection=True;TrustServerCertificate=true";
        //private readonly string _windowsConnectionString = @"Server=localhost\SQLEXPRESS;Database=Lab5Database1;Trusted_Connection=True;TrustServerCertificate=True;";

        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_windowsConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
                .HasOne(f => f.Type)
                .WithMany(c => c.Users)
                .HasForeignKey(f => f.TypeId);

            // One-to-One
            builder.Entity<Person>()
                .HasOne(p => p.Card)
                .WithOne(p => p.Person)
                .HasForeignKey<IdCard>(p => p.PersonId);

            // One-to-Many
            builder.Entity<Pers>()
                .HasMany(p2 => p2.Titles)
                .WithOne(j => j.Pers)
                .HasForeignKey(j => j.Person2Id);

            // Many-to-Many
            builder.Entity<Angajat>()
            .HasMany(a => a.Responsabilities)
            .WithMany(r => r.Angajati)
            .UsingEntity(d => d.ToTable("AngajatToResponsabilities"));
                
            Seed(builder);
        }

        protected void Seed(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Angajat>()
                .HasData(
                    new Angajat("1111-222-33-4", "A"),
                    new Angajat("2222-333-44-5", "B")
                    );
        }
    }
}
