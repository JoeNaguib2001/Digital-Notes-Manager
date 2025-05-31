using DevExpress.XtraGrid;
using Digital_Notes_Manager.Models;
using System.ComponentModel;

namespace Digital_Notes_Manager
{
    internal static class Utilities
    {
        public static GridControl GridControl { get; set; }
        public static ManageNoteContext manageNoteContext { get; } = new ManageNoteContext();
        public static LoginRegisterMDI LoginRegisterMDI { get; set; }
        public static void SetNotesGridControlDataSource()
        {
            var list = manageNoteContext.Notes.Where(x => x.UserID == Properties.Settings.Default.userID).ToList();

            BindingList<Note> BLN = new BindingList<Note>(list);
            GridControl.DataSource = BLN;
        }


        public static bool RememberMe()
        {
            return Properties.Settings.Default.rememberMe;
        }
    }
}


