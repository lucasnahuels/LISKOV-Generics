using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Seed
    {
        public List<BankAccount> GetListOfBankAccounts()
        {
            var bankAccount1 = new BankAccount { BankAccountNumberId = 213, Customer = new Customer { CustomerId = 123 } };
            var bankAccount2 = new BankAccount { BankAccountNumberId = 214, Customer = new Customer { CustomerId = 325 } };
            var bankAccount3 = new BankAccount { BankAccountNumberId = 215, Customer = new Customer { CustomerId = 15434 } };
            var bankAccount4 = new BankAccount { BankAccountNumberId = 21544, Customer = new Customer { CustomerId = 15434 } };
            List<BankAccount> ListOfBankAccounts = new List<BankAccount>();
            ListOfBankAccounts.Add(bankAccount1);
            ListOfBankAccounts.Add(bankAccount2);
            ListOfBankAccounts.Add(bankAccount3);
            ListOfBankAccounts.Add(bankAccount4);
            return ListOfBankAccounts;
        }

        public List<CreditCard> GetListOfCreditCards()
        {
            var creditCard1 = new CreditCard { CardNumber = 213, Customer = new Customer { CustomerId = 123 }, ExpirationDate= new DateTime(2020, 04, 24, 0,0,0) };
            var creditCard2 = new CreditCard { CardNumber = 214, Customer = new Customer { CustomerId = 325 }, ExpirationDate = new DateTime(2020, 04, 26, 0, 0, 0) };
            var creditCard3 = new CreditCard { CardNumber = 215, Customer = new Customer { CustomerId = 15434 }, ExpirationDate = new DateTime(2020, 05, 25, 0, 0, 0) };
            var creditCard4 = new CreditCard { CardNumber = 216, Customer = new Customer { CustomerId = 15434 }, ExpirationDate = new DateTime(2020, 04, 12, 0, 0, 0) };
            var creditCard5 = new CreditCard { CardNumber = 217, Customer = new Customer { CustomerId = 15434 }, ExpirationDate = new DateTime(2020, 04, 20, 0, 0, 0) };
            List<CreditCard> ListOfCreditCards = new List<CreditCard>();
            ListOfCreditCards.Add(creditCard1);
            ListOfCreditCards.Add(creditCard2);
            ListOfCreditCards.Add(creditCard3);
            ListOfCreditCards.Add(creditCard4);
            ListOfCreditCards.Add(creditCard5);
            return ListOfCreditCards;
        }
    }
}
