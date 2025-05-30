using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Forms;
using Digital_Notes_Manager.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;

namespace Digital_Notes_Manager
{
    public partial class ViewNotes : Form
    {
        public ViewNotes()
        {
            InitializeComponent();
            gridView1.Columns["CreationDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView1.Columns["CreationDate"].DisplayFormat.FormatString = "dd/MM/yyyy";
            gridView1.Columns["ReminderDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView1.Columns["ReminderDate"].DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";

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
            combo.AppearanceDropDown.Font = new Font("Segoe UI", 12); // حجم 12 أو أي حجم يعجبك
            combo.AppearanceDropDown.Options.UseFont = true;
            gridView1.RowCellClick += gridView1_RowCellClick; // ربط الحدث
            gridView1.SortInfo.Clear();
            gridView1.SortInfo.AddRange(new[] {
            new GridColumnSortInfo(gridView1.Columns["CreationDate"], DevExpress.Data.ColumnSortOrder.Descending)
    });
            Utilities.GridControl = Notes_Grid;
            Utilities.SetNotesGridControlDataSource();
        }

        private ManageNoteContext ManageNoteContext = Utilities.manageNoteContext;
        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Column == DeleteColumn)
            {
                var selectedRow = gridView1.GetFocusedRow() as Note;
                if (selectedRow != null)
                {
                    if (MessageBox.Show("Are you sure you want to delete this note ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ManageNoteContext.Entry(selectedRow).State = EntityState.Deleted;
                        ManageNoteContext.SaveChanges();
                        XtraMessageBox.Show("Note Deleted Successfully");
                        Utilities.SetNotesGridControlDataSource();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Please Select A Note To Delete");
                }
            }
        }


        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var editedNote = gridView1.GetFocusedRow() as Note;
            if (editedNote != null)
            {
                ManageNoteContext.Update(editedNote);
                ManageNoteContext.SaveChanges();
            }
            var note = gridView1.GetRow(e.RowHandle) as Note;
            ManageNoteContext.SaveChanges();
        }

        private void gridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {
            ManageNoteContext.SaveChanges();
        }

        private void deleteAllSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the selected notes ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            Utilities.SetNotesGridControlDataSource();
        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.Menu != null)
            {
                contextMenuStrip1.Show(Notes_Grid, e.Point);
            }

        }

        List<Note_Form> note_Forms = new List<Note_Form>();
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note_Form noteForm = new Note_Form();
            var selectedRow = gridView1.GetFocusedRow() as Note;
            noteForm.richTextBox1.Text = selectedRow?.Content ?? string.Empty;
            noteForm.Show();
        }

        private void saveInYourDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note_Form noteForm = new Note_Form();
            var selectedRow = gridView1.GetFocusedRow() as Note;
            noteForm.richTextBox1.Text = selectedRow?.Content ?? string.Empty;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text File (*.rtf) | *.rtf";
            saveFileDialog.Title = "Save Note as RTF File in Your Device";
            saveFileDialog.FileName = $"{selectedRow.Title}.rtf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {


                    RichTextBox richTextBox = new RichTextBox();



                    richTextBox.SelectionAlignment = HorizontalAlignment.Center;
                    richTextBox.SelectionFont = new Font("Arial", 20, FontStyle.Bold | FontStyle.Underline);
                    richTextBox.SelectionColor = Color.DarkRed;
                    richTextBox.AppendText($"{selectedRow.Title}\n\n");


                    richTextBox.SelectionAlignment = HorizontalAlignment.Left;
                    richTextBox.SelectionFont = new Font("Arial", 12, FontStyle.Bold | FontStyle.Italic);
                    richTextBox.SelectionColor = Color.DarkGreen;
                    richTextBox.AppendText($"Category: {selectedRow.Category}");
                    richTextBox.AppendText($"                                ");
                    richTextBox.AppendText($"Created On: {selectedRow.CreationDate:dd/MM/yyyy}\n");


                    richTextBox.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
                    richTextBox.SelectionColor = Color.Gray;
                    richTextBox.AppendText("------------------------------------------------------------------------------------------------------------\n\n");

                    richTextBox.SelectionFont = new Font("Arial", 14, FontStyle.Regular);
                    richTextBox.SelectionColor = Color.Black;
                    richTextBox.AppendText(selectedRow.Content ?? "");


                    richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);

                    // Open the file automatically
                    System.Diagnostics.Process.Start("explorer.exe", saveFileDialog.FileName);

                    MessageBox.Show("Note saved and opened successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while saving the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
    }
}


