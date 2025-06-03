using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager.Models
{
    [NotMapped]
        public class TaskModel
        {
            public int ID { get; set; }
            public string Title { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public int Progress { get; set; } 
            public int? ParentID { get; set; } 



      
    }


}
