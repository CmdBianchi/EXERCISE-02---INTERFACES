using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities {
    //------------------------------- START -------------------------------//
    class Installment {
        public DateTime DueDate { get; set; }
        public  double  Amount { get; set; }
    //------------------------------- CONST -------------------------------//
        public Installment(DateTime dueDate, double amount) {
            DueDate = dueDate;
            Amount = amount;
        }
    //------------------------------- MET -------------------------------//
        public override string ToString() {
            return DueDate.ToString("dd/MM/yyyy") + " - " + Amount.ToString("F2");
        }
    }
    //-------------------------------- END -------------------------------//
}
