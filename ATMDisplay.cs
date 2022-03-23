using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSimulator
{
    public partial class ATMDisplay : Form
    {

        private Account[] ac;
        private Account activeAccount = null;
        private ATMNetwork Network;
        Boolean clicked = false;


        public ATMDisplay(ATMNetwork network)
        {
            InitializeComponent();
            this.Network = network;
            this.ac = network.getNetwork();

            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (activeAccount == null)
            {
                activeAccount = findAccount();
            }
            else
            {
                lblScreen.Text = "Please Enter Pin";
                int enteredPin = promptForPin();
                if (activeAccount.checkPin(enteredPin)){
                    dispOptions();
                }
            }
        }

        /*
         *    this method promts for the input of an account number
         *    the string input is then converted to an int
         *    a for loop is used to check the enterd account number
         *    against those held in the account array
         *    if a match is found a referance to the match is returned
         *    if the for loop completest with no match we return null
         * 
         */
        private Account findAccount()
        {

            int input = Convert.ToInt32(txtBoxInput.Text);

            for (int i = 0; i < this.ac.Length; i++)
            {
                if (ac[i].getAccountNum() == input)
                {
                    return ac[i];
                }
            }

            return null;
        }
        /*
         * 
         *  this jsut promt the use to enter a pin number
         *  
         * returns the string entered converted to an int
         * 
         */
        private int promptForPin()
        {
            /*lblScreen.Text = "Please Enter Pin";*/
            String str = txtBoxInput.Text;
            int pinNumEntered = Convert.ToInt32(str);
            return pinNumEntered;
        }

        /*
         * 
         *  give the use the options to do with the accoutn
         *  
         *  promt for input
         *  and defer to appropriate method based on input
         *  
         */
        private void dispOptions()
        {

            lblScreen.Text = "1> take out cash \r\n2> balance\r\n3> exit";

            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                dispWithdraw();
            }
            else if (input == 2)
            {
                dispBalance();
            }
            else if (input == 3)
            {


            }
            else
            {

            }

        }

        /*
         * 
         * offer withdrawable amounts
         * 
         * based on input attempt to withraw the corosponding amount of money
         * 
         */
        private void dispWithdraw()
        {
            Console.WriteLine("1> 10");
            Console.WriteLine("2> 50");
            Console.WriteLine("3> 500");

            int input = Convert.ToInt32(Console.ReadLine());

            if (input > 0 && input < 4)
            {

                //opiton one is entered by the user
                if (input == 1)
                {

                    //attempt to decrement account by 10 punds
                    if (activeAccount.decrementBalance(10))
                    {
                        //if this is possible display new balance and await key press
                        Console.WriteLine("new balance " + activeAccount.getBalance());
                        Console.WriteLine(" (prese enter to continue)");
                        Console.ReadLine();
                    }
                    else
                    {
                        //if this is not possible inform user and await key press
                        Console.WriteLine("insufficent funds");
                        Console.WriteLine(" (prese enter to continue)");
                        Console.ReadLine();
                    }
                }
                else if (input == 2)
                {
                    if (activeAccount.decrementBalance(50))
                    {
                        Console.WriteLine("new balance " + activeAccount.getBalance());
                        Console.WriteLine(" (prese enter to continue)");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("insufficent funds");
                        Console.WriteLine(" (prese enter to continue)");
                        Console.ReadLine();
                    }
                }
                else if (input == 3)
                {
                    if (activeAccount.decrementBalance(500))
                    {
                        Console.WriteLine("new balance " + activeAccount.getBalance());
                        Console.WriteLine(" (prese enter to continue)");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("insufficent funds");
                        Console.WriteLine(" (prese enter to continue)");
                        Console.ReadLine();
                    }
                }
            }
        }
        /*
         *  display balance of activeAccount and await keypress
         *  
         */
        private void dispBalance()
        {
            if (this.activeAccount != null)
            {
                lblScreen.Text = (" your current balance is : " + activeAccount.getBalance() + "\r\n(prese enter to continue)");
                              
            }
        }


        /*
         * Below are all of the event handlers for the buttons
         * 
         */

        private void btnNum1_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = txtBoxInput.Text + "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = txtBoxInput.Text + "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = txtBoxInput.Text + "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = txtBoxInput.Text + "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = txtBoxInput.Text + "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = txtBoxInput.Text + "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = txtBoxInput.Text + "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = txtBoxInput.Text + "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = txtBoxInput.Text + "9";
        }

        private void btnNumZero_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = txtBoxInput.Text + "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }

}

    

    /*
     *   This is the root of program and the entry point
     * 
     *   Class programm contains an array of account objects and a singel ATM object  
     * 
     */
    
