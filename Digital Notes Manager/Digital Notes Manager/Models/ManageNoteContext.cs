using Microsoft.EntityFrameworkCore;

namespace Digital_Notes_Manager.Models
{
    public class ManageNoteContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=JOE\\MSSQLSERVER01;Database=DB_Digital_Notes_Manager;Trusted_Connection=True;TrustServerCertificate=True;")
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
                new Note { ID = 1, Title = "Hello", Content = "Welcome to my first note", CreationDate = DateTime.Now, Category = Category.Personal, ReminderDate = new DateTime(2025, 6, 1), UserID = 1 },
                new Note { ID = 2, Title = "Meeting Notes", Content = "Discuss project timeline and deliverables.", CreationDate = DateTime.Now.AddDays(-2), Category = Category.Work, ReminderDate = new DateTime(2025, 6, 3), UserID = 1 },
                new Note { ID = 3, Title = "Shopping List", Content = "Milk, Bread, Eggs, Coffee", CreationDate = DateTime.Now.AddDays(-1), Category = Category.Personal, ReminderDate = new DateTime(2025, 6, 2), UserID = 1 },
                new Note { ID = 4, Title = "Ideas", Content = "Build a note-taking app with tagging feature.", CreationDate = DateTime.Now.AddDays(-5), Category = Category.Personal, ReminderDate = new DateTime(2025, 6, 1), UserID = 1 },
                new Note { ID = 5, Title = "Workout Plan", Content = "Push/Pull/Legs split for next 4 weeks.", CreationDate = DateTime.Now.AddDays(-7), Category = Category.Work, ReminderDate = new DateTime(2025, 6, 5), UserID = 1 },
                new Note { ID = 6, Title = "Reading List", Content = "Clean Code, The Pragmatic Programmer", CreationDate = DateTime.Now.AddDays(-3), Category = Category.Study, ReminderDate = new DateTime(2025, 6, 10), UserID = 1 },
                new Note { ID = 7, Title = "Doctor Appointment", Content = "Dentist at 4 PM", CreationDate = DateTime.Now.AddDays(-2), Category = Category.Reminders, ReminderDate = new DateTime(2025, 6, 7), UserID = 1 },
                new Note { ID = 8, Title = "Birthday Gift Ideas", Content = "Watch, Wallet, Book", CreationDate = DateTime.Now.AddDays(-4), Category = Category.Personal, ReminderDate = new DateTime(2025, 6, 12), UserID = 1 },
                new Note { ID = 9, Title = "Work Feedback", Content = "Review last week's sprint", CreationDate = DateTime.Now.AddDays(-6), Category = Category.Work, ReminderDate = new DateTime(2025, 6, 9), UserID = 1 },
                new Note { ID = 10, Title = "Project Deadlines", Content = "Phase 1 - June 15", CreationDate = DateTime.Now.AddDays(-8), Category = Category.Work, ReminderDate = new DateTime(2025, 6, 15), UserID = 1 },
                new Note { ID = 11, Title = "Daily Journal", Content = "Today I learned about enums.", CreationDate = DateTime.Now, Category = Category.Personal, ReminderDate = new DateTime(2025, 6, 6), UserID = 1 },
                new Note { ID = 12, Title = "Recipe Ideas", Content = "Pasta, Chicken curry", CreationDate = DateTime.Now.AddDays(-1), Category = Category.Personal, ReminderDate = new DateTime(2025, 6, 14), UserID = 1 },
                new Note { ID = 13, Title = "Study Topics", Content = "Entity Framework, LINQ", CreationDate = DateTime.Now.AddDays(-3), Category = Category.Study, ReminderDate = new DateTime(2025, 6, 13), UserID = 1 },
                new Note { ID = 14, Title = "Weekend Plans", Content = "Visit grandparents", CreationDate = DateTime.Now.AddDays(-5), Category = Category.Personal, ReminderDate = new DateTime(2025, 6, 8), UserID = 1 },
                new Note { ID = 15, Title = "UI Mockups", Content = "Sketch homepage and login screen", CreationDate = DateTime.Now.AddDays(-4), Category = Category.Work, ReminderDate = new DateTime(2025, 6, 11), UserID = 1 },
                new Note { ID = 16, Title = "To-do List", Content = "Refactor code, clean desk", CreationDate = DateTime.Now.AddDays(-2), Category = Category.Reminders, ReminderDate = new DateTime(2025, 6, 9), UserID = 1 },
                new Note { ID = 17, Title = "Budget Plan", Content = "Allocate savings, expenses", CreationDate = DateTime.Now.AddDays(-6), Category = Category.Personal, ReminderDate = new DateTime(2025, 6, 17), UserID = 1 },
                new Note { ID = 18, Title = "App Improvements", Content = "Add dark mode support", CreationDate = DateTime.Now.AddDays(-7), Category = Category.Work, ReminderDate = new DateTime(2025, 6, 16), UserID = 1 },
                new Note { ID = 19, Title = "Exam Schedule", Content = "Maths - 18th, Physics - 20th", CreationDate = DateTime.Now.AddDays(-1), Category = Category.Study, ReminderDate = new DateTime(2025, 6, 18), UserID = 1 },
                new Note { ID = 20, Title = "Phone Backup", Content = "Backup contacts and photos", CreationDate = DateTime.Now, Category = Category.Reminders, ReminderDate = new DateTime(2025, 6, 19), UserID = 1 }
            );

        }
    }
}
