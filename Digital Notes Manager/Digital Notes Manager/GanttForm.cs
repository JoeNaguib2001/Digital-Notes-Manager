using DevExpress.XtraScheduler;
using Digital_Notes_Manager.Models;
using Microsoft.EntityFrameworkCore;

namespace Digital_Notes_Manager
{
    public partial class GanttForm : Form
    {
        public GanttForm()
        {
            InitializeComponent();

            schedulerControl1.ActiveViewType = SchedulerViewType.Gantt;
            schedulerControl1.Start = DateTime.Today;

            ConfigureMappings();

            var tasks = LoadTasksFromDatabase();
            AddTasksToScheduler(tasks);
        }

        private void ConfigureMappings()
        {
            var mappings = schedulerControl1.DataStorage.Appointments.Mappings;
            mappings.Subject = "Title";
            mappings.Start = "StartDate";
            mappings.End = "EndDate";

            schedulerControl1.DataStorage.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("Progress", "Progress"));
            schedulerControl1.DataStorage.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("ID", "ID"));
            schedulerControl1.DataStorage.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("ParentID", "ParentID"));
        }

        private List<TaskModel> LoadTasksFromDatabase()
        {
            using var context = new ManageNoteContext();
            return context.Tasks.AsNoTracking().ToList();
        }

        private void AddTasksToScheduler(List<TaskModel> tasks)
        {
            var storage = schedulerControl1.DataStorage;

            storage.Appointments.Clear();
            Dictionary<int, Appointment> appointmentsMap = new();

            foreach (var task in tasks)
            {
                Appointment apt = storage.CreateAppointment(AppointmentType.Normal);
                apt.Subject = task.Title;
                apt.Start = task.StartDate;
                apt.End = task.EndDate;
                apt.CustomFields["Progress"] = task.Progress;
                apt.CustomFields["ID"] = task.ID;
                apt.CustomFields["ParentID"] = task.ParentID;

                appointmentsMap[task.ID] = apt;
                storage.Appointments.Add(apt);
            }

        }
    }
}
