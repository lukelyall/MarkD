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

        private Dictionary<string, string> notes;

        public MarkD()
        {
            InitializeComponent();
            notes = new Dictionary<string, string>();
            InitializeTabControl();
        }

        private void InitializeTabControl()
        {
            CreateNewNoteTab("New Note");
        }

        private void CreateNewNoteTab(string title)
        {
            TabPage newTab = new TabPage(title);
            TextBox noteTextBox = new TextBox
            {
                Multiline = true,
                Dock = DockStyle.Fill,
                ScrollBars = ScrollBars.Vertical
            };
            noteTextBox.TextChanged += Note_TextChanged;
            newTab.Controls.Add(noteTextBox);
            tabControl1.TabPages.Add(newTab);
            notes.Add(title, string.Empty);
        }

        private void Note_TextChanged(object sender, EventArgs e)
        {
            var noteTextBox = sender as TextBox;
            if (noteTextBox != null)
            {
                string unrenderedMD = noteTextBox.Text;
                string html = Markdown.ToHtml(unrenderedMD);

                string tabTitle = tabControl1.SelectedTab.Text;
                notes[tabTitle] = unrenderedMD;
                renderedMD.DocumentText = html;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var note in notes)
                    {
                        string filePath = Path.Combine(folderDialog.SelectedPath, note.Key + ".md");
                        File.WriteAllText(filePath, note.Value);
                    }
                    MessageBox.Show($"All notes saved in {folderDialog.SelectedPath}!", "Save Complete", MessageBoxButtons.OK);
                }
            }
        }

        private void newNoteBtn_Click(object sender, EventArgs e)
        {
            string noteTitle = "New Note " + (tabControl1.TabCount + 1);
            CreateNewNoteTab(noteTitle);
        }
    }
}