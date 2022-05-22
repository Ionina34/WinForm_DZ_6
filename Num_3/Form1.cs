using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Num_3
{
    public partial class Form1 : Form
    {
        MenuStrip menu;
        public Form1()
        {
            InitializeComponent();
            menu = new MenuStrip();
            this.Controls.Add(menu);
            label.BackColor = Color.FromArgb(235, 167, 242);

            TopLevelMenu.TextChanged += TextChanged_Menu;
            SubItem.TextChanged += TextChanged_Menu;

            AddMenu.Click += AddMenu_Click;
            AddinPodMenu.Click += AddPodMenu_Click;
        }
        private void TextChanged_Menu(object sender, EventArgs e)
        {
            if (TopLevelMenu.Text != "")
                TopLevelMenu.BackColor = Color.White;

            if (SubItem.Text != "")
                SubItem.BackColor = Color.White;
        }
        private void AddMenu_Click(object sender, EventArgs e)
        {
            if (TopLevelMenu.Text != "")
                menu.Items.Add(TopLevelMenu.Text);
            else
            {
                TopLevelMenu.BackColor = Color.FromArgb(255, 46, 46);
                MessageBox.Show("Укажите название пункта меню", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void AddPodMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tool;
            bool flag = false;
            if (menu.Items.Count < 1)
                MessageBox.Show("У вас нет ни одного пункта меню", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
            if (TopLevelMenu.Text != "")
            {
                for (int i = 0; i < menu.Items.Count; i++)
                {
                    if (menu.Items[i].Text == TopLevelMenu.Text)
                    {
                        if (SubItem.Text != "")
                        {
                            tool = (ToolStripMenuItem)menu.Items[i];
                            tool.DropDownItems.Add(SubItem.Text);
                            flag = true;
                        }
                        else
                        {
                            SubItem.BackColor = Color.FromArgb(255, 46, 46);
                            MessageBox.Show("Укажите название пункта подменю", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                if (!flag)
                    MessageBox.Show("Пункт меню не найден", "", MessageBoxButtons.OK);
            }
            else
            {
                TopLevelMenu.BackColor = Color.FromArgb(255, 46, 46);
                MessageBox.Show("Укажите название пункта меню", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
