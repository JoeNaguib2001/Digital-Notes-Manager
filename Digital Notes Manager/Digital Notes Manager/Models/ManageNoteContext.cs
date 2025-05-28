using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager.moduels
{
    public class ManageNoteContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Notes> Notes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LAPTOP-CMR1M1SF\\SQLDEV;Database=DB_Digital_Notes_Manager;Trusted_Connection=True;TrustServerCertificate=True;")
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTrackingWithIdentityResolution);

            //====================== Logged ==============================
            optionsBuilder.LogTo(log => Debug.WriteLine(log), Microsoft.Extensions.Logging.LogLevel.Information);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //====================== Fluent API ==============================
            modelBuilder.Entity<User>().HasAlternateKey(s => s.Username);
            modelBuilder.Entity<User>().Property(s => s.Username).IsRequired();

            modelBuilder.Entity<Notes>()
                .HasOne(n => n.User)
                .WithMany(u => u.Notes)
                .HasForeignKey(n => n.UserID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Notes>().HasIndex(t => t.Title).IsClustered(false);



            //====================== Seeding Data ==============================
            modelBuilder.Entity<User>().HasData(new User
            {
                UserID = 1,
                Username = "Samuel",
                Password = "123"
            });

            modelBuilder.Entity<Notes>().HasData(new Notes
            {
                ID = 1,
                Title = "Hello",
                Content = "Welcome to my first note",
                CreationDate = DateTime.Now,
                Category = Category.Personal,
                ReminderDate = new DateTime(2025, 6, 1),
                UserID = 1

            });

        }
    }
}
