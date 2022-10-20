namespace Manage_WZ.View.SmallView
{
    partial class ViewWz
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.WzNumberBox = new System.Windows.Forms.TextBox();
            this.WzNumberLbl = new System.Windows.Forms.Label();
            this.FvNumberBox = new System.Windows.Forms.TextBox();
            this.FvNumberLbl = new System.Windows.Forms.Label();
            this.DeliveryDateLbl = new System.Windows.Forms.Label();
            this.WzDateLbl = new System.Windows.Forms.Label();
            this.FvDateLbl = new System.Windows.Forms.Label();
            this.DeliveryDateBox = new System.Windows.Forms.Label();
            this.WzDateBox = new System.Windows.Forms.Label();
            this.FvDateBox = new System.Windows.Forms.Label();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.OpenDialogBtn = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.NameBox = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(13, 9);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(48, 19);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Firma";
            // 
            // WzNumberBox
            // 
            this.WzNumberBox.Enabled = false;
            this.WzNumberBox.Location = new System.Drawing.Point(128, 35);
            this.WzNumberBox.Name = "WzNumberBox";
            this.WzNumberBox.Size = new System.Drawing.Size(114, 26);
            this.WzNumberBox.TabIndex = 3;
            // 
            // WzNumberLbl
            // 
            this.WzNumberLbl.AutoSize = true;
            this.WzNumberLbl.Location = new System.Drawing.Point(13, 38);
            this.WzNumberLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WzNumberLbl.Name = "WzNumberLbl";
            this.WzNumberLbl.Size = new System.Drawing.Size(80, 19);
            this.WzNumberLbl.TabIndex = 2;
            this.WzNumberLbl.Text = "Numer Wz";
            // 
            // FvNumberBox
            // 
            this.FvNumberBox.Enabled = false;
            this.FvNumberBox.Location = new System.Drawing.Point(128, 67);
            this.FvNumberBox.Name = "FvNumberBox";
            this.FvNumberBox.Size = new System.Drawing.Size(114, 26);
            this.FvNumberBox.TabIndex = 5;
            // 
            // FvNumberLbl
            // 
            this.FvNumberLbl.AutoSize = true;
            this.FvNumberLbl.Location = new System.Drawing.Point(13, 70);
            this.FvNumberLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FvNumberLbl.Name = "FvNumberLbl";
            this.FvNumberLbl.Size = new System.Drawing.Size(108, 19);
            this.FvNumberLbl.TabIndex = 4;
            this.FvNumberLbl.Text = "Numer faktury";
            // 
            // DeliveryDateLbl
            // 
            this.DeliveryDateLbl.AutoSize = true;
            this.DeliveryDateLbl.Location = new System.Drawing.Point(272, 13);
            this.DeliveryDateLbl.Name = "DeliveryDateLbl";
            this.DeliveryDateLbl.Size = new System.Drawing.Size(105, 19);
            this.DeliveryDateLbl.TabIndex = 0;
            this.DeliveryDateLbl.Text = "Data dostawy:";
            // 
            // WzDateLbl
            // 
            this.WzDateLbl.AutoSize = true;
            this.WzDateLbl.Location = new System.Drawing.Point(272, 45);
            this.WzDateLbl.Name = "WzDateLbl";
            this.WzDateLbl.Size = new System.Drawing.Size(67, 19);
            this.WzDateLbl.TabIndex = 1;
            this.WzDateLbl.Text = "Data wz:";
            // 
            // FvDateLbl
            // 
            this.FvDateLbl.AutoSize = true;
            this.FvDateLbl.Location = new System.Drawing.Point(272, 77);
            this.FvDateLbl.Name = "FvDateLbl";
            this.FvDateLbl.Size = new System.Drawing.Size(100, 19);
            this.FvDateLbl.TabIndex = 2;
            this.FvDateLbl.Text = "Data faktury:";
            // 
            // DeliveryDateBox
            // 
            this.DeliveryDateBox.AutoSize = true;
            this.DeliveryDateBox.Location = new System.Drawing.Point(383, 13);
            this.DeliveryDateBox.Name = "DeliveryDateBox";
            this.DeliveryDateBox.Size = new System.Drawing.Size(81, 19);
            this.DeliveryDateBox.TabIndex = 3;
            this.DeliveryDateBox.Text = "20.10.2022";
            this.DeliveryDateBox.Click += new System.EventHandler(this.DeliveryDateBox_Click);
            // 
            // WzDateBox
            // 
            this.WzDateBox.AutoSize = true;
            this.WzDateBox.Location = new System.Drawing.Point(383, 45);
            this.WzDateBox.Name = "WzDateBox";
            this.WzDateBox.Size = new System.Drawing.Size(81, 19);
            this.WzDateBox.TabIndex = 4;
            this.WzDateBox.Text = "20.10.2022";
            this.WzDateBox.Click += new System.EventHandler(this.WzDateBox_Click);
            // 
            // FvDateBox
            // 
            this.FvDateBox.AutoSize = true;
            this.FvDateBox.Location = new System.Drawing.Point(383, 77);
            this.FvDateBox.Name = "FvDateBox";
            this.FvDateBox.Size = new System.Drawing.Size(81, 19);
            this.FvDateBox.TabIndex = 5;
            this.FvDateBox.Text = "20.10.2022";
            this.FvDateBox.Click += new System.EventHandler(this.FvDateBox_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.Location = new System.Drawing.Point(12, 135);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(229, 33);
            this.ViewBtn.TabIndex = 7;
            this.ViewBtn.Text = "Podgląd WZ";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(12, 277);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 29);
            this.CloseBtn.TabIndex = 8;
            this.CloseBtn.Text = "Wróć";
            this.CloseBtn.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(191, 277);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 29);
            this.EditBtn.TabIndex = 9;
            this.EditBtn.Text = "Edytuj";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Enabled = false;
            this.SaveBtn.Location = new System.Drawing.Point(392, 277);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 29);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Zapisz";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Visible = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Location = new System.Drawing.Point(12, 102);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(34, 19);
            this.TypeLbl.TabIndex = 11;
            this.TypeLbl.Text = "Typ";
            // 
            // TypeBox
            // 
            this.TypeBox.Enabled = false;
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "Dostawa",
            "Serwis"});
            this.TypeBox.Location = new System.Drawing.Point(52, 99);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(190, 27);
            this.TypeBox.TabIndex = 12;
            this.TypeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeBox_KeyPress);
            // 
            // PathBox
            // 
            this.PathBox.Enabled = false;
            this.PathBox.Location = new System.Drawing.Point(12, 237);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(455, 26);
            this.PathBox.TabIndex = 13;
            this.PathBox.Visible = false;
            // 
            // OpenDialogBtn
            // 
            this.OpenDialogBtn.Enabled = false;
            this.OpenDialogBtn.Location = new System.Drawing.Point(133, 202);
            this.OpenDialogBtn.Name = "OpenDialogBtn";
            this.OpenDialogBtn.Size = new System.Drawing.Size(206, 29);
            this.OpenDialogBtn.TabIndex = 14;
            this.OpenDialogBtn.Text = "Wybierz nowy plik";
            this.OpenDialogBtn.UseVisualStyleBackColor = true;
            this.OpenDialogBtn.Visible = false;
            this.OpenDialogBtn.Click += new System.EventHandler(this.OpenDialogBtn_Click);
            // 
            // Calendar
            // 
            this.Calendar.Enabled = false;
            this.Calendar.Location = new System.Drawing.Point(198, 13);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 6;
            this.Calendar.Visible = false;
            this.Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateSelected);
            // 
            // NameBox
            // 
            this.NameBox.Enabled = false;
            this.NameBox.FormattingEnabled = true;
            this.NameBox.Items.AddRange(new object[] {
            "Dostawa",
            "Serwis"});
            this.NameBox.Location = new System.Drawing.Point(85, 5);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(157, 27);
            this.NameBox.TabIndex = 15;
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // AddBtn
            // 
            this.AddBtn.Enabled = false;
            this.AddBtn.Location = new System.Drawing.Point(272, 102);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(192, 32);
            this.AddBtn.TabIndex = 16;
            this.AddBtn.Text = "Dodaj firme";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Visible = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ViewWz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 318);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.FvDateBox);
            this.Controls.Add(this.WzDateBox);
            this.Controls.Add(this.OpenDialogBtn);
            this.Controls.Add(this.DeliveryDateBox);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.FvDateLbl);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.WzDateLbl);
            this.Controls.Add(this.DeliveryDateLbl);
            this.Controls.Add(this.TypeLbl);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.FvNumberBox);
            this.Controls.Add(this.FvNumberLbl);
            this.Controls.Add(this.WzNumberBox);
            this.Controls.Add(this.WzNumberLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.AddBtn);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewWz";
            this.Text = "ViewWz";
            this.Load += new System.EventHandler(this.ViewWz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameLbl;
        private TextBox WzNumberBox;
        private Label WzNumberLbl;
        private TextBox FvNumberBox;
        private Label FvNumberLbl;
        private Label FvDateBox;
        private Label WzDateBox;
        private Label DeliveryDateBox;
        private Label FvDateLbl;
        private Label WzDateLbl;
        private Label DeliveryDateLbl;
        private Button ViewBtn;
        private Button CloseBtn;
        private Button EditBtn;
        private Button SaveBtn;
        private Label TypeLbl;
        private ComboBox TypeBox;
        private TextBox PathBox;
        private Button OpenDialogBtn;
        private MonthCalendar Calendar;
        private ComboBox NameBox;
        private Button AddBtn;
    }
}