using Manage_WZ.Model;
using Manage_WZ.View.SmallView;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Manage_WZ
{
    public partial class MenuWindow : Form
    {
        bool czy = false;
        public MenuWindow()
        {
            InitializeComponent();
            
        }
        public void SyncDate()
        {
            List<WzModel> wzList = new List<WzModel>();
            using (DatabaseContext context = new DatabaseContext())
            {
                if (!context.Database.Exists())
                {
                    Directory.CreateDirectory("C:\\Temp");
                    context.Database.Create();
                }
                wzList = context.Wzs.ToList();

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
    }
}