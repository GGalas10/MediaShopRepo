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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuWindow));
            panel1 = new Panel();
            RightBtn = new Label();
            LeftBtn = new Label();
            PageLbl = new Label();
            FilterDelBox = new ComboBox();
            ZeroBtn = new Button();
            SearchBox = new ComboBox();
            FirmsBox = new ComboBox();
            EndFiltr = new Label();
            StartFiltr = new Label();
            SearchFiltr = new Label();
            SearchText = new TextBox();
            EndDataFiltr = new Label();
            StartDateFiltr = new Label();
            FiltrFirms = new Label();
            button2 = new Button();
            button1 = new Button();
            Calendar = new MonthCalendar();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            IDCol = new DataGridViewTextBoxColumn();
            NameCol = new DataGridViewTextBoxColumn();
            NuberWZ = new DataGridViewTextBoxColumn();
            NrFv = new DataGridViewTextBoxColumn();
            DateFv = new DataGridViewTextBoxColumn();
            DelDate = new DataGridViewTextBoxColumn();
            DateCol = new DataGridViewTextBoxColumn();
            BtnCol = new DataGridViewButtonColumn();
            DelCol = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(RightBtn);
            panel1.Controls.Add(LeftBtn);
            panel1.Controls.Add(PageLbl);
            panel1.Controls.Add(FilterDelBox);
            panel1.Controls.Add(ZeroBtn);
            panel1.Controls.Add(SearchBox);
            panel1.Controls.Add(FirmsBox);
            panel1.Controls.Add(EndFiltr);
            panel1.Controls.Add(StartFiltr);
            panel1.Controls.Add(SearchFiltr);
            panel1.Controls.Add(SearchText);
            panel1.Controls.Add(EndDataFiltr);
            panel1.Controls.Add(StartDateFiltr);
            panel1.Controls.Add(FiltrFirms);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 74);
            panel1.TabIndex = 0;
            // 
            // RightBtn
            // 
            RightBtn.Image = Properties.Resources.right;
            RightBtn.Location = new Point(123, 45);
            RightBtn.Name = "RightBtn";
            RightBtn.Size = new Size(20, 20);
            RightBtn.TabIndex = 17;
            RightBtn.Click += RightBtn_Click;
            // 
            // LeftBtn
            // 
            LeftBtn.Image = Properties.Resources.left;
            LeftBtn.Location = new Point(12, 45);
            LeftBtn.Name = "LeftBtn";
            LeftBtn.Size = new Size(20, 20);
            LeftBtn.TabIndex = 16;
            LeftBtn.Click += LeftBtn_Click;
            // 
            // PageLbl
            // 
            PageLbl.AutoSize = true;
            PageLbl.Location = new Point(38, 45);
            PageLbl.Name = "PageLbl";
            PageLbl.Size = new Size(79, 19);
            PageLbl.TabIndex = 15;
            PageLbl.Text = "Strona 1z1";
            // 
            // FilterDelBox
            // 
            FilterDelBox.Anchor = AnchorStyles.Right;
            FilterDelBox.FormattingEnabled = true;
            FilterDelBox.Items.AddRange(new object[] { "Wszystko", "Dostawa", "Serwis", "Inne" });
            FilterDelBox.Location = new Point(610, 38);
            FilterDelBox.Name = "FilterDelBox";
            FilterDelBox.Size = new Size(146, 27);
            FilterDelBox.TabIndex = 14;
            FilterDelBox.Text = "Wszystko";
            FilterDelBox.TextChanged += FilterDelBox_TextChanged;
            FilterDelBox.KeyPress += FilterDelBox_KeyPress;
            // 
            // ZeroBtn
            // 
            ZeroBtn.Anchor = AnchorStyles.Right;
            ZeroBtn.Location = new Point(596, 6);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(75, 28);
            ZeroBtn.TabIndex = 13;
            ZeroBtn.Text = "Zeruj";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += ZeroBtn_Click;
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SearchBox.FormattingEnabled = true;
            SearchBox.Items.AddRange(new object[] { "Numer faktury", "Numer Wz" });
            SearchBox.Location = new Point(806, 6);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(125, 27);
            SearchBox.TabIndex = 12;
            SearchBox.TextChanged += SearchBox_TextChanged;
            SearchBox.KeyPress += SearchBox_KeyPress;
            // 
            // FirmsBox
            // 
            FirmsBox.FormattingEnabled = true;
            FirmsBox.Location = new Point(203, 6);
            FirmsBox.Name = "FirmsBox";
            FirmsBox.Size = new Size(133, 27);
            FirmsBox.TabIndex = 11;
            FirmsBox.TextChanged += FirmsBox_TextChanged;
            FirmsBox.KeyPress += FirmsBox_KeyPress;
            // 
            // EndFiltr
            // 
            EndFiltr.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            EndFiltr.AutoSize = true;
            EndFiltr.Location = new Point(473, 38);
            EndFiltr.Name = "EndFiltr";
            EndFiltr.Size = new Size(81, 19);
            EndFiltr.TabIndex = 9;
            EndFiltr.Text = "20.10.2022";
            EndFiltr.Click += EndDataFiltr_Click;
            // 
            // StartFiltr
            // 
            StartFiltr.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            StartFiltr.AutoSize = true;
            StartFiltr.Location = new Point(342, 39);
            StartFiltr.Name = "StartFiltr";
            StartFiltr.Size = new Size(81, 19);
            StartFiltr.TabIndex = 8;
            StartFiltr.Text = "20.10.2022";
            StartFiltr.Click += StartDateFiltr_Click;
            // 
            // SearchFiltr
            // 
            SearchFiltr.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SearchFiltr.AutoSize = true;
            SearchFiltr.Location = new Point(677, 10);
            SearchFiltr.Name = "SearchFiltr";
            SearchFiltr.Size = new Size(123, 19);
            SearchFiltr.TabIndex = 6;
            SearchFiltr.Text = "Wyszukiwanie po";
            // 
            // SearchText
            // 
            SearchText.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SearchText.Enabled = false;
            SearchText.Location = new Point(762, 39);
            SearchText.Name = "SearchText";
            SearchText.Size = new Size(258, 26);
            SearchText.TabIndex = 5;
            SearchText.TextChanged += SearchText_TextChanged;
            // 
            // EndDataFiltr
            // 
            EndDataFiltr.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            EndDataFiltr.AutoSize = true;
            EndDataFiltr.Location = new Point(451, 9);
            EndDataFiltr.Name = "EndDataFiltr";
            EndDataFiltr.Size = new Size(103, 19);
            EndDataFiltr.TabIndex = 4;
            EndDataFiltr.Text = "Data do kiedy";
            EndDataFiltr.Click += EndDataFiltr_Click;
            // 
            // StartDateFiltr
            // 
            StartDateFiltr.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            StartDateFiltr.AutoSize = true;
            StartDateFiltr.Location = new Point(342, 9);
            StartDateFiltr.Name = "StartDateFiltr";
            StartDateFiltr.Size = new Size(103, 19);
            StartDateFiltr.TabIndex = 3;
            StartDateFiltr.Text = "Data od kiedy";
            StartDateFiltr.Click += StartDateFiltr_Click;
            // 
            // FiltrFirms
            // 
            FiltrFirms.AutoSize = true;
            FiltrFirms.Location = new Point(149, 9);
            FiltrFirms.Name = "FiltrFirms";
            FiltrFirms.Size = new Size(48, 19);
            FiltrFirms.TabIndex = 2;
            FiltrFirms.Text = "Firma";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(938, 4);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(82, 29);
            button2.TabIndex = 1;
            button2.Text = "Firmy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 4);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(121, 29);
            button1.TabIndex = 0;
            button1.Text = "Dodaj WZ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Calendar
            // 
            Calendar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Calendar.Enabled = false;
            Calendar.Location = new Point(285, 35);
            Calendar.MaxSelectionCount = 1;
            Calendar.Name = "Calendar";
            Calendar.TabIndex = 1;
            Calendar.Visible = false;
            Calendar.DateSelected += Calendar_DateSelected;
            Calendar.KeyPress += Calendar_KeyPress;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, IDCol, NameCol, NuberWZ, NrFv, DateFv, DelDate, DateCol, BtnCol, DelCol });
            dataGridView1.Location = new Point(0, 72);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1024, 494);
            dataGridView1.TabIndex = 0;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // Id
            // 
            Id.FillWeight = 50F;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // IDCol
            // 
            IDCol.FillWeight = 50F;
            IDCol.HeaderText = "L.P.";
            IDCol.MinimumWidth = 50;
            IDCol.Name = "IDCol";
            IDCol.ReadOnly = true;
            IDCol.Width = 50;
            // 
            // NameCol
            // 
            NameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NameCol.FillWeight = 150F;
            NameCol.HeaderText = "Firma";
            NameCol.MinimumWidth = 150;
            NameCol.Name = "NameCol";
            NameCol.ReadOnly = true;
            // 
            // NuberWZ
            // 
            NuberWZ.HeaderText = "Numer Oryginału";
            NuberWZ.Name = "NuberWZ";
            NuberWZ.ReadOnly = true;
            // 
            // NrFv
            // 
            NrFv.HeaderText = "Numer faktury";
            NrFv.Name = "NrFv";
            NrFv.ReadOnly = true;
            // 
            // DateFv
            // 
            DateFv.HeaderText = "Data faktury";
            DateFv.Name = "DateFv";
            DateFv.ReadOnly = true;
            // 
            // DelDate
            // 
            DelDate.HeaderText = "Data dostawy";
            DelDate.Name = "DelDate";
            DelDate.ReadOnly = true;
            // 
            // DateCol
            // 
            DateCol.HeaderText = "Data Wz";
            DateCol.MinimumWidth = 100;
            DateCol.Name = "DateCol";
            DateCol.ReadOnly = true;
            // 
            // BtnCol
            // 
            BtnCol.FillWeight = 75F;
            BtnCol.HeaderText = "Podgląd";
            BtnCol.MinimumWidth = 75;
            BtnCol.Name = "BtnCol";
            BtnCol.ReadOnly = true;
            BtnCol.Width = 75;
            // 
            // DelCol
            // 
            DelCol.HeaderText = "Usuń";
            DelCol.Name = "DelCol";
            DelCol.ReadOnly = true;
            DelCol.Resizable = DataGridViewTriState.True;
            DelCol.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // MenuWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 566);
            Controls.Add(Calendar);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(1040, 605);
            Name = "MenuWindow";
            Text = "Media Shop Wz Manager";
            Load += MenuWindow_Load;
            Shown += MenuWindow_Shown;
            SizeChanged += MenuWindow_SizeChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
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
        private ComboBox FilterDelBox;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IDCol;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn NuberWZ;
        private DataGridViewTextBoxColumn NrFv;
        private DataGridViewTextBoxColumn DateFv;
        private DataGridViewTextBoxColumn DelDate;
        private DataGridViewTextBoxColumn DateCol;
        private DataGridViewButtonColumn BtnCol;
        private DataGridViewButtonColumn DelCol;
        private Label PageLbl;
        private Label RightBtn;
        private Label LeftBtn;
    }
}