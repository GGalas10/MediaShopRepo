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
    public partial class AllFirms : Form
    {
        public AllFirms()
        {
            InitializeComponent();
        }
        private void DataSync()
        {
            dataGridView1.Rows.Clear();
            using (var context = new DatabaseContext())
            {
                if (context.firms.Count() > 0)
                {
                    foreach (var firm in context.firms.ToList())
                    {
                        dataGridView1.Rows.Add(firm.Id, firm.Name, "Usuń");
                    }
                }
                
            }
        }
        private void AllFirms_Load(object sender, EventArgs e)
        {
            DataSync();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                
                var id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                using(var context = new DatabaseContext())
                {
                    var firm = context.firms.FirstOrDefault(f => f.Id == id);
                    var result = MessageBox.Show($"Czy na pewno chcesz usunąć firmę {firm.Name}?"
                        , "Usunąć?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        context.firms.Remove(firm);
                        if (context.SaveChanges() > 0)
                        {
                            MessageBox.Show("Firma została usunięta");
                        }
                    }
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddCompany add = new AddCompany();
            add.ShowDialog();
            DataSync();
        }
    }
}
