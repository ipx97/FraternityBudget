using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FraternityBudget
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = BudgetData.data;
            dataGridView1.DataMember = "Payables";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BudgetData.clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();

            //if (openFile.CheckFileExists && openFile.FileName.Contains(".xml"))
            BudgetData.loadData(openFile.FileName);
        }

        private void buttonAddPayable_Click(object sender, EventArgs e)
        {
            AddPayable payableForm = new AddPayable();
            payableForm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BudgetData.saveData();
        }
    }
}
