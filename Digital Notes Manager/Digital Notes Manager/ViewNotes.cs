using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Digital_Notes_Manager.moduels;
using Microsoft.EntityFrameworkCore;

namespace Digital_Notes_Manager
{
    public partial class ViewNotes : Form
    {
        ManageNoteContext ManageNoteContext;
        Main_Form Main_Form;
        public ViewNotes(ManageNoteContext ManageNoteContext, Main_Form main_Form)
        {
            InitializeComponent();
            this.ManageNoteContext = ManageNoteContext;
            this.Main_Form = main_Form;
            gridView1.Columns["CreationDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView1.Columns["CreationDate"].DisplayFormat.FormatString = "dd/MM/yyyy";
            gridView1.Columns["ReminderDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView1.Columns["ReminderDate"].DisplayFormat.FormatString = "dd/MM/yyyy";

            var combo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();

            // نضيف القيم اللي انت عايزها تظهر (القيم الحقيقية من الـ Enum)
            foreach (Category cat in Enum.GetValues(typeof(Category)))
            {
                combo.Items.Add(cat);
            }

            combo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            gridView1.Columns["Category"].ColumnEdit = combo;
            combo.EditValueChanged += (s, e) =>
            {
                gridView1.PostEditor();           // يحفظ القيمة جوه الخلية
                gridView1.CloseEditor();          // يقفل الـ editor
                gridView1.UpdateCurrentRow();     // يعمل commit للتغيير علطول
            };


        }

        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var editedNote = gridView1.GetFocusedRow() as Note_Form;
            if (editedNote != null)
            {
                ManageNoteContext.Update(editedNote);
                ManageNoteContext.SaveChanges();
            }
            var note = gridView1.GetRow(e.RowHandle) as Note_Form;
            ManageNoteContext.SaveChanges();
        }

        private void gridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {
            ManageNoteContext.SaveChanges();
        }

        private void deleteAllSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من حذف العناصر المحددة؟", "تأكيد", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            // خزن الـ IDs أو الكيانات اللي متعلم عليها
            var selectedRows = gridView1.GetSelectedRows();

            if (selectedRows.Length == 0)
            {
                XtraMessageBox.Show("Please Select A Note To Delete");
                return;
            }

            using (var context = new ManageNoteContext())
            {
                foreach (var rowHandle in selectedRows)
                {
                    var row = gridView1.GetRow(rowHandle) as Note_Form;

                    if (row != null)
                    {
                        context.Entry(row).State = EntityState.Deleted;
                    }
                }
                context.SaveChanges();
            }


            XtraMessageBox.Show("Deleted Successfully");
            Main_Form.SetDataSource();
        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.Menu != null)
            {
                contextMenuStrip1.Show(Notes_Grid, e.Point);
            }

        }
    }
}

