using Manage_WZ.Model;
using Manage_WZ.View.SmallView;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;

namespace Manage_WZ
{
    public partial class MenuWindow : Form
    {
        bool czy = false;
        DateTime startDate = DateTime.UtcNow.AddYears(-5), endDate=DateTime.UtcNow.AddDays(1);
        bool who = false;
        public MenuWindow()
        {
            InitializeComponent();
            
        }
        public void SyncFirms()
        {
            using (var context = new DatabaseContext())
            {
                if (context.firms.Count() > 0)
                {
                    FirmsBox.Items.Clear();
                    FirmsBox.Items.Add("Wszystkie firmy");
                    var allfirms = context.firms.ToList();
                    foreach (var firm in allfirms)
                    {
                        FirmsBox.Items.Add(firm.Name);
                    }                   
                }
            }
        }
        public void SyncDate()
        {
            List<WzModel> wzList = new List<WzModel>();
            int Firmsid;
            StartFiltr.Text = startDate.ToString("d");
            EndFiltr.Text = endDate.ToString("d");
            using (DatabaseContext context = new DatabaseContext())
            {
                if (!context.Database.Exists())
                {
                    Directory.CreateDirectory("C:\\Temp");
                    context.Database.Create();
                }
                if (!string.IsNullOrEmpty(FirmsBox.Text) && FirmsBox.Text!= "Wszystkie firmy")
                {
                    Firmsid = context.firms.FirstOrDefault(f => f.Name == FirmsBox.Text).Id;
                    wzList = context.Wzs.Where(wz => wz.FirmId == Firmsid)
                        .Where(d => d.dateWZ >= startDate && d.dateWZ <= endDate).ToList();
                }
                else
                {
                    wzList = context.Wzs.Where(d=>d.dateWZ>=startDate && d.dateWZ<=endDate).ToList();
                }
                if(SearchText.Enabled == true && !string.IsNullOrEmpty(SearchText.Text))
                {
                    if(SearchBox.Text == "Numer Wz")
                    {
                        wzList = wzList.Where(wz => wz.NumberWZ.Contains(SearchText.Text)).ToList();
                    }
                    else
                    {
                        wzList = wzList.Where(wz => wz.NumberFv.Contains(SearchText.Text)).ToList();
                    }
                }
                if (context.Wzs.ToList().Count > 0)
                {
                    dataGridView1.Rows.Clear();
                    foreach (var wz in wzList)
                    {
                        var fi = context.firms.FirstOrDefault(f => f.Id == wz.FirmId);
                        dataGridView1.Rows.Add(wz.Id,dataGridView1.Rows.Count,fi.Name, 
                            wz.NumberWZ,wz.NumberFv,
                            wz.dateFZ.ToString("d"),wz.dateDelivery.ToString("d"),wz.dateWZ.ToString("d")
                            , "Podgl¹d");
                    }
                }
                else
                {
                    czy = true;
                }                
            }
        }
        private void MenuWindow_Load(object sender, EventArgs e)
        {
            SyncDate();
            SyncFirms();
        }

        private void MenuWindow_Shown(object sender, EventArgs e)
        {
            if (czy)
            {
                var tip = new ToolTip();
                tip.IsBalloon = true;
                tip.Show("Brak danych w bazie", this, 15, 50, 3000);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCompany addComp = new AddCompany();
            addComp.ShowDialog();
            SyncFirms();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newwz = new AddWz();
            newwz.ShowDialog();
            SyncDate();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 8 && dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value != null)
            {
                using (var context = new DatabaseContext())
                {
                    int id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    var wz = context.Wzs.FirstOrDefault(w => w.Id == id);
                    File.WriteAllBytes("C:\\Temp\\WZ.pdf", wz.PdfFile);
                    var proc = Process.Start("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe", "C:\\Temp\\WZ.pdf");
                    proc.WaitForExit();
                    Thread.Sleep(1000);
                    File.Delete("C:\\Temp\\WZ.pdf");
                }
            }
        }

        private void EndDataFiltr_Click(object sender, EventArgs e)
        {
            if (Calendar.Enabled == false)
            {
                Calendar.Location = new Point(EndDataFiltr.Location.X - 20, EndDataFiltr.Location.Y + 30);
                Calendar.Enabled = true;
                Calendar.Visible = true;
                who = true;
            }
            else
            {
                Calendar.Enabled = false;
                Calendar.Visible = false;
            }
            
        }

        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (who)
            {
                if (Calendar.SelectionStart < startDate)
                {
                    var tip = new ToolTip()
                    {
                        IsBalloon = true,
                    };
                    tip.Show("Data koñcowa musi byæ wiêksza ni¿ pocz¹tkowa", this, EndDataFiltr.Location.X, EndDataFiltr.Location.Y, 2500);
                    return;
                }
                endDate = Calendar.SelectionStart;
                EndFiltr.Text = Calendar.SelectionStart.ToString("d");
                EndFiltr.Visible = true;
            }
            else
            {
                if (endDate < Calendar.SelectionStart)
                {
                    var tip = new ToolTip()
                    {
                        IsBalloon = true,
                    };
                    tip.Show("Data pocz¹tkowa musi byæ mniejsza ni¿ koñcowa", this, EndDataFiltr.Location.X, EndDataFiltr.Location.Y, 2500);
                    return;
                }
                startDate = Calendar.SelectionStart;
                StartFiltr.Text = Calendar.SelectionStart.ToString("d");
                StartFiltr.Visible = true;
            }
            SyncDate();
            Calendar.Enabled = false;
            Calendar.Visible = false;
        }

        private void FirmsBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FirmsBox_TextChanged(object sender, EventArgs e)
        {
            SyncDate();
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            SyncDate();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchText.Enabled = true;
        }
        private void Calendar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Calendar.Enabled = false;
                Calendar.Visible = false;
            }
        }

        private void MenuWindow_SizeChanged(object sender, EventArgs e)
        {
            StartDateFiltr.Location = new Point((panel1.Size.Width / 2) - 170, 9);
            EndDataFiltr.Location = new Point((panel1.Size.Width / 2) - 61, 9);
            StartFiltr.Location = new Point((panel1.Size.Width / 2) - 170, 39);
            EndFiltr.Location = new Point((panel1.Size.Width / 2) - 39, 39);
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            startDate = DateTime.UtcNow.AddYears(-5);
            StartFiltr.Text = startDate.ToString("d");
            SyncDate();
        }

        private void StartDateFiltr_Click(object sender, EventArgs e)
        {
            if (Calendar.Enabled == false)
            {
                Calendar.Location = new Point(StartDateFiltr.Location.X - 20,StartDateFiltr.Location.Y+30);
                Calendar.Enabled = true;
                Calendar.Visible = true;
                who = false;
            }
            else
            {
                Calendar.Enabled = false;
                Calendar.Visible = false;
            }
        }
    }
}