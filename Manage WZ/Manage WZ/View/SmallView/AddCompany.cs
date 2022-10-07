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

namespace Manage_WZ.View.SmallView
{
    public partial class AddCompany : Form
    {
        public AddCompany()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                using (var context = new DatabaseContext())
                {
                    FirmModel company = new FirmModel();
                    company.Name = textBox1.Text;
                    context.firms.Add(company);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Zapis udany");
                        this.Close();
                    }
                }
            }
            else
            {
                var tip = new ToolTip();
                tip.IsBalloon = true;
                tip.Show("Nie podano nazwy firmy", this, textBox1.Location.X, textBox1.Location.Y, 3000);
            }
        }
    }
}
