namespace Digital_Notes_Manager.Models
{
    public class TaskModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Progress { get; set; } // من 0 لـ 100
        public int? ParentID { get; set; } // Null لو مهمة رئيسية



    }


}
