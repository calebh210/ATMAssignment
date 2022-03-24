using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator
{
    public class ATMNetwork

    {
        private Account[] ac = new Account[3];
        //private ATMDisplay atm;

        /*
         * This function initilises the 3 accounts 
         * and instanciates the ATM class passing a referance to the account information
         * 
         */
        public ATMNetwork()
        {

            //TODO: Add names to account
            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);

            //atm = new ATMDisplay(ac);

        }

        public Account[] getNetwork()
        {
            return ac;
        }
    }
}
