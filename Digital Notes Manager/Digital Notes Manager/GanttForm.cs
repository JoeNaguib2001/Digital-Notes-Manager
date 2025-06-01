using DevExpress.XtraScheduler;
using Digital_Notes_Manager.Models;

namespace Digital_Notes_Manager
{
    public partial class GanttForm : Form
    {
        GanttView ganttView1;

        public GanttForm()
        {
            InitializeComponent(); // لازم تستدعيها علشان تجهز الكنترولز
            //Properties.Settings.Default.
            //ganttView1 = schedulerControl1.Views.GanttView;
            //schedulerControl1.ActiveViewType = SchedulerViewType.Gantt;

            //schedulerControl1.Start = new DateTime(2025, 6, 1);
            //schedulerControl1.DayView.TimeScale = TimeSpan.FromHours(24);

            //AddTasksToScheduler(GetSampleTasks());

            //schedulerControl1.Refresh();
        }

        private void AddTasksToScheduler(List<TaskModel> tasks)
        {
            var storage = schedulerControl1.DataStorage;

            // مسح أي بيانات قديمة (اختياري)
            storage.Appointments.Clear();

            Dictionary<int, Appointment> appointmentsMap = new Dictionary<int, Appointment>();

            foreach (var task in tasks)
            {
                Appointment apt = storage.CreateAppointment(AppointmentType.Normal);
                apt.Subject = task.Title;
                apt.Start = task.StartDate;
                apt.End = task.EndDate;
                apt.CustomFields["Progress"] = task.Progress;  // لو عايز تخزن القيمة
                apt.CustomFields["ID"] = task.ID;
                apt.CustomFields["ParentID"] = task.ParentID;

                appointmentsMap[task.ID] = apt;
                storage.Appointments.Add(apt);
            }

            // ضبط العلاقات (Parent-Child)
            foreach (var task in tasks)
            {
                if (task.ParentID.HasValue && appointmentsMap.ContainsKey(task.ParentID.Value))
                {
                    var parentApt = appointmentsMap[task.ParentID.Value];
                    var childApt = appointmentsMap[task.ID];
                }
            }
        }

        private List<TaskModel> GetSampleTasks()
        {
            return new List<TaskModel>
            {
                new TaskModel { ID = 1, Title = "مشروع الأكاديمية", StartDate = new DateTime(2025, 6, 1), EndDate = new DateTime(2025, 6, 15), Progress = 50, ParentID = null },
                new TaskModel { ID = 2, Title = "تحليل النظام", StartDate = new DateTime(2025, 6, 1), EndDate = new DateTime(2025, 6, 3), Progress = 100, ParentID = 1 },
                new TaskModel { ID = 3, Title = "تصميم قاعدة البيانات", StartDate = new DateTime(2025, 6, 4), EndDate = new DateTime(2025, 6, 6), Progress = 80, ParentID = 1 },
                new TaskModel { ID = 4, Title = "تطوير الواجهة", StartDate = new DateTime(2025, 6, 7), EndDate = new DateTime(2025, 6, 10), Progress = 40, ParentID = 1 },
                new TaskModel { ID = 5, Title = "الاختبار والتسليم", StartDate = new DateTime(2025, 6, 11), EndDate = new DateTime(2025, 6, 15), Progress = 0, ParentID = 1 }
            };
        }

        private void schedulerControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
