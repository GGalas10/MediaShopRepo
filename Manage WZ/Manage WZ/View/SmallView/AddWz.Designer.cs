namespace Manage_WZ.View.SmallView
{
    partial class AddWz
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
            this.WzNumberLbl = new System.Windows.Forms.Label();
            this.WzNumberBox = new System.Windows.Forms.TextBox();
            this.FirmLbl = new System.Windows.Forms.Label();
            this.FirmCombo = new System.Windows.Forms.ComboBox();
            this.AddFirmBtn = new System.Windows.Forms.Button();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.FilePathBox = new System.Windows.Forms.TextBox();
            this.WZDateLbl = new System.Windows.Forms.Label();
            this.FvDateLbl = new System.Windows.Forms.Label();
            this.DateWZLBL = new System.Windows.Forms.Label();
            this.DeliveryDateLbl = new System.Windows.Forms.Label();
            this.DateFvLbl = new System.Windows.Forms.Label();
            this.DateDelLbl = new System.Windows.Forms.Label();
            this.DateCalendar = new System.Windows.Forms.MonthCalendar();
            this.FvNrLbl = new System.Windows.Forms.Label();
            this.FvNuberBox = new System.Windows.Forms.TextBox();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.TypeCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // WzNumberLbl
            // 
            this.WzNumberLbl.AutoSize = true;
            this.WzNumberLbl.Location = new System.Drawing.Point(12, 86);
            this.WzNumberLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WzNumberLbl.Name = "WzNumberLbl";
            this.WzNumberLbl.Size = new System.Drawing.Size(83, 19);
            this.WzNumberLbl.TabIndex = 0;
            this.WzNumberLbl.Text = "Numer WZ";
            // 
            // WzNumberBox
            // 
            this.WzNumberBox.Location = new System.Drawing.Point(141, 83);
            this.WzNumberBox.Name = "WzNumberBox";
            this.WzNumberBox.Size = new System.Drawing.Size(227, 26);
            this.WzNumberBox.TabIndex = 1;
            // 
            // FirmLbl
            // 
            this.FirmLbl.AutoSize = true;
            this.FirmLbl.Location = new System.Drawing.Point(12, 9);
            this.FirmLbl.Name = "FirmLbl";
            this.FirmLbl.Size = new System.Drawing.Size(48, 19);
            this.FirmLbl.TabIndex = 2;
            this.FirmLbl.Text = "Firma";
            // 
            // FirmCombo
            // 
            this.FirmCombo.FormattingEnabled = true;
            this.FirmCombo.Location = new System.Drawing.Point(66, 6);
            this.FirmCombo.Name = "FirmCombo";
            this.FirmCombo.Size = new System.Drawing.Size(159, 27);
            this.FirmCombo.TabIndex = 3;
            this.FirmCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // AddFirmBtn
            // 
            this.AddFirmBtn.Location = new System.Drawing.Point(231, 6);
            this.AddFirmBtn.Name = "AddFirmBtn";
            this.AddFirmBtn.Size = new System.Drawing.Size(137, 28);
            this.AddFirmBtn.TabIndex = 4;
            this.AddFirmBtn.Text = "Dodaj firme";
            this.AddFirmBtn.UseVisualStyleBackColor = true;
            this.AddFirmBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(12, 117);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(356, 47);
            this.OpenBtn.TabIndex = 5;
            this.OpenBtn.Text = "Wgraj plik";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(12, 207);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(564, 28);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Zapisz";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // FilePathBox
            // 
            this.FilePathBox.Enabled = false;
            this.FilePathBox.Location = new System.Drawing.Point(12, 175);
            this.FilePathBox.Name = "FilePathBox";
            this.FilePathBox.Size = new System.Drawing.Size(356, 26);
            this.FilePathBox.TabIndex = 8;
            // 
            // WZDateLbl
            // 
            this.WZDateLbl.AutoSize = true;
            this.WZDateLbl.Location = new System.Drawing.Point(374, 9);
            this.WZDateLbl.Name = "WZDateLbl";
            this.WZDateLbl.Size = new System.Drawing.Size(75, 19);
            this.WZDateLbl.TabIndex = 12;
            this.WZDateLbl.Text = "Data WZ:";
            // 
            // FvDateLbl
            // 
            this.FvDateLbl.AutoSize = true;
            this.FvDateLbl.Location = new System.Drawing.Point(374, 46);
            this.FvDateLbl.Name = "FvDateLbl";
            this.FvDateLbl.Size = new System.Drawing.Size(100, 19);
            this.FvDateLbl.TabIndex = 13;
            this.FvDateLbl.Text = "Data faktury:";
            // 
            // DateWZLBL
            // 
            this.DateWZLBL.AutoSize = true;
            this.DateWZLBL.Location = new System.Drawing.Point(495, 9);
            this.DateWZLBL.Name = "DateWZLBL";
            this.DateWZLBL.Size = new System.Drawing.Size(81, 19);
            this.DateWZLBL.TabIndex = 14;
            this.DateWZLBL.Text = "13.10.2022";
            this.DateWZLBL.DoubleClick += new System.EventHandler(this.DateWZLBL_DoubleClick);
            // 
            // DeliveryDateLbl
            // 
            this.DeliveryDateLbl.AutoSize = true;
            this.DeliveryDateLbl.Location = new System.Drawing.Point(374, 86);
            this.DeliveryDateLbl.Name = "DeliveryDateLbl";
            this.DeliveryDateLbl.Size = new System.Drawing.Size(105, 19);
            this.DeliveryDateLbl.TabIndex = 15;
            this.DeliveryDateLbl.Text = "Data dostawy:";
            // 
            // DateFvLbl
            // 
            this.DateFvLbl.AutoSize = true;
            this.DateFvLbl.Location = new System.Drawing.Point(495, 46);
            this.DateFvLbl.Name = "DateFvLbl";
            this.DateFvLbl.Size = new System.Drawing.Size(81, 19);
            this.DateFvLbl.TabIndex = 16;
            this.DateFvLbl.Text = "13.10.2022";
            this.DateFvLbl.Click += new System.EventHandler(this.DateFvLbl_Click);
            // 
            // DateDelLbl
            // 
            this.DateDelLbl.AutoSize = true;
            this.DateDelLbl.Location = new System.Drawing.Point(495, 86);
            this.DateDelLbl.Name = "DateDelLbl";
            this.DateDelLbl.Size = new System.Drawing.Size(81, 19);
            this.DateDelLbl.TabIndex = 17;
            this.DateDelLbl.Text = "13.10.2022";
            this.DateDelLbl.Click += new System.EventHandler(this.DateDelLbl_Click);
            // 
            // DateCalendar
            // 
            this.DateCalendar.Enabled = false;
            this.DateCalendar.Location = new System.Drawing.Point(99, 6);
            this.DateCalendar.MaxSelectionCount = 1;
            this.DateCalendar.Name = "DateCalendar";
            this.DateCalendar.TabIndex = 18;
            this.DateCalendar.Visible = false;
            this.DateCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.DateCalendar_DateSelected);
            // 
            // FvNrLbl
            // 
            this.FvNrLbl.AutoSize = true;
            this.FvNrLbl.Location = new System.Drawing.Point(12, 46);
            this.FvNrLbl.Name = "FvNrLbl";
            this.FvNrLbl.Size = new System.Drawing.Size(108, 19);
            this.FvNrLbl.TabIndex = 19;
            this.FvNrLbl.Text = "Numer faktury";
            // 
            // FvNuberBox
            // 
            this.FvNuberBox.Location = new System.Drawing.Point(126, 43);
            this.FvNuberBox.Name = "FvNuberBox";
            this.FvNuberBox.Size = new System.Drawing.Size(242, 26);
            this.FvNuberBox.TabIndex = 20;
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Location = new System.Drawing.Point(390, 131);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(112, 19);
            this.TypeLbl.TabIndex = 21;
            this.TypeLbl.Text = "Typ dokumentu";
            // 
            // TypeCombo
            // 
            this.TypeCombo.FormattingEnabled = true;
            this.TypeCombo.Location = new System.Drawing.Point(390, 174);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(186, 27);
            this.TypeCombo.TabIndex = 22;
            this.TypeCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeCombo_KeyPress);
            // 
            // AddWz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 247);
            this.Controls.Add(this.TypeCombo);
            this.Controls.Add(this.TypeLbl);
            this.Controls.Add(this.DateCalendar);
            this.Controls.Add(this.FvNuberBox);
            this.Controls.Add(this.FvNrLbl);
            this.Controls.Add(this.DateDelLbl);
            this.Controls.Add(this.DateFvLbl);
            this.Controls.Add(this.DeliveryDateLbl);
            this.Controls.Add(this.DateWZLBL);
            this.Controls.Add(this.FvDateLbl);
            this.Controls.Add(this.WZDateLbl);
            this.Controls.Add(this.FilePathBox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.AddFirmBtn);
            this.Controls.Add(this.FirmCombo);
            this.Controls.Add(this.FirmLbl);
            this.Controls.Add(this.WzNumberBox);
            this.Controls.Add(this.WzNumberLbl);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(604, 286);
            this.MinimumSize = new System.Drawing.Size(604, 286);
            this.Name = "AddWz";
            this.Text = "Dodawanie WZ";
            this.Load += new System.EventHandler(this.AddWz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label WzNumberLbl;
        private TextBox WzNumberBox;
        private Label FirmLbl;
        private ComboBox FirmCombo;
        private Button AddFirmBtn;
        private Button OpenBtn;
        private Button SaveBtn;
        private TextBox FilePathBox;
        private Label WZDateLbl;
        private Label FvDateLbl;
        private Label DateWZLBL;
        private Label DeliveryDateLbl;
        private Label DateFvLbl;
        private Label DateDelLbl;
        private MonthCalendar DateCalendar;
        private Label FvNrLbl;
        private TextBox FvNuberBox;
        private Label TypeLbl;
        private ComboBox TypeCombo;
    }
}