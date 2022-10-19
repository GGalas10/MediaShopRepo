namespace Manage_WZ
{
    partial class MenuWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.ComboBox();
            this.FirmsBox = new System.Windows.Forms.ComboBox();
            this.EndFiltr = new System.Windows.Forms.Label();
            this.StartFiltr = new System.Windows.Forms.Label();
            this.SearchFiltr = new System.Windows.Forms.Label();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.EndDataFiltr = new System.Windows.Forms.Label();
            this.StartDateFiltr = new System.Windows.Forms.Label();
            this.FiltrFirms = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NuberWZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrFv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.ZeroBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ZeroBtn);
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.FirmsBox);
            this.panel1.Controls.Add(this.EndFiltr);
            this.panel1.Controls.Add(this.StartFiltr);
            this.panel1.Controls.Add(this.SearchFiltr);
            this.panel1.Controls.Add(this.SearchText);
            this.panel1.Controls.Add(this.EndDataFiltr);
            this.panel1.Controls.Add(this.StartDateFiltr);
            this.panel1.Controls.Add(this.FiltrFirms);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 74);
            this.panel1.TabIndex = 0;
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.FormattingEnabled = true;
            this.SearchBox.Items.AddRange(new object[] {
            "Numer faktury",
            "Numer Wz"});
            this.SearchBox.Location = new System.Drawing.Point(739, 6);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(125, 27);
            this.SearchBox.TabIndex = 12;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            this.SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBox_KeyPress);
            // 
            // FirmsBox
            // 
            this.FirmsBox.FormattingEnabled = true;
            this.FirmsBox.Location = new System.Drawing.Point(66, 35);
            this.FirmsBox.Name = "FirmsBox";
            this.FirmsBox.Size = new System.Drawing.Size(200, 27);
            this.FirmsBox.TabIndex = 11;
            this.FirmsBox.TextChanged += new System.EventHandler(this.FirmsBox_TextChanged);
            this.FirmsBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirmsBox_KeyPress);
            // 
            // EndFiltr
            // 
            this.EndFiltr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EndFiltr.AutoSize = true;
            this.EndFiltr.Location = new System.Drawing.Point(473, 38);
            this.EndFiltr.Name = "EndFiltr";
            this.EndFiltr.Size = new System.Drawing.Size(81, 19);
            this.EndFiltr.TabIndex = 9;
            this.EndFiltr.Text = "20.10.2022";
            // 
            // StartFiltr
            // 
            this.StartFiltr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartFiltr.AutoSize = true;
            this.StartFiltr.Location = new System.Drawing.Point(342, 39);
            this.StartFiltr.Name = "StartFiltr";
            this.StartFiltr.Size = new System.Drawing.Size(81, 19);
            this.StartFiltr.TabIndex = 8;
            this.StartFiltr.Text = "20.10.2022";
            // 
            // SearchFiltr
            // 
            this.SearchFiltr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchFiltr.AutoSize = true;
            this.SearchFiltr.Location = new System.Drawing.Point(610, 9);
            this.SearchFiltr.Name = "SearchFiltr";
            this.SearchFiltr.Size = new System.Drawing.Size(123, 19);
            this.SearchFiltr.TabIndex = 6;
            this.SearchFiltr.Text = "Wyszukiwanie po";
            // 
            // SearchText
            // 
            this.SearchText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchText.Enabled = false;
            this.SearchText.Location = new System.Drawing.Point(610, 39);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(410, 26);
            this.SearchText.TabIndex = 5;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // EndDataFiltr
            // 
            this.EndDataFiltr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EndDataFiltr.AutoSize = true;
            this.EndDataFiltr.Location = new System.Drawing.Point(451, 9);
            this.EndDataFiltr.Name = "EndDataFiltr";
            this.EndDataFiltr.Size = new System.Drawing.Size(103, 19);
            this.EndDataFiltr.TabIndex = 4;
            this.EndDataFiltr.Text = "Data do kiedy";
            this.EndDataFiltr.Click += new System.EventHandler(this.EndDataFiltr_Click);
            // 
            // StartDateFiltr
            // 
            this.StartDateFiltr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartDateFiltr.AutoSize = true;
            this.StartDateFiltr.Location = new System.Drawing.Point(342, 9);
            this.StartDateFiltr.Name = "StartDateFiltr";
            this.StartDateFiltr.Size = new System.Drawing.Size(103, 19);
            this.StartDateFiltr.TabIndex = 3;
            this.StartDateFiltr.Text = "Data od kiedy";
            this.StartDateFiltr.Click += new System.EventHandler(this.StartDateFiltr_Click);
            // 
            // FiltrFirms
            // 
            this.FiltrFirms.AutoSize = true;
            this.FiltrFirms.Location = new System.Drawing.Point(12, 38);
            this.FiltrFirms.Name = "FiltrFirms";
            this.FiltrFirms.Size = new System.Drawing.Size(48, 19);
            this.FiltrFirms.TabIndex = 2;
            this.FiltrFirms.Text = "Firma";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(867, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dodaj firme";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj WZ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IDCol,
            this.NameCol,
            this.NuberWZ,
            this.NrFv,
            this.DateFv,
            this.DelDate,
            this.DateCol,
            this.BtnCol});
            this.dataGridView1.Location = new System.Drawing.Point(0, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 494);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // IDCol
            // 
            this.IDCol.FillWeight = 50F;
            this.IDCol.HeaderText = "L.P.";
            this.IDCol.MinimumWidth = 50;
            this.IDCol.Name = "IDCol";
            this.IDCol.Width = 50;
            // 
            // NameCol
            // 
            this.NameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameCol.FillWeight = 150F;
            this.NameCol.HeaderText = "Firma";
            this.NameCol.MinimumWidth = 150;
            this.NameCol.Name = "NameCol";
            // 
            // NuberWZ
            // 
            this.NuberWZ.HeaderText = "Numer Oryginału";
            this.NuberWZ.Name = "NuberWZ";
            // 
            // NrFv
            // 
            this.NrFv.HeaderText = "Numer faktury";
            this.NrFv.Name = "NrFv";
            // 
            // DateFv
            // 
            this.DateFv.HeaderText = "Data faktury";
            this.DateFv.Name = "DateFv";
            // 
            // DelDate
            // 
            this.DelDate.HeaderText = "Data dostawy";
            this.DelDate.Name = "DelDate";
            // 
            // DateCol
            // 
            this.DateCol.HeaderText = "Data Wz";
            this.DateCol.MinimumWidth = 100;
            this.DateCol.Name = "DateCol";
            // 
            // BtnCol
            // 
            this.BtnCol.FillWeight = 75F;
            this.BtnCol.HeaderText = "Podgląd";
            this.BtnCol.MinimumWidth = 75;
            this.BtnCol.Name = "BtnCol";
            this.BtnCol.Width = 75;
            // 
            // Calendar
            // 
            this.Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Calendar.Enabled = false;
            this.Calendar.Location = new System.Drawing.Point(314, 35);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 1;
            this.Calendar.Visible = false;
            this.Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateSelected);
            this.Calendar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calendar_KeyPress);
            // 
            // ZeroBtn
            // 
            this.ZeroBtn.Location = new System.Drawing.Point(261, 5);
            this.ZeroBtn.Name = "ZeroBtn";
            this.ZeroBtn.Size = new System.Drawing.Size(75, 28);
            this.ZeroBtn.TabIndex = 13;
            this.ZeroBtn.Text = "Zeruj";
            this.ZeroBtn.UseVisualStyleBackColor = true;
            this.ZeroBtn.Click += new System.EventHandler(this.ZeroBtn_Click);
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 566);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1040, 605);
            this.Name = "MenuWindow";
            this.Text = "Media Shop Wz Manager";
            this.Load += new System.EventHandler(this.MenuWindow_Load);
            this.Shown += new System.EventHandler(this.MenuWindow_Shown);
            this.SizeChanged += new System.EventHandler(this.MenuWindow_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IDCol;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn NuberWZ;
        private DataGridViewTextBoxColumn NrFv;
        private DataGridViewTextBoxColumn DateFv;
        private DataGridViewTextBoxColumn DelDate;
        private DataGridViewTextBoxColumn DateCol;
        private DataGridViewButtonColumn BtnCol;
        private ComboBox SearchBox;
        private ComboBox FirmsBox;
        private Label EndFiltr;
        private Label StartFiltr;
        private Label SearchFiltr;
        private TextBox SearchText;
        private Label EndDataFiltr;
        private Label StartDateFiltr;
        private Label FiltrFirms;
        private MonthCalendar Calendar;
        private Button ZeroBtn;
    }
}