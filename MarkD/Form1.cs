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
        private int totalNotes;

        public MarkD()
        {
            InitializeComponent();
            totalNotes = 1;
        }

        private void newNoteBtn_Click(object sender, EventArgs e)
        {
            if (totalNotes <= 5)
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
                    Multiline = true,
                    Visible = false,
                    BackColor = Color.FromArgb(250, 254, 224),
                    ScrollBars = ScrollBars.Vertical,
                    Width = 308,
                    Height = 421
                };

                notesPanel.Controls.Add(newNoteText);
                newNoteText.Location = new Point(0, 0);
                noteTexts.Add(newNoteText);

                newNoteBtn.Click += (s, args) =>
                {
                    SwitchToNote(newNoteText);
                };

                newNoteText.TextChanged += (s, args) =>
                {
                    renderMarkdown(newNoteText.Text);
                };

                btnPanel.Controls.Add(newNoteBtn);
                newNoteBtn.Location = new Point(38, 34 + (totalNotes * 34));

                totalNotes++;

                if (totalNotes == 2)
                {
                    newNoteText.Visible = true;
                }
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
                MessageBox.Show("File saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void renderMarkdown(string selectedText)
        {
            var html = Markdown.ToHtml(selectedText);
            renderedMD.DocumentText = html;
        }

        private void saveAllBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Markdown|*.md",
                Title = "Save All Notes"
            };
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                using (FileStream fs = (FileStream)saveFileDialog1.OpenFile())
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (var noteTextBox in noteTexts)
                    {
                        sw.WriteLine(noteTextBox.Text);
                        sw.WriteLine();
                    }
                }

                MessageBox.Show("All notes saved!", "Save All", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}