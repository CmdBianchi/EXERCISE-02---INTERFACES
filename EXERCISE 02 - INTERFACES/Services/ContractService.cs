using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Services {
    //------------------------------- START -------------------------------//
    class ContractService {
        private IOnlinePaymentService _onlinePaymentService;
             
        //------------------------------- CONST -------------------------------//
        public ContractService(IOnlinePaymentService onlinePaymentService) {
            _onlinePaymentService = onlinePaymentService;
        }

        //------------------------------- MET -------------------------------//
        public void ProcessContract(Contract contract, int months) {
            double basicQuota = contract.Totalvalue / months;
            for (int i = 1; i<=months; i++) {
                DateTime date = contract.Date.AddDays(i);
                double updateQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                 double fullQuota =  updateQuota + _onlinePaymentService.PaymentFee(updateQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
    //------------------------------- END -------------------------------//
}
