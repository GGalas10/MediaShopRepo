namespace Manage_WZ.View
{
    partial class FirstWindow
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
            this.FolderBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FolderBtn
            // 
            this.FolderBtn.Location = new System.Drawing.Point(12, 41);
            this.FolderBtn.Name = "FolderBtn";
            this.FolderBtn.Size = new System.Drawing.Size(220, 23);
            this.FolderBtn.TabIndex = 0;
            this.FolderBtn.Text = "Wybierz folder";
            this.FolderBtn.UseVisualStyleBackColor = true;
            this.FolderBtn.Click += new System.EventHandler(this.FolderBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(12, 99);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(220, 23);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Zapisz";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(12, 12);
            this.NameBox.MaxLength = 50;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(220, 23);
            this.NameBox.TabIndex = 2;
            // 
            // pathBox
            // 
            this.pathBox.Enabled = false;
            this.pathBox.Location = new System.Drawing.Point(12, 70);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(220, 23);
            this.pathBox.TabIndex = 3;
            // 
            // FirstWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 127);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.FolderBtn);
            this.Name = "FirstWindow";
            this.Text = "FirstWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button FolderBtn;
        private Button SaveBtn;
        private TextBox NameBox;
        private TextBox pathBox;
    }
}