using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FraternityBudgetWPF
{
    public class Transaction
    {
        internal bool cost { get; set; }
        public string type { get; set; }
        public DateTime date { get; set; }
        public int ID { get; set; }
        public double amount { get; set; }
        public string payee { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string reciept { get; set; }
    }
}
