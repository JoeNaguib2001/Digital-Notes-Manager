using DevExpress.XtraGrid.Views.Base;
using Digital_Notes_Manager.moduels;
using Microsoft.EntityFrameworkCore;

namespace Digital_Notes_Manager
{
    public partial class ViewNotes : Form
    {
        ManageNoteContext ManageNoteContext;
        public ViewNotes(ManageNoteContext ManageNoteContext)
        {
            InitializeComponent();
            this.ManageNoteContext = ManageNoteContext;
        }

        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            //var editedNote = gridView1.GetFocusedRow() as Notes;
            //if (editedNote != null)
            //{
            //    ManageNoteContext.Update(editedNote);
            //    ManageNoteContext.SaveChanges();
            //}
            var note = gridView1.GetRow(e.RowHandle) as Notes;
            MessageBox.Show(ManageNoteContext.Entry(note).State.ToString());

            var changed = ManageNoteContext.ChangeTracker.Entries().Where(e => e.State == EntityState.Modified).ToList();
            MessageBox.Show("Modified count: " + changed.Count);

            ManageNoteContext.SaveChanges();
        }

        private void gridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {
            ManageNoteContext.SaveChanges();
        }
    }
}

