using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Markdig;

namespace MarkD
{
    public partial class MarkD : Form
    {
        private List<TextBox> noteTexts = new List<TextBox>();
        private List<Button> noteButtons = new List<Button>();
        private int totalNotes;

        public MarkD()
        {
            InitializeComponent();
            totalNotes = 1;

            notesPanel.Dock = DockStyle.Left;
            renderedMD.Dock = DockStyle.Fill;

            foreach (Control btn in btnPanel.Controls)
            {
                btn.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            }

            this.Resize += new EventHandler(MainForm_Resize);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            notesPanel.Width = this.Width / 3;
            renderedMD.Width = this.Width - notesPanel.Width;
        }


        private void newNoteBtn_Click(object sender, EventArgs e)
        {
            Button newNoteBtn = new Button
            {
                Text = "Note " + totalNotes,
                Name = "noteBtn" + totalNotes,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Width = 112,
                Height = 23
            };

            TextBox newNoteText = new TextBox
            {
                Font = new Font("Arial", 11),
                Multiline = true,
                Visible = false,
                BackColor = Color.FromArgb(250, 254, 224),
                ScrollBars = ScrollBars.Vertical,
                BorderStyle = BorderStyle.None,
                Dock = DockStyle.Fill
            };

            newNoteText.TextChanged += (s, args) => UpdateLineNumbers(newNoteText);

            notesPanel.Controls.Add(newNoteText);
            noteTexts.Add(newNoteText);

            newNoteBtn.MouseDown += (s, args) =>
            {
                if (args.Button == MouseButtons.Right)
                {
                    DeleteNoteDialog(newNoteBtn, newNoteText);
                }
            };

            newNoteBtn.Click += (s, args) =>
            {
                SwitchToNote(newNoteText);
                currFile.Text = "MarkD - " + newNoteBtn.Text; 
            };

            newNoteText.TextChanged += (s, args) =>
            {
                renderMarkdown(newNoteText.Text);
                UpdateLineNumbers(newNoteText);
            };

            btnPanel.Controls.Add(newNoteBtn);
            newNoteBtn.Location = new Point(38, 50 + (totalNotes * 34));
            noteButtons.Add(newNoteBtn);

            totalNotes++;

            SwitchToNote(newNoteText);
            currFile.Text = "MarkD - " + newNoteBtn.Text;
        }

        private void UpdateLineNumbers(TextBox textBox)
        {
            int lineCount = textBox.Lines.Length;
            StringBuilder lineNumbers = new StringBuilder();
            for (int i = 1; i <= lineCount; i++)
            {
                lineNumbers.AppendLine(i.ToString());
            }

            linesLabel.Text = lineNumbers.ToString();

            AdjustLineNumbersPosition(lineCount);
        }

        private void AdjustLineNumbersPosition(int lineCount)
        {
            int lineHeight = linesLabel.Font.Height;
            int requiredHeight = lineCount * lineHeight;

            int maxVisibleLines = notesPanel.Height / lineHeight;

            int shift = 0;

            if (lineCount > maxVisibleLines)
            {
                shift = (lineCount - maxVisibleLines + 1) * lineHeight;
            }
            linesLabel.Location = new Point(linesLabel.Location.X, -shift);
            linesLabel.Height = requiredHeight;
        }




        private void DeleteNoteDialog(Button noteButton, TextBox noteTextBox)
        {
            var result = MessageBox.Show("Do you want to delete this note?", "Delete Note", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                notesPanel.Controls.Remove(noteTextBox);
                btnPanel.Controls.Remove(noteButton);
                noteTexts.Remove(noteTextBox);
                noteButtons.Remove(noteButton);

                for (int i = 0; i < noteButtons.Count; i++)
                {
                    noteButtons[i].Location = new Point(38, 68 + (i * 34));
                    noteButtons[i].Text = "Note " + (i + 1);
                }
                totalNotes--;

                MessageBox.Show("Note deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SwitchToNote(TextBox selectedNote)
        {
            foreach (var noteTextBox in noteTexts)
            {
                noteTextBox.Visible = false;
                noteTextBox.Enabled = false;
            }

            selectedNote.Visible = true;
            selectedNote.Enabled = true;
            selectedNote.Focus();

            renderMarkdown(selectedNote.Text);
            UpdateLineNumbers(selectedNote);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Markdown|*.md";
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                StreamWriter sw = new StreamWriter(fs);

                var visibleNote = noteTexts.Find(n => n.Visible);
                if (visibleNote != null)
                {
                    sw.Write(visibleNote.Text);
                }

                sw.Close();
                fs.Close();
                MessageBox.Show("Note saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void renderMarkdown(string selectedText)
        {
            var html = Markdown.ToHtml(selectedText);
            renderedMD.DocumentText = html;
        }

        private void saveAllBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder to save all notes";
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;

                    foreach (var noteTextBox in noteTexts)
                    {
                        int noteIndex = noteTexts.IndexOf(noteTextBox) + 1;

                        string fileName = Path.Combine(selectedPath, $"note{noteIndex}.md");

                        using (FileStream fs = new FileStream(fileName, FileMode.Create))
                        using (StreamWriter sw = new StreamWriter(fs))
                        {
                            sw.WriteLine(noteTextBox.Text);
                        }
                    }

                    MessageBox.Show("All notes saved!", "Save All", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}