
namespace Num_3
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
            this.TopLevelMenu = new System.Windows.Forms.TextBox();
            this.SubItem = new System.Windows.Forms.TextBox();
            this.AddMenu = new System.Windows.Forms.Button();
            this.AddinPodMenu = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TopLevelMenu
            // 
            this.TopLevelMenu.Location = new System.Drawing.Point(12, 31);
            this.TopLevelMenu.Name = "TopLevelMenu";
            this.TopLevelMenu.Size = new System.Drawing.Size(343, 20);
            this.TopLevelMenu.TabIndex = 0;
            // 
            // SubItem
            // 
            this.SubItem.Location = new System.Drawing.Point(12, 168);
            this.SubItem.Name = "SubItem";
            this.SubItem.Size = new System.Drawing.Size(343, 20);
            this.SubItem.TabIndex = 1;
            // 
            // AddMenu
            // 
            this.AddMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMenu.Location = new System.Drawing.Point(117, 57);
            this.AddMenu.Name = "AddMenu";
            this.AddMenu.Size = new System.Drawing.Size(141, 53);
            this.AddMenu.TabIndex = 2;
            this.AddMenu.Text = "Добавить пункт меню";
            this.AddMenu.UseVisualStyleBackColor = true;
            // 
            // AddinPodMenu
            // 
            this.AddinPodMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddinPodMenu.Location = new System.Drawing.Point(117, 194);
            this.AddinPodMenu.Name = "AddinPodMenu";
            this.AddinPodMenu.Size = new System.Drawing.Size(141, 53);
            this.AddinPodMenu.TabIndex = 3;
            this.AddinPodMenu.Text = "Добавить подменю";
            this.AddinPodMenu.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.Enabled = false;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(9, 128);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(346, 37);
            this.label.TabIndex = 4;
            this.label.Text = "Для того чтобы добавить подменю, укажите название пункта в поле выше";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 294);
            this.Controls.Add(this.label);
            this.Controls.Add(this.AddinPodMenu);
            this.Controls.Add(this.AddMenu);
            this.Controls.Add(this.SubItem);
            this.Controls.Add(this.TopLevelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TopLevelMenu;
        private System.Windows.Forms.TextBox SubItem;
        private System.Windows.Forms.Button AddMenu;
        private System.Windows.Forms.Button AddinPodMenu;
        private System.Windows.Forms.Label label;
    }
}

