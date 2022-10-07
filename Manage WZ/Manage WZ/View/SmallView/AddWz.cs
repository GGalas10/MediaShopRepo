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
    public partial class AddWz : Form
    {
        public AddWz()
        {
            InitializeComponent();
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void AddWz_Load(object sender, EventArgs e)
        {
            Datasync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pdf Files|*.pdf";
            var result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                textBox2.Text = openFileDialog.FileName;
            }
            else
            {
                var tip = new ToolTip();
                tip.IsBalloon = true;
                tip.Show("Nie wybrano pliku", this, button2.Location.X, button2.Location.Y, 3000);
            }
        }
        void Datasync()
        {
            comboBox1.Items.Clear();
            using (var context = new DatabaseContext())
            {
                if (context.firms.ToList().Count>0) {
                    foreach (var company in context.firms.ToList())
                    {
                        comboBox1.Items.Add(company.Name);
                    }
                }
                else
                {
                    var tip = new ToolTip();
                    tip.IsBalloon = true;
                    tip.Show("Nie posiadasz jeszcze żadnej firmy w bazie\nDodaj ją przez guzik obok", this, comboBox1.Location.X, comboBox1.Location.Y, 3000);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCompany comp = new AddCompany();
            comp.ShowDialog();
            Datasync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox1.Text) && comboBox1.SelectedItem != null)
            {
                using (var context = new DatabaseContext())
                {
                    var wz = new WzModel();
                    wz.NumberWZ = textBox1.Text;
                    wz.FirmId = context.firms.FirstOrDefault(f => f.Name == comboBox1.SelectedItem.ToString()).Id;
                    wz.date = monthCalendar1.SelectionStart;
                    byte[] bytes = File.ReadAllBytes(textBox2.Text.Trim());
                    wz.PdfFile = bytes;
                    context.Wzs.Add(wz);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Udał się zapis");
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Musisz wypełnić wszystkie rubryki");
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            label3.Text = monthCalendar1.SelectionStart.ToString("d");
            monthCalendar1.Visible = false;
            monthCalendar1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            monthCalendar1.Enabled = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
