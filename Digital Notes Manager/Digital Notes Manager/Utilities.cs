using DevExpress.XtraGrid;
using Digital_Notes_Manager.Models;
using System.ComponentModel;
using Test;

namespace Digital_Notes_Manager
{
    public static class Utilities
    {
        //Main Form Reference
        public static Main_Form MainForm { get; set; }
        //Reference To The GridControl In The ViewNotes Form
        public static GridControl GridControl { get; set; }
        public static ManageNoteContext manageNoteContext { get; } = new ManageNoteContext();
        public static LoginRegisterMDI LoginRegisterMDI { get; set; }
        //Reference To The ViewNotesDashboard Form
        public static ViewNotesDashboard ViewNotesDashboard { get; set; }
        //Notes That Are Opened Are Added In This List To Deny Opening Them Again
        public static List<Note> OpenedNotes { get; set; } = new List<Note>();
        //List oF Updated Notes From Database
        public static List<Note> notes { get; set; } = new List<Note>();
        //List Of Edites Notes
        public static List<Note> updatedNotes { get; set; } = new List<Note>();

        public static List<string> notifications = new List<string>();

        public static TableLayoutPanel TableLayoutPanel { get; set; }


        public static void SetNotesGridControlDataSource()
        {
            var list = manageNoteContext.Notes.Where(x => x.UserID == Properties.Settings.Default.userID).ToList();
            BindingList<Note> BLN = new BindingList<Note>(list);
            GridControl.DataSource = BLN;
            notes = list;
        }
        public static void RefreshNotesGrid()
        {
            //GridControl.DataSource = notes;
            GridControl.RefreshDataSource();
        }

        //public static void UpdateRemainingTime()
        //{
        //    dateTimeOffsets = manageNoteContext.Notes
        //                   .Select(x => x.ReminderDate)
        //                   .ToList();
        //}

        public static bool RememberMe()
        {
            return Properties.Settings.Default.rememberMe;
        }

        public static int GetCurrentLoggedInUserId()
        {
            return Properties.Settings.Default.userID;
        }
    }
}


