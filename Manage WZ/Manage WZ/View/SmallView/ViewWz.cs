using Manage_WZ.Model;
using Manage_WZ.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

namespace Manage_WZ.View.SmallView
{
    public partial class ViewWz : Form
    {
        private int _id, who = 0;
        private bool Enabled = false;
        DateTime deldate = DateTime.UtcNow.AddYears(-1000), fvdate = DateTime.UtcNow.AddYears(-1000), wzdate = DateTime.UtcNow.AddYears(-1000);
        internal ViewWz(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void TypeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void ViewWz_Load(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                syncFirm();
                var wz = context.Wzs.FirstOrDefault(wz => wz.Id == _id);
                var firm = context.firms.FirstOrDefault(fi => fi.Id == wz.FirmId);
                this.Name = $"WZ: {firm.Name} Nr: {wz.NumberWZ} Data odbioru: {wz.dateDelivery}";
                NameBox.Text = firm.Name;
                WzNumberBox.Text = wz.NumberWZ;
                FvNumberBox.Text = wz.NumberFv;
                TypeBox.Text = wz.type.ToString();
                DescriptionBox.Text = wz.Description;
                DeliveryDateBox.Text = wz.dateDelivery.ToString("d");
                WzDateBox.Text = wz.dateWZ.ToString("d");
                FvDateBox.Text = wz.dateFZ.ToString("d");
            }
        }
        private void ViewBtn_Click(object sender, EventArgs e)
        {
            asyncView();
        }
        private void OpenDialogBtn_Click(object sender, EventArgs e)
        {
            var file = new OpenFileDialog()
            {
                Filter = "Pdf Files|*.pdf"
            };
            var result = file.ShowDialog();
            if (result == DialogResult.OK)
            {
                PathBox.Text = file.FileName;
            }
            else
            {
                var tip = new ToolTip();
                tip.IsBalloon = true;
                tip.Show("Nie wybrano pliku", this, OpenDialogBtn.Location.X, OpenDialogBtn.Location.Y, 3000);
            }
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (Enabled)
            {
                DescriptionBox.Enabled = !Enabled;
                NameBox.Enabled = !Enabled;
                WzNumberBox.Enabled = !Enabled;
                FvNumberBox.Enabled = !Enabled;
                TypeBox.Enabled = !Enabled;
                OpenDialogBtn.Enabled = !Enabled;
                OpenDialogBtn.Visible = !Enabled;
                PathBox.Enabled = !Enabled;
                PathBox.Visible = !Enabled;
                SaveBtn.Enabled = !Enabled;
                SaveBtn.Visible = !Enabled;
                AddBtn.Enabled = !Enabled;
                AddBtn.Visible = !Enabled;
                Calendar.Enabled = !Enabled;
                Calendar.Visible = !Enabled;
                Enabled = false;

            }
            else
            {
                DescriptionBox.Enabled = !Enabled;
                NameBox.Enabled = !Enabled;
                WzNumberBox.Enabled = !Enabled;
                FvNumberBox.Enabled = !Enabled;
                TypeBox.Enabled = !Enabled;
                OpenDialogBtn.Enabled = !Enabled;
                OpenDialogBtn.Visible = !Enabled;
                PathBox.Enabled = !Enabled;
                PathBox.Visible = !Enabled;
                SaveBtn.Enabled = !Enabled;
                SaveBtn.Visible = !Enabled;
                AddBtn.Enabled = !Enabled;
                AddBtn.Visible = !Enabled;
                Enabled = true;
            }
        }
        private void DeliveryDateBox_Click(object sender, EventArgs e)
        {
            who = 1;
            CalendarActive(new Point(DeliveryDateBox.Location.X - 185, DeliveryDateBox.Location.Y + 20));
        }
        private void WzDateBox_Click(object sender, EventArgs e)
        {
            who = 2;
            CalendarActive(new Point(WzDateBox.Location.X - 185, WzDateBox.Location.Y + 20));
        }
        private void FvDateBox_Click(object sender, EventArgs e)
        {
            who = 3;
            CalendarActive(new Point(FvDateBox.Location.X - 185, FvDateBox.Location.Y + 20));
        }
        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            switch (who)
            {
                case 1:
                    DeliveryDateBox.Text = Calendar.SelectionStart.ToString("d");
                    deldate = Calendar.SelectionStart;
                    break;
                case 2:
                    WzDateBox.Text = Calendar.SelectionStart.ToString("d");
                    wzdate = Calendar.SelectionStart;
                    break;
                case 3:
                    FvDateBox.Text = Calendar.SelectionStart.ToString("d");
                    fvdate = Calendar.SelectionStart;
                    break;
                default:
                    Calendar.Enabled = false;
                    Calendar.Visible = false;
                    break;
            }
            Calendar.Enabled = false;
            Calendar.Visible = false;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            var comp = new AddCompany();
            comp.ShowDialog();
            syncFirm();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                var folderBrowser = new FolderBrowserDialog();
                var result = folderBrowser.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var wz = context.Wzs.FirstOrDefault(w => w.Id == _id);
                    string wzName = wz.NumberWZ.Replace('/', '_').Replace('\\', '_')
                        .Replace('@', '_').Replace('*', '_').Replace('|', '_').Replace('"', '_') + ".pdf";
                    File.WriteAllBytes($"{folderBrowser.SelectedPath}\\{wzName}", wz.PdfFile);
                    MessageBox.Show("Plik został zapisany");
                }
                else
                {

                    var tip = new ToolTip()
                    {
                        IsBalloon = true
                    };
                    tip.Show("Należy wybrać scieżkę", this, button1.Location.X + 10, button1.Location.Y, 3000);
                }
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                if (string.IsNullOrEmpty(NameBox.Text) || string.IsNullOrEmpty(WzNumberBox.Text) || string.IsNullOrEmpty(FvNumberBox.Text))
                {
                    MessageBox.Show("Uzupełnij wszystkie dane");
                    return;
                }

