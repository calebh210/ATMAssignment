using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
//Created by: Caleb Harmon(2417989)
namespace ATMSimulator
{
    public class Account
    {
        //the attributes for the account
        private int balance;
        private int pin;
        private int accountNum;
        private string name;

        //semaphore documentation https://docs.microsoft.com/en-us/dotnet/api/system.threading.semaphore?view=net-6.0
        SemaphoreSlim semaphore = new SemaphoreSlim(1);

        // a constructor that takes initial values for each of the attributes (balance, pin, accountNumber)
        public Account(int balance, int pin, int accountNum, string name)
        {
            this.balance = balance;
            this.pin = pin;
            this.accountNum = accountNum;
            this.name = name;
        }

        //getter and setter functions for balance
        public int getBalance()
        {
            return balance;
        }
        public void setBalance(int newBalance)
        {
            this.balance = newBalance;
        }

        /*
         *   This funciton allows us to decrement the balance of an account
         *   it perfomes a simple check to ensure the balance is greater tha
         *   the amount being debeted
         *   
         *   reurns:
         *   true if the transactions if possible
         *   false if there are insufficent funds in the account
         */
        public Boolean decrementBalance(int amount, bool isRace)
        {

            //creating the wait if there is NO data race (so create an inconsistency)
            if (!isRace)
            {
                semaphore.Wait();
            }
            {
                //creates local balance BEFORE entering critical code
                int localBalance = this.balance;
                Thread.Sleep(3000);
                if (this.balance > amount)
                {
                    localBalance -= amount;
                    balance = localBalance;
                    semaphore.Release();
                    return true;
                }
                else
                {
                    semaphore.Release();
                    return false;
                }
            }
        }

        /*
         * This funciton check the account pin against the argument passed to it
         *
         * returns:
         * true if they match
         * false if they do not
         */
        public Boolean checkPin(int pinEntered)
        {
            if (pinEntered == pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getAccountNum()
        {
            return accountNum;
        }

        public string getAccountName()
        {
            return name;
        }

    }
    /* 
     *      This is out main ATM class that preforms the actions outlined in the assigment hand out
     *      
     *      the constutor contains the main funcitonality.
     */
}
