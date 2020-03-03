using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your customer number");
            int bankAccountIdInserted = Int32.Parse(Console.ReadLine());
            List<BankAccount> list = GetBankAccount(bankAccountIdInserted);
            Console.WriteLine();
            Console.WriteLine("Bank account numbers:");
            foreach (var x in list)
            {
                Console.WriteLine(x.BankAccountNumberId);
            }
        }
        public static List<T> GetCustomerProduct<T>(int customerId, List<T> list) where T : CustomerProduct
        {
            return list.Where(x => x.Customer.CustomerId == customerId).ToList();
        }

        public static List<BankAccount>GetBankAccount(int customerId)
        {
            Seed seed =new Seed();
            List<BankAccount> ListOfBankAccounts = seed.GetListOfBankAccounts();
            return GetCustomerProduct<BankAccount>(customerId, ListOfBankAccounts);
        }

        public static List<CreditCard>GetCreditCards(int customerId)
        {
            Seed seed = new Seed();
            List<CreditCard> ListOfCreditCards = seed.GetListOfCreditCards();
            return GetCustomerProduct<CreditCard>(customerId, ListOfCreditCards);
        }

          

    }
}
