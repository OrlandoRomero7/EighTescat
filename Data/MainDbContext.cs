using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TescatGlobalServer.Data.Models;
using System;

namespace TescatGlobalServer.Data
{
    public class MainDbContext(DbContextOptions<MainDbContext> options):
        IdentityDbContext<ApplicationUser>(options)
    {
        //public MainDbContext(DbContextOptions<MainDbContext> options)
        // : base(options)
        //{

        //}
        public DbSet<User> Users => Set<User>();

        public DbSet<UserCredentials> User_Credentials => Set<UserCredentials>();

        public DbSet<UserEmails> Emails => Set<UserEmails>();

        public DbSet<UserPC> PC => Set<UserPC>();


        public DbSet<ComputerCredentials> PC_Credentials => Set<ComputerCredentials>();

        public DbSet<Storage> Storage => Set<Storage>();

        public DbSet<MemoryRam> Memory_RAM => Set<MemoryRam>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            //No hay necesidad de usar .toTable("nombre_tabla") por que se le da el mismo nombre a la instancia de DBset que el de la BD.

            modelBuilder.Entity<User>()
                .HasKey(a => a.ID_USER);

            modelBuilder.Entity<UserCredentials>()
                .HasKey(b => b.ID_CREDENTIALS);


            modelBuilder.Entity<UserEmails>()
               .HasKey(c => c.USER_EMAILS_ID);


            modelBuilder.Entity<UserPC>()
                .HasKey(d => d.ID_PC);


            modelBuilder.Entity<ComputerCredentials>()
                .HasKey(d => d.ID_PC);

            modelBuilder.Entity<Storage>()
                .HasKey(d => d.ID_STORAGE);

            modelBuilder.Entity<MemoryRam>(entity =>
            {
                entity.HasKey(e => e.ID_RAM);
                entity.HasOne(d => d.IdPcNavigation).WithMany(p => p.Memory_RAM)
                    .HasForeignKey(d => d.ID_PC)
                    .HasConstraintName("FK_Memory_RAM_PC");
            });
                
        }

    }
}
