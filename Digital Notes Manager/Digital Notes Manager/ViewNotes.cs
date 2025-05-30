﻿using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Digital_Notes_Manager.Models;
using Microsoft.EntityFrameworkCore;

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

            var combo = new RepositoryItemComboBox();
            foreach (Category cat in Enum.GetValues(typeof(Category)))
            {
                combo.Items.Add(cat);
            }

            combo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            gridView1.Columns["Category"].ColumnEdit = combo;
            combo.EditValueChanged += (s, e) =>
            {
                gridView1.PostEditor();
                gridView1.CloseEditor();
                gridView1.UpdateCurrentRow();
            };
            combo.AppearanceDropDown.Font = new Font("Segoe UI", 12);
            combo.AppearanceDropDown.Options.UseFont = true;
            gridView1.RowCellClick += gridView1_RowCellClick;
            gridView1.SortInfo.Clear();
            gridView1.SortInfo.AddRange(new[] {
            new GridColumnSortInfo(gridView1.Columns["CreationDate"], DevExpress.Data.ColumnSortOrder.Descending)
    });
            Utilities.GridControl = Notes_Grid;
            Utilities.SetNotesGridControlDataSource();



            detailView.OptionsBehavior.Editable = false;

            gridView1.MasterRowGetRelationCount += (s, e) =>
            {
                e.RelationCount = 1;
            };

            gridView1.MasterRowGetRelationName += (s, e) =>
            {
                e.RelationName = "NoteDetails";
            };

            gridView1.MasterRowGetChildList += (s, e) =>
            {
                var masterRow = gridView1.GetRow(e.RowHandle) as Note;
                if (masterRow != null)
                {
                    e.ChildList = new List<object>
                {
                    new { Content = ConvertRtfToPlainText(masterRow.Content)}
                };
                }
            };

            gridView1.MasterRowGetRelationDisplayCaption += (s, e) =>
            {
                e.RelationName = "NoteDetails";
            };

            Notes_Grid.LevelTree.Nodes.Add("NoteDetails", detailView);

        }

        private string ConvertRtfToPlainText(string rtf)
        {
            if (string.IsNullOrWhiteSpace(rtf))
                return string.Empty;

            using (RichTextBox rtb = new RichTextBox())
            {
                try
                {
                    rtb.Rtf = rtf;
                    return rtb.Text;
                }
                catch
                {
                    return "[Invalid RTF]";
                }
            }
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
            if (MessageBox.Show("Are you sure you want to delete the selected notes ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

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
                    var row = gridView1.GetRow(rowHandle) as Note;

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
            RichTextBox rt = new RichTextBox();
            rt.Rtf = selectedRow.Content;
            noteForm.richTextBox1.Rtf = rt.Rtf;
            noteForm._Title = selectedRow.Title;
            noteForm.Mode = Mode.Edit;
            noteForm.noteId = selectedRow.ID;
            noteForm.Categorybox.Text = selectedRow.Category.ToString();
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

                    richTextBox.SelectionColor = Color.Black;
                    RichTextBox textBox = new RichTextBox();
                    textBox.Rtf = selectedRow.Content;


                    //richTextBox.SelectionFont = textBox.Font;
                    richTextBox.Rtf = textBox.Rtf;


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

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "TimeDiff" && e.IsGetData)
            {
                var row = e.Row as Note;
                if (row != null)
                {
                    var diff = row.ReminderDate - DateTime.Now;

                    if (diff.TotalSeconds <= 0)
                    {
                        e.Value = "";
                    }
                    else
                    {
                        int hours = (int)diff.TotalHours;
                        int minutes = diff.Minutes;
                        int seconds = diff.Seconds;

                        e.Value = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
                    }
                }
            }
        }

        private void liveTimer_Tick(object sender, EventArgs e)
        {
            Utilities.RefreshNotesGrid();
        }



        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (e.RowHandle >= 0)
            {
                var row = view.GetRow(e.RowHandle) as Note;
                if (row != null)
                {
                    var diff = row.ReminderDate - DateTime.Now;
                    double totalHours = diff.TotalHours;

                    if (totalHours < 0)
                    {
                        e.Appearance.BackColor = Color.LightGray;
                        e.Appearance.ForeColor = Color.Black;
                    }
                    else if (totalHours > 5 && totalHours <= 25)
                    {
                        e.Appearance.BackColor = Color.Yellow;
                        e.Appearance.ForeColor = Color.Black;
                    }
                    else if (totalHours > 25 && totalHours <= 50)
                    {
                        // لون تاني لو حابب (مثلاً برتقالي فاتح)
                        e.Appearance.BackColor = Color.Orange;
                        e.Appearance.ForeColor = Color.Black;
                    }
                    else if (totalHours >= 50)
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.ForeColor = Color.White;
                    }

                    else
                    {
                        // لون طبيعي عادي
                        e.Appearance.BackColor = Color.Green;
                        e.Appearance.ForeColor = Color.White;
                    }
                }
            }
        }
    }
}



