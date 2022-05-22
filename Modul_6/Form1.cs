using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul_6
{
    public partial class Form1 : Form
    {
        public string path { get; set; } = "";
        public Form1()
        {
            InitializeComponent();

            this.FormClosing += ClosedForm;

            richTextBox.TextChanged += Count;

            NewToolStrip.Click += NewFile;
            NewToolStripMenuItem.Click += NewFile;

            OpenToolStrip.Click += OpenFile;
            OpenToolStripMenuItem.Click += OpenFile;

            SaveToolStrip.Click += SaveFile;
            SaveToolStripMenuItem.Click += SaveFile;
            SaveAsToolStripMenuItem.Click += SaveAsFile;

            CopyToolStrip.Click += CopyFile;
            CopyToolStripMenuItem.Click += CopyFile;

            CutToolStrip.Click += CutFile;
            CutToolStripMenuItem.Click += CutFile;

            InsertToolStrip.Click += InsertFile;
            InsertToolStripMenuItem.Click += InsertFile;

            CanselToolStrip.Click += CancelFile;
            CanselToolStripMenuItem.Click += CancelFile;

            SelectToolStripMenuItem.Click += SelectAllFile;

            ColorFontTtoolStrip.Click += ColorFontFile;
            ColorFontToolStripMenuItem.Click += ColorFontFile;

            ColorBackToolStrip.Click += ColorBackFile;
            ColocBackToolStripMenuItem.Click += ColorBackFile;

            FontToolStrip.Click += FontFile;
            FontToolStripMenuItem.Click += FontFile;
        }
        private void Count(object sender,EventArgs e)
        {
            label2.Text = richTextBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length.ToString();
         
        }
        private void ClosedForm(object sender, FormClosingEventArgs e)
        {
            if (richTextBox.CanUndo == true && path != "")
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result== DialogResult.Yes)
                {
                    File.WriteAllText(path, richTextBox.Text);
                }
            }
        }
        private void NewFile(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            save.FilterIndex = 2;
            if (save.ShowDialog() == DialogResult.OK)
            {
                richTextBox.ReadOnly = false;
                contextMenuStrip1.Enabled = true;

                SaveToolStrip.Enabled = true;
                CopyToolStrip.Enabled = true;
                CutToolStrip.Enabled = true;
                InsertToolStrip.Enabled = true;
                CanselToolStrip.Enabled = true;
                SaveToolStripMenuItem.Enabled = true;
                SaveAsToolStripMenuItem.Enabled = true;
                SelectToolStripMenuItem.Enabled = true;
                CopyToolStripMenuItem.Enabled = true;
                CutToolStripMenuItem.Enabled = true;
                InsertToolStripMenuItem.Enabled = true;
                CanselToolStripMenuItem.Enabled = true;

                path = save.FileName;
                Text = $"Текстовый редактор - {path}";
                File.WriteAllText(path, richTextBox.Text);
            }
        }
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            ofd.FilterIndex = 2;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox.ReadOnly = false;
                contextMenuStrip1.Enabled = true;

                SaveToolStrip.Enabled = true;
                CopyToolStrip.Enabled = true;
                CutToolStrip.Enabled = true;
                InsertToolStrip.Enabled = true;
                CanselToolStrip.Enabled = true;
                SaveToolStripMenuItem.Enabled = true;
                SaveAsToolStripMenuItem.Enabled = true;
                SelectToolStripMenuItem.Enabled = true;
                CopyToolStripMenuItem.Enabled = true;
                CutToolStripMenuItem.Enabled = true;
                InsertToolStripMenuItem.Enabled = true;
                CanselToolStripMenuItem.Enabled = true;

                path = ofd.FileName;
                Text = $"Текстовый редактор - {path}";
                this.richTextBox.Text = File.ReadAllText(path, Encoding.UTF8);
            }
        }
        private void SaveFile(object semser, EventArgs e)
        {
            if (path != "")
            {
                File.WriteAllText(path, richTextBox.Text);
                MessageBox.Show("Файл сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Файл не был создан", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void SaveAsFile(object semser, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            save.FilterIndex = 2;
            if (save.ShowDialog() == DialogResult.OK)
            {
                path = save.FileName;
                File.WriteAllText(path, richTextBox.Text);
                Text = $"Текстовый редактор - {path}";
            }
        }
        private void CopyFile(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
                Clipboard.SetDataObject(richTextBox.SelectedText);
            else
                Clipboard.SetDataObject("");
        }
        private void CutFile(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                Clipboard.SetDataObject(richTextBox.SelectedText);
                richTextBox.SelectedText = "";
            }
            else
                Clipboard.SetDataObject("");
        }
        private void InsertFile(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }
        private void CancelFile(object sender, EventArgs e)
        {
            if (richTextBox.CanUndo == true)
            {
                richTextBox.Undo();
                richTextBox.ClearUndo();
            }
        }
        private void SelectAllFile(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }
        private void ColorFontFile(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                ColorDialog color = new ColorDialog();
                if (color.ShowDialog() == DialogResult.OK)
                    richTextBox.SelectionColor = color.Color;
            }
        }
        private void ColorBackFile(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                ColorDialog color = new ColorDialog();
                if (color.ShowDialog() == DialogResult.OK)
                    richTextBox.SelectionBackColor = color.Color;
            }
        }
        private void FontFile(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                FontDialog font = new FontDialog();
                if (font.ShowDialog() == DialogResult.OK)
                    richTextBox.SelectionFont = font.Font;
            }
        }

    }
}
