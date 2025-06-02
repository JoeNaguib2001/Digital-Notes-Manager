using Digital_Notes_Manager.Models;
using System.Data;

namespace Digital_Notes_Manager
{
    public partial class ReportsForm : DevExpress.XtraEditors.XtraForm
    {
        private List<Note> _notes;

        public ReportsForm(List<Note> notes)
        {
            InitializeComponent();
            _notes = notes;
            LoadCategoryReport();
            LoadReminderReport();
        }

        private void LoadCategoryReport()
        {
            chartControlCategory.Series.Clear(); // تنظيف قديم

            var categoryData = _notes
                .GroupBy(n => n.Category)
                .Select(g => new { Category = g.Key, Count = g.Count() })
                .ToList();

            var series = new DevExpress.XtraCharts.Series("Notes by Category", DevExpress.XtraCharts.ViewType.Pie);

            foreach (var item in categoryData)
                series.Points.Add(new DevExpress.XtraCharts.SeriesPoint(item.Category, item.Count));

            // إظهار النسب
            series.Label.TextPattern = "{A}: {VP:P0}";

            // إظهار الليجند
            chartControlCategory.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

            chartControlCategory.Series.Add(series);
        }

        private void LoadReminderReport()
        {
            chartControlReminder.Series.Clear(); // تنظيف قديم

            DateTime now = DateTime.Now;
            DateTime twoDaysFromNow = now.AddDays(2);

            int dueSoon = _notes.Count(n => n.ReminderDate >= now && n.ReminderDate <= twoDaysFromNow);
            int overdue = _notes.Count(n => n.ReminderDate < now);
            int upcoming = _notes.Count(n => n.ReminderDate > twoDaysFromNow);

            var series = new DevExpress.XtraCharts.Series("Reminders", DevExpress.XtraCharts.ViewType.Doughnut);

            series.Points.Add(new DevExpress.XtraCharts.SeriesPoint("Overdue", overdue));
            series.Points.Add(new DevExpress.XtraCharts.SeriesPoint("Due Soon", dueSoon));
            series.Points.Add(new DevExpress.XtraCharts.SeriesPoint("Upcoming", upcoming));

            // إظهار النسب
            series.Label.TextPattern = "{A}: {VP:P0}";

            // إظهار الليجند
            chartControlReminder.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

            // ألوان مخصصة (اختياري)
            if (series.Points.Count >= 3)
            {
                series.Points[0].Color = Color.Red;      // Overdue
                series.Points[1].Color = Color.Orange;   // Due Soon
                series.Points[2].Color = Color.Green;    // Upcoming
            }

            chartControlReminder.Series.Add(series);
        }

    }

}
