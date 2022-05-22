
namespace Num_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.CountElement = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.проводникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackTogToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PathtoolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BackContexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CountFile = new System.Windows.Forms.Label();
            this.OpenContexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(12, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(170, 148);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(211, 24);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(170, 144);
            this.listBox2.TabIndex = 1;
            // 
            // CountElement
            // 
            this.CountElement.AutoSize = true;
            this.CountElement.Location = new System.Drawing.Point(12, 175);
            this.CountElement.Name = "CountElement";
            this.CountElement.Size = new System.Drawing.Size(75, 13);
            this.CountElement.TabIndex = 2;
            this.CountElement.Text = "Элементов: 0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проводникToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(393, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // проводникToolStripMenuItem
            // 
            this.проводникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackToolStripMenuItem,
            this.MenuToolStripMenuItem,
            this.PathtoolStripTextBox1});
            this.проводникToolStripMenuItem.Name = "проводникToolStripMenuItem";
            this.проводникToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.проводникToolStripMenuItem.Text = "Проводник";
            // 
            // BackToolStripMenuItem
            // 
            this.BackToolStripMenuItem.Checked = true;
            this.BackToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            this.BackToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BackToolStripMenuItem.Text = "Назад";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.BackTogToolStripMenuItem1});
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MenuToolStripMenuItem.Text = "Главная";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            // 
            // BackTogToolStripMenuItem1
            // 
            this.BackTogToolStripMenuItem1.Name = "BackTogToolStripMenuItem1";
            this.BackTogToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.BackTogToolStripMenuItem1.Text = "Назад";
            // 
            // PathtoolStripTextBox1
            // 
            this.PathtoolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PathtoolStripTextBox1.Name = "PathtoolStripTextBox1";
            this.PathtoolStripTextBox1.ReadOnly = true;
            this.PathtoolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.PathtoolStripTextBox1.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackContexToolStripMenuItem,
            this.OpenContexToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // BackContexToolStripMenuItem
            // 
            this.BackContexToolStripMenuItem.Name = "BackContexToolStripMenuItem";
            this.BackContexToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BackContexToolStripMenuItem.Text = "Назад";
            // 
            // CountFile
            // 
            this.CountFile.AutoSize = true;
            this.CountFile.Location = new System.Drawing.Point(211, 175);
            this.CountFile.Name = "CountFile";
            this.CountFile.Size = new System.Drawing.Size(75, 13);
            this.CountFile.TabIndex = 5;
            this.CountFile.Text = "Элементов: 0";
            // 
            // OpenContexToolStripMenuItem
            // 
            this.OpenContexToolStripMenuItem.Name = "OpenContexToolStripMenuItem";
            this.OpenContexToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenContexToolStripMenuItem.Text = "Открыть";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 210);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.CountFile);
            this.Controls.Add(this.CountElement);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label CountElement;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem проводникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackTogToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox PathtoolStripTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BackContexToolStripMenuItem;
        private System.Windows.Forms.Label CountFile;
        private System.Windows.Forms.ToolStripMenuItem OpenContexToolStripMenuItem;
    }
}

