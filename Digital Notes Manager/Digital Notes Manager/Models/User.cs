namespace Digital_Notes_Manager.moduels
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public virtual List<Note> Notes { get; set; }

    }
}
