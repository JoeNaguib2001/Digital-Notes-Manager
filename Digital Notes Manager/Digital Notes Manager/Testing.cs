using Digital_Notes_Manager.moduels;

namespace Digital_Notes_Manager
{
    public partial class Testing : Form
    {
        ManageNoteContext mnc;
        public Testing(ManageNoteContext mnc)
        {
            InitializeComponent();
            this.mnc = mnc;
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            mnc.SaveChanges();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            mnc.SaveChanges();

        }
    }
}
