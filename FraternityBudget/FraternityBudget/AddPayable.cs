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
    public partial class AddPayable : Form
    {
        public AddPayable()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            // Adds data to table
            BudgetData.payables.Rows.Add(comboBox1.Text, dateTimePicker1.Text, textBoxID.Text, double.Parse(textBoxAmount.Text), 
                textBoxPaidTo.Text, textBoxDesc.Text, textBoxCat.Text, textBoxReceipt.Text);

            resetForm();
        }

        private void resetForm()
        {
            textBoxDesc.Text = textBoxCat.Text = textBoxAmount.Text = textBoxReceipt.Text = textBoxPaidTo.Text = textBoxID.Text = null;
        }
    }
}
