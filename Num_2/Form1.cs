using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Num_2
{
    public partial class Form1 : Form
    {
        List<string> path;
        public Form1()
        {
            InitializeComponent();
            path = new List<string>();
            SerchDick();

            listBox1.DoubleClick += DoubleClick_listBox1;
            listBox2.DoubleClick += DoubleClick_listBox1;

            BackContexToolStripMenuItem.Click += Back_Click;
            BackToolStripMenuItem.Click += Back_Click;
            BackTogToolStripMenuItem1.Click += Back_Click;

            OpenToolStripMenuItem.Click += Open_Click;
            OpenContexToolStripMenuItem.Click += Open_Click;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            if (path.Count == 0)
                return;
            if (path.Count == 1)
            {
                path.RemoveAt(path.Count - 1);
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                SerchDick();
                PathtoolStripTextBox1.Visible = false;
                PathtoolStripTextBox1.Text = "";
            }
            else
            {
                path.RemoveAt(path.Count - 1);
                SerchFile();

            }
        }
        private void Open_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex != -1)
                {
                    path.Add(listBox1.SelectedItem.ToString());
                    if (File.Exists(path[path.Count - 1]))
                        Process.Start(path[path.Count - 1]);
                    else
                        SerchFile();
                }
                if (listBox2.SelectedIndex != 1)
                {
                    path.Add(listBox2.SelectedItem.ToString());
                    if (File.Exists(path[path.Count - 1]))
                        Process.Start(path[path.Count - 1]);
                    else
                        SerchFile();
                }
            }
            catch (Exception)
            {
                path.Clear();
                PathtoolStripTextBox1.Visible = false;
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                SerchDick();
                MessageBox.Show("Невозможно открыть", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DoubleClick_listBox1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == "...")
            {
                path.RemoveAt(path.Count - 1);
                SerchFile();
            }
            if (listBox1.SelectedIndex != -1)
            {
                path.Add(listBox1.SelectedItem.ToString());
                SerchFile();
                PathtoolStripTextBox1.Visible = true;
            }
            if (listBox2.SelectedIndex != -1)
            {
                path.Add(listBox2.SelectedItem.ToString());
                if (File.Exists(path[path.Count - 1]))
                    Process.Start(path[path.Count - 1]);
                else
                    SerchFile();

            }
        }

        public void SerchDick()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            CountElement.Text = $"Элементов: {drives.Length}";
            CountFile.Text = $"Элементов: 0";
            foreach (DriveInfo i in drives)
                listBox1.Items.Add(i);
        }
        public void SerchFile()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            string[] dir = Directory.GetDirectories(path[path.Count - 1]);
            string[] file = Directory.GetFiles(path[path.Count - 1]);
            if (dir.Length < 1)
                listBox1.Items.Add($"...");
            foreach (var i in dir)
            {
                listBox1.Items.Add(i);
                listBox2.Items.Add(i);
            }
            foreach (var i in file)
                listBox2.Items.Add(i);

            CountElement.Text = $"Элементов: {listBox1.Items.Count}";
            CountFile.Text = $"Элементов: {listBox2.Items.Count}";
            PathtoolStripTextBox1.Text = path[path.Count - 1];
        }
    }
}
