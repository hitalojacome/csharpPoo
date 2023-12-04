﻿using System;
using System.Globalization;
using Entities;
using Services;

namespace Inter

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine()!);
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine()!);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine()!);

            Contract myContract = new Contract(contractNumber, contractDate, contractValue);

            ContractService contractService = new (new PaypalService());
            contractService.ProcessContract(myContract, months);

            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.Installments) 
            {
                Console.WriteLine(installment);
            }
        }
    }
}