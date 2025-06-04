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

        private List<Note> LoadTasksFromDatabase()
        {
            using var context = new ManageNoteContext();
            return context.Notes.AsNoTracking().ToList();
        }

        private void AddTasksToScheduler(List<Note> notes)
        {
            var storage = schedulerControl1.DataStorage;

            storage.Appointments.Clear();
            Dictionary<int, Appointment> appointmentsMap = new();

            foreach (var note in notes)
            {
                Appointment apt = storage.CreateAppointment(AppointmentType.Normal);
                apt.Subject = note.Title;
                apt.Start = note.StartDate;
                apt.End = note.EndDate;
                apt.CustomFields["Progress"] = note.IsCompleted ? 100 : 0;
                apt.CustomFields["ID"] = note.ID;

                appointmentsMap[note.ID] = apt;
                storage.Appointments.Add(apt);
            }

        }
    }
}
