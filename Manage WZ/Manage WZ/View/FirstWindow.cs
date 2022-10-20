using Settings = Manage_WZ.Properties.Settings;
namespace Manage_WZ.View
{
    public partial class FirstWindow : Form
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

        private void FolderBtn_Click(object sender, EventArgs e)
        {
                var open = new FolderBrowserDialog();
                open.ShowDialog();
                if(open.SelectedPath != null)
                {
                    pathBox.Text = open.SelectedPath;
                }           
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(pathBox.Text))
            {
                Settings.Default.DbPath = pathBox.Text.Trim()+"\\";
                Settings.Default.FirstTime = false;
                Settings.Default.Save();
                Application.Restart();
            }
        }       
    }
}
