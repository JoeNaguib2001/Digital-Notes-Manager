using Microsoft.EntityFrameworkCore;

namespace Digital_Notes_Manager.moduels
{
    public class ManageNoteContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=DB_Digital_Notes_Manager;Trusted_Connection=True;TrustServerCertificate=True;")
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTrackingWithIdentityResolution);

            //====================== Logged ==============================
            //optionsBuilder.LogTo(log => Debug.WriteLine(log), Microsoft.Extensions.Logging.LogLevel.Information);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //====================== Fluent API ==============================
            modelBuilder.Entity<User>().HasAlternateKey(s => s.Username);
            modelBuilder.Entity<User>().Property(s => s.Username).IsRequired();

            modelBuilder.Entity<Note>()
                .HasOne(n => n.User)
                .WithMany(u => u.Notes)
                .HasForeignKey(n => n.UserID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Note>().HasIndex(t => t.Title).IsClustered(false);



            //====================== Seeding Data ==============================
            modelBuilder.Entity<User>().HasData(new User
            {
                UserID = 1,
                Username = "Samuel",
                Password = "123"
            });

            modelBuilder.Entity<Note>().HasData(
                new Note
                {
                    ID = 1,
                    Title = "Hello",
                    Content = "Welcome to my first note",
                    CreationDate = DateTime.Now,
                    Category = Category.Personal,
                    ReminderDate = new DateTime(2025, 6, 1),
                    UserID = 1
                },
                new Note
                {
                    ID = 2,
                    Title = "Meeting Notes",
                    Content = "Discuss project timeline and deliverables.",
                    CreationDate = DateTime.Now.AddDays(-2),
                    Category = Category.Work,
                    ReminderDate = new DateTime(2025, 6, 3),
                    UserID = 1
                },
                new Note
                {
                    ID = 3,
                    Title = "Shopping List",
                    Content = "Milk, Bread, Eggs, Coffee",
                    CreationDate = DateTime.Now.AddDays(-1),
                    Category = Category.Personal,
                    ReminderDate = new DateTime(2025, 6, 2),
                    UserID = 1
                },
                new Note
                {
                    ID = 4,
                    Title = "Ideas",
                    Content = "Build a note-taking app with tagging feature.",
                    CreationDate = DateTime.Now.AddDays(-5),
                    Category = Category.Personal,
                    ReminderDate = new DateTime(2025, 6, 1),
                    UserID = 1
                },
                new Note
                {
                    ID = 5,
                    Title = "Workout Plan",
                    Content = "Push/Pull/Legs split for next 4 weeks.",
                    CreationDate = DateTime.Now.AddDays(-7),
                    Category = Category.Work,
                    ReminderDate = new DateTime(2025, 6, 5),
                    UserID = 1
                }
            );

        }
    }
}
