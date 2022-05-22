
namespace Modul_6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewToolStrip = new System.Windows.Forms.ToolStripButton();
            this.OpenToolStrip = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStrip = new System.Windows.Forms.ToolStripButton();
            this.CopyToolStrip = new System.Windows.Forms.ToolStripButton();
            this.CutToolStrip = new System.Windows.Forms.ToolStripButton();
            this.InsertToolStrip = new System.Windows.Forms.ToolStripButton();
            this.CanselToolStrip = new System.Windows.Forms.ToolStripButton();
            this.ColorFontTtoolStrip = new System.Windows.Forms.ToolStripButton();
            this.ColorBackToolStrip = new System.Windows.Forms.ToolStripButton();
            this.FontToolStrip = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CanselToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColocBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStrip,
            this.OpenToolStrip,
            this.SaveToolStrip,
            this.CopyToolStrip,
            this.CutToolStrip,
            this.InsertToolStrip,
            this.CanselToolStrip,
            this.ColorFontTtoolStrip,
            this.ColorBackToolStrip,
            this.FontToolStrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(525, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewToolStrip
            // 
            this.NewToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("NewToolStrip.Image")));
            this.NewToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStrip.Name = "NewToolStrip";
            this.NewToolStrip.Size = new System.Drawing.Size(23, 22);
            this.NewToolStrip.Text = "Новый документ";
            // 
            // OpenToolStrip
            // 
            this.OpenToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStrip.Image")));
            this.OpenToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStrip.Name = "OpenToolStrip";
            this.OpenToolStrip.Size = new System.Drawing.Size(23, 22);
            this.OpenToolStrip.Text = "Открыть";
            // 
            // SaveToolStrip
            // 
            this.SaveToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStrip.Enabled = false;
            this.SaveToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStrip.Image")));
            this.SaveToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStrip.Name = "SaveToolStrip";
            this.SaveToolStrip.Size = new System.Drawing.Size(23, 22);
            this.SaveToolStrip.Text = "Сохранить";
            // 
            // CopyToolStrip
            // 
            this.CopyToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyToolStrip.Enabled = false;
            this.CopyToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("CopyToolStrip.Image")));
            this.CopyToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyToolStrip.Name = "CopyToolStrip";
            this.CopyToolStrip.Size = new System.Drawing.Size(23, 22);
            this.CopyToolStrip.Text = "Копировать";
            // 
            // CutToolStrip
            // 
            this.CutToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CutToolStrip.Enabled = false;
            this.CutToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("CutToolStrip.Image")));
            this.CutToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutToolStrip.Name = "CutToolStrip";
            this.CutToolStrip.Size = new System.Drawing.Size(23, 22);
            this.CutToolStrip.Text = "Вырезать";
            // 
            // InsertToolStrip
            // 
            this.InsertToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InsertToolStrip.Enabled = false;
            this.InsertToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("InsertToolStrip.Image")));
            this.InsertToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsertToolStrip.Name = "InsertToolStrip";
            this.InsertToolStrip.Size = new System.Drawing.Size(23, 22);
            this.InsertToolStrip.Text = "Вставить";
            // 
            // CanselToolStrip
            // 
            this.CanselToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CanselToolStrip.Enabled = false;
            this.CanselToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("CanselToolStrip.Image")));
            this.CanselToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CanselToolStrip.Name = "CanselToolStrip";
            this.CanselToolStrip.Size = new System.Drawing.Size(23, 22);
            this.CanselToolStrip.Text = "Отменить";
            // 
            // ColorFontTtoolStrip
            // 
            this.ColorFontTtoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorFontTtoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("ColorFontTtoolStrip.Image")));
            this.ColorFontTtoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorFontTtoolStrip.Name = "ColorFontTtoolStrip";
            this.ColorFontTtoolStrip.Size = new System.Drawing.Size(23, 22);
            this.ColorFontTtoolStrip.Text = "Цвет шрифта";
            // 
            // ColorBackToolStrip
            // 
            this.ColorBackToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorBackToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("ColorBackToolStrip.Image")));
            this.ColorBackToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorBackToolStrip.Name = "ColorBackToolStrip";
            this.ColorBackToolStrip.Size = new System.Drawing.Size(23, 22);
            this.ColorBackToolStrip.Text = "Цвет фона";
            // 
            // FontToolStrip
            // 
            this.FontToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FontToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("FontToolStrip.Image")));
            this.FontToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontToolStrip.Name = "FontToolStrip";
            this.FontToolStrip.Size = new System.Drawing.Size(23, 22);
            this.FontToolStrip.Text = "Шрифт";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редактироватьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.NewToolStripMenuItem.Text = "Новый файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Enabled = false;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Enabled = false;
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.InsertToolStripMenuItem,
            this.CanselToolStripMenuItem,
            this.SelectToolStripMenuItem,
            this.ColorFontToolStripMenuItem,
            this.ColocBackToolStripMenuItem,
            this.FontToolStripMenuItem});
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Enabled = false;
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.CutToolStripMenuItem.Text = "Вырезать";
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Enabled = false;
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.CopyToolStripMenuItem.Text = "Копировать";
            // 
            // InsertToolStripMenuItem
            // 
            this.InsertToolStripMenuItem.Enabled = false;
            this.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem";
            this.InsertToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.InsertToolStripMenuItem.Text = "Вставить";
            // 
            // CanselToolStripMenuItem
            // 
            this.CanselToolStripMenuItem.Enabled = false;
            this.CanselToolStripMenuItem.Name = "CanselToolStripMenuItem";
            this.CanselToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.CanselToolStripMenuItem.Text = "Отменить";
            // 
            // SelectToolStripMenuItem
            // 
            this.SelectToolStripMenuItem.Enabled = false;
            this.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem";
            this.SelectToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.SelectToolStripMenuItem.Text = "Выделить все";
            // 
            // ColorFontToolStripMenuItem
            // 
            this.ColorFontToolStripMenuItem.Name = "ColorFontToolStripMenuItem";
            this.ColorFontToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ColorFontToolStripMenuItem.Text = "Цвет шрифта";
            // 
            // ColocBackToolStripMenuItem
            // 
            this.ColocBackToolStripMenuItem.Name = "ColocBackToolStripMenuItem";
            this.ColocBackToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ColocBackToolStripMenuItem.Text = "Цвет фона";
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.FontToolStripMenuItem.Text = "Шрифт";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Enabled = false;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.отменитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 92);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Enabled = false;
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Enabled = false;
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Enabled = false;
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.Enabled = false;
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.отменитьToolStripMenuItem.Text = "Отменить";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 63);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(501, 378);
            this.richTextBox.TabIndex = 4;
            this.richTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Число слов:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(64, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Текстовый редактор";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewToolStrip;
        private System.Windows.Forms.ToolStripButton OpenToolStrip;
        private System.Windows.Forms.ToolStripButton SaveToolStrip;
        private System.Windows.Forms.ToolStripButton CopyToolStrip;
        private System.Windows.Forms.ToolStripButton CutToolStrip;
        private System.Windows.Forms.ToolStripButton InsertToolStrip;
        private System.Windows.Forms.ToolStripButton CanselToolStrip;
        private System.Windows.Forms.ToolStripButton ColorFontTtoolStrip;
        private System.Windows.Forms.ToolStripButton ColorBackToolStrip;
        private System.Windows.Forms.ToolStripButton FontToolStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CanselToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColocBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

