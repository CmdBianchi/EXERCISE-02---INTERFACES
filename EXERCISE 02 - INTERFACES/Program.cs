using System;
using Entities;
using Services;
using System.Collections.Generic;
namespace EXERCISE_02___INTERFACES {
    //-----> START
    ///////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter Contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contracDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Constract value: ");
            double contractValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract myContract = new Contract(contractNumber, contracDate, contractValue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(myContract, months);

            Console.WriteLine("Installments: ");
            foreach(Installment installment in myContract.Installments) {
                Console.WriteLine(installment);
            }
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> END
}
