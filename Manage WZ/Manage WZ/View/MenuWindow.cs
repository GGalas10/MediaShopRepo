using Manage_WZ.Model;
using System.Windows.Forms;

namespace Manage_WZ
{
    public partial class MenuWindow : Form
    {
        public MenuWindow()
        {
            InitializeComponent();           
        }
        public void SyncDate()
        {
            List<WzModel> wzList = new List<WzModel>();
            using (DatabaseContext context = new DatabaseContext())
            {
                wzList = context.Wzs.ToList();
            }
            if (wzList.Count > 0)
            {
                dataGridView1.Rows.Clear();
                foreach (var wz in wzList)
                {
                    dataGridView1.Rows.Add(wz.Id,wz.Firm,wz.Data);
                }
            }
            else
            {
                //Thread th1 = new Thread(PanelVisible);
                //th1.Start();
            }
        }
        private async void MenuWindow_Load(object sender, EventArgs e)
        {
           
        }
        private async Task PanelVisible()
        {
            var th1 = new Thread(Test);
            th1.Start();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await PanelVisible();
        }
        public async void Test()
        {
            Invoke(new Action(() =>
            {
                label1.Visible = true;
                Thread.Sleep(3000);
                label1.Visible = false;
            }));
        }
    }
}