                var wz = context.Wzs.FirstOrDefault(wz => wz.Id == _id);
                var firm = context.firms.FirstOrDefault(fi => fi.Name == NameBox.Text);
                if (wzdate >= DateTime.UtcNow.AddYears(-999))
                    wz.dateWZ = wzdate;
                if (fvdate >= DateTime.UtcNow.AddYears(-999))
                    wz.dateFZ = fvdate;
                if (deldate >= DateTime.UtcNow.AddYears(-999))
                    wz.dateDelivery = deldate;
                wz.NumberFv = FvNumberBox.Text;
                wz.NumberWZ = WzNumberBox.Text;
                wz.Firm = firm;
                wz.Description = DescriptionBox.Text.Trim();
                wz.FirmId = firm.Id;
                switch (TypeBox.Text) {
                    case "Dostawa":
                    wz.type = Model.Type.Dostawa;
                        break;
                    case "Serwis":
                    wz.type = Model.Type.Serwis;
                        break;
                    case "Inne":
                        wz.type = Model.Type.Inne;
                        break;
                }
                if (!string.IsNullOrEmpty(PathBox.Text))
                {
                    byte[] bytes = File.ReadAllBytes(PathBox.Text.Trim());
                    wz.PdfFile = bytes;
                }
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Zapis się udał");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Zapis się nie powiódł");
                }
            }
        }
        public void CalendarActive(Point pt)
        {
            if (Enabled && Calendar.Enabled == false)
            {
                Calendar.Location = pt;
                Calendar.Enabled = true;
                Calendar.Visible = true;
            }
            else
            {
                Calendar.Enabled = false;
                Calendar.Visible = false;
            }
        }
        public void syncFirm()
        {
            using (var context = new DatabaseContext())
            {
                var firms = context.firms.ToList();
                NameBox.Items.Clear();
                foreach (var fir in firms)
                {
                    NameBox.Items.Add(fir.Name);
                }
            }
        }
        public async Task asyncView()
        {
            var random = new Random();
            string name = random.Next().ToString();
            var path = Settings.Default.TempPath;
            using (var context = new DatabaseContext())
            {
                var wz = context.Wzs.FirstOrDefault(w => w.Id == _id);
                File.WriteAllBytes($"{path}\\WZ{name}.pdf", wz.PdfFile);
                Thread.Sleep(1000);
            }
            await Task.Run(() =>
            {
                using (var proc = Process.Start("CMD.exe", $"/C start msedge \"{path}\\WZ{name}.pdf\""))
                {
                    proc.WaitForExit();
                    Thread.Sleep(1000);
                }
            });
            File.Delete($"{Settings.Default.TempPath}\\WZ{name}.pdf");
        }
    }
}
