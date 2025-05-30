using DevExpress.XtraGrid;
using Digital_Notes_Manager.Models;
using System.ComponentModel;

namespace Digital_Notes_Manager
{
    internal static class Utilities
    {
        public static GridControl GridControl { get; set; }
        public static ManageNoteContext manageNoteContext { get; } = new ManageNoteContext();
        public static void SetNotesGridControlDataSource()
        {
            var list = manageNoteContext.Notes.Where(x => x.UserID == Properties.Settings.Default.UserID).ToList();

            BindingList<Note> BLN = new BindingList<Note>(list);
            GridControl.DataSource = BLN;
        }
    }
}


//private void LoadNotesForm()
//{
//    this.MDI_Panel.Controls.Clear();
//    viewNotes = new ViewNotes(manageNoteContext, this);
//    SetDataSource(viewNotes.Notes_Grid);
//    MDI_Panel.Controls.Add(viewNotes.panel1);
//}
//public void SetDataSource(GridControl GC)
//{
//    var list = manageNoteContext.Notes.ToList();
//    BindingList<Note> BLN = new BindingList<Note>(list);
//    GC.DataSource = BLN;
//}

