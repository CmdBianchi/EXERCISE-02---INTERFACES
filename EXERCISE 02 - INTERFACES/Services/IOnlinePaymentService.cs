using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Services {
    //------------------------------- START -------------------------------//
    interface IOnlinePaymentService {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
    //-------------------------------- END -------------------------------//
}


