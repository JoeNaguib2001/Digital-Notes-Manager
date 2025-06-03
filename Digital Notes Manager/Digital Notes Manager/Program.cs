using Digital_Notes_Manager.Models;

namespace Digital_Notes_Manager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            List<Note> notes = new List<Note>
            {
                new Note()
                {
                    ID = 20,
                    Title = "a",
                    UserID = 1,
                    Category = Category.Ideas,
                    Content = "as",
                     ReminderDate =new DateTime(2025,3,1),

                },
                new Note()
                {
                    ID = 21,
                    Title = "a",
                    UserID = 1,
                    Category = Category.Reminders,
                    Content = "as",
                    ReminderDate =new DateTime(2025,4,1),

                },
                new Note()
                {
                    ID = 22,
                    Title = "a",
                    UserID = 1,
                    Category = Category.Study,
                    Content = "as",
                    StartDate = DateTime.Now,
                    ReminderDate =new DateTime(2025,7,1),

                },
                new Note()
                {
                    ID = 23,
                    Title = "a",
                    UserID = 1,
                    Category = Category.Work,
                    Content = "as",
                     ReminderDate =new DateTime(2025,6,4),

                }
            };


            Application.Run(new ReportsForm(notes));
        }
    }
}