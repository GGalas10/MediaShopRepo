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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 76);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(858, 13);
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
            this.button1.Location = new System.Drawing.Point(4, 13);
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1040, 605);
            this.MinimumSize = new System.Drawing.Size(1040, 605);
            this.Name = "MenuWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuWindow_Load);
            this.Shown += new System.EventHandler(this.MenuWindow_Shown);
            this.panel1.ResumeLayout(false);
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
    }
}