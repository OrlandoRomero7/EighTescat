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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasKey(a => a.ID_USER);

            modelBuilder.Entity<UserCredentials>()
                .HasKey(b => b.ID_CREDENTIALS);


            modelBuilder.Entity<UserEmails>()
               .HasKey(c => c.USER_EMAILS_ID);


            modelBuilder.Entity<UserPC>()
                .HasKey(d => d.ID_PC);

        }

    }
}
