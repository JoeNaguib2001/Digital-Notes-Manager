namespace Digital_Notes_Manager.moduels
{
    [Flags]
    public enum Category { Study = 1, Work = 2, Ideas = 4, Reminders = 8, Personal = 16 };
    public class Note
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Category Category { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ReminderDate { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
