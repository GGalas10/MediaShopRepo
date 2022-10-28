using Manage_WZ.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace Manage_WZ.View.SmallView
{
    public partial class AddWz : Form
    {
        public int dateId = 0;
        WzModel newWz;
        public AddWz()
        {
            newWz = new WzModel();
            InitializeComponent();
        }

        private void AddWz_Load(object sender, EventArgs e)
        {
            Datasync();
            DateWZLBL.Text = DateTime.Now.ToString("d");
            DateDelLbl.Text = DateTime.Now.ToString("d");
            DateFvLbl.Text = DateTime.Now.ToString("d");
            newWz.dateFZ = DateTime.Now;
            newWz.dateWZ = DateTime.Now;
            newWz.dateDelivery = DateTime.Now;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pdf Files|*.pdf";
            var result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                FilePathBox.Text = openFileDialog.FileName;
            }
            else
            {
                var tip = new ToolTip();
                tip.IsBalloon = true;
                tip.Show("Nie wybrano pliku", this, OpenBtn.Location.X, OpenBtn.Location.Y, 3000);
            }
        }
        void Datasync()
        {
            FirmCombo.Items.Clear();
            using (var context = new DatabaseContext())
            {
                if (context.firms.ToList().Count>0) {
                    foreach (var company in context.firms.ToList())
                    {
                        FirmCombo.Items.Add(company.Name);
                    }
                }
                else
                {
                    var tip = new ToolTip();
                    tip.IsBalloon = true;
                    tip.Show("Nie posiadasz jeszcze żadnej firmy w bazie\nDodaj ją przez guzik obok", this, FirmCombo.Location.X, FirmCombo.Location.Y, 3000);
                }
            }
            TypeCombo.Items.Clear();
            TypeCombo.Items.Add("Dostawa");
            TypeCombo.Items.Add("Serwis");
            TypeCombo.Items.Add("Inne");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCompany comp = new AddCompany();
            comp.ShowDialog();
            Datasync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                if (!string.IsNullOrEmpty(FirmCombo.Text) || !string.IsNullOrEmpty(TypeCombo.Text) ||
                    !string.IsNullOrEmpty(FvNuberBox.Text) || !string.IsNullOrEmpty(WzNumberBox.Text) || !string.IsNullOrEmpty(FilePathBox.Text))
                {
                    if (context.Wzs.FirstOrDefault(wz => wz.NumberWZ == WzNumberBox.Text) != null)
                    {
                        var tip = new ToolTip()
                        {
                            IsBalloon = true
                        };
                        tip.Show("Taka WZtka już istnieje", this, WzNumberBox.Location.X+25, WzNumberBox.Location.Y-12, 3000);
                        return;
                    }
                    newWz.FirmId = context.firms.FirstOrDefault(f=>f.Name == FirmCombo.Text).Id;
                    newWz.Firm = context.firms.FirstOrDefault(f => f.Name == FirmCombo.Text);
                    switch (TypeCombo.Text)
                    {
                        case "Dostawa":
                            newWz.type = Model.Type.Dostawa;
                            break;
                        case "Serwis":
                            newWz.type = Model.Type.Serwis;
                            break;
                        case "Inne":
                            newWz.type = Model.Type.Inne;
                            break;
                    }
                    newWz.Description = DescriptionBox.Text.Trim();
                    newWz.NumberFv = FvNuberBox.Text.Trim();
                    newWz.NumberWZ = WzNumberBox.Text.Trim();
                    byte[] bytes = File.ReadAllBytes(FilePathBox.Text.Trim());
                    newWz.PdfFile = bytes;
                    context.Wzs.Add(newWz);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Zapis się udał");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Musisz uzupełnić wszystkie rubryki");
                }
            }
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TypeCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public void visibleCalendar()
        {
            DateCalendar.Visible = true;
            DateCalendar.Enabled = true;
        }

        private void DateWZLBL_DoubleClick(object sender, EventArgs e)
        {
            visibleCalendar();
            dateId = 1;
        }

        private void DateFvLbl_Click(object sender, EventArgs e)
        {
            visibleCalendar();
            dateId = 2;
        }

        private void DateDelLbl_Click(object sender, EventArgs e)
        {
            visibleCalendar();
            dateId = 3;
        }

        private void DateCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            switch (dateId)
            {
                case 1:
                    newWz.dateWZ = DateCalendar.SelectionStart.Date;
                    DateWZLBL.Text = DateCalendar.SelectionStart.Date.ToString("d");
                    break;
                case 2:
                    newWz.dateFZ = DateCalendar.SelectionStart.Date;
                    DateFvLbl.Text = DateCalendar.SelectionStart.Date.ToString("d");
                    break;
                case 3:
                    newWz.dateDelivery = DateCalendar.SelectionStart.Date;
                    DateDelLbl.Text = DateCalendar.SelectionStart.Date.ToString("d");
                    break;
            }
            DateCalendar.Visible = false;
            DateCalendar.Enabled = false;
        }
    }
}
