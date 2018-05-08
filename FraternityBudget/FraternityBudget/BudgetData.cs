using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FraternityBudget
{
    static class BudgetData
    {
        // Variables
        public static DataSet data;
        public static DataTable payables, recievables;

        static BudgetData()
        {
            data = new DataSet("Data");
            payables = data.Tables.Add("Payables");
            recievables = data.Tables.Add("Recievables");

            // Creates the payables table
            payables.Columns.Add("Type");
            payables.Columns.Add("Date");
            payables.Columns[1].DataType = typeof(DateTime);
            payables.Columns.Add("ID");
            payables.Columns.Add("Amount");
            payables.Columns[3].DataType = typeof(decimal);
            payables.Columns.Add("Paid To");
            payables.Columns.Add("Description");
            payables.Columns.Add("Category");
            payables.Columns.Add("Receipt");
        }

        internal static void clear()
        {
            data.Clear();
        }

        internal static void saveData()
        {
            data.WriteXml("budget");
        }

        internal static void loadData(string fileName)
        {
            data.ReadXml(fileName);
        }
    }
}
