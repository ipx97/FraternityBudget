using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace FraternityBudgetWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private List<Transaction> payables = new List<Transaction>();
        public MainWindow()
        {
            InitializeComponent();
            payables.Add(new Transaction() {
                cost = true,
                type = "Check",
                date = DateTime.Today,
                ID = 4546,
                amount = 45.65,
                payee = "walmart",
                description = "bla",
                category = "Mag",
                reciept = "link"
            });
            DataGridPayables.ItemsSource = payables;
        }

        private void ButtonAddPayable_Click(object sender, RoutedEventArgs e)
        {
            AddPayable addPayable = new AddPayable() { Owner = GetWindow(this) };
            addPayable.ShowDialog();
        }
    }
}
