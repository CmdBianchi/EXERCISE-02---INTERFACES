using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities {
    //------------------------------- START -------------------------------//
    class Contract {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double Totalvalue { get; set; }
        public List<Installment> Installments { get; set; }
    //------------------------------- CONST -------------------------------//
        public Contract(int number, DateTime date, double totalvalue, List<Installment> installments) {
            Number = number;
            Date = date;
            Totalvalue = totalvalue;
            Installments = new List<Installment>();
        }
    //------------------------------- MET -------------------------------//
        public void AddInstallment(Installment installment) {
            Installments.Add(installment);

        }
    }
    //-------------------------------- END -------------------------------//
}
