using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

//Created by: Caleb Harmon(2417989)

namespace ATMSimulator
{
    public partial class ATMDisplay : Form
    {

        //icon taken from https://icons.iconarchive.com/icons/google/noto-emoji-symbols/1024/73014-ATM-sign-icon.png
   
        


        //Initializing Global Variables
        private Account[] ac;
        private Account activeAccount = null;
        private ATMNetwork Network;
        private bool isRace = false; //Data race bool, will there be a race or not
        private int step = 0; //What step of the process is the ATM at
        private int cardErrors = 0; // Number of errors on the card (if too many mistakes, card will be locked
        

        //constructor for form
        public ATMDisplay(ATMNetwork network)
        {
            InitializeComponent();
            this.Network = network;
            this.ac = network.getNetwork();

            
        }
        //main submit button at ATM, action depends on state variable
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            switch(step)
            {
                case 0:

                    activeAccount = findAccount();

                    if (activeAccount != null)
                    {
                        richTxtBoxScreen.Text = "Please Enter Pin";
                        step++;
                    }
                    else
                    {
                        richTxtBoxScreen.Text = "Could Not Find Account, Please Try Again";
                        cardErrors++;
                        cardErrorCheck();
                    }
                   
                    break;

                case 1:
                    int enteredPin = promptForPin();
                    if (activeAccount.checkPin(enteredPin))
                    {
                        dispOptions();
                        step++;
                    }
                    else
                    {
                        richTxtBoxScreen.Text = "Pin Incorrect; Please Try Again";
                        cardErrors++;
                        cardErrorCheck();
                    }
                    break;
                case 2:
                    dispOptions();
                    getOptions();
                    break;
                case 3:
                    getWithdraw();
                    break;
                case 4:
                    //close form after cardError limit reached
                    this.Close();
                    break;

            }
            //clear input box after button press
            txtBoxInput.Clear();
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
            if (txtBoxInput.Text != "")
            {
                int input = Convert.ToInt32(txtBoxInput.Text);

                for (int i = 0; i < this.ac.Length; i++)
                {
                    if (ac[i].getAccountNum() == input)
                    {
                        return ac[i];
                    }
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
            //richTxtBoxScreen.Text = "Please Enter Pin";
            String str = txtBoxInput.Text;
            if (str == "")
            {
                return 0;
            }
            else
            {
                int pinNumEntered = Convert.ToInt32(str);
                return pinNumEntered;
            }
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

            richTxtBoxScreen.Text = "Welcome "+activeAccount.getAccountName() +"! Please Select an Option Below: \r\n1> take out cash \r\n2> balance\r\n3> exit";


        }
        //get the option from the user
        //seperate from the function to display so that the screen has time to update
        private void getOptions() {

            if(txtBoxInput.Text != "")

            {
               int input = Convert.ToInt32(txtBoxInput.Text);

               if (input == 1)
               {
                    dispWithdraw();
                    step = 3;
               }
               else if (input == 2)
               {
                    dispBalance();
               }
               else if (input == 3)
               {
                    exitATM();
               }
               else
               {
                    richTxtBoxScreen.Text = "Welcome " + activeAccount.getAccountName() + "! Please Select an Option Below: \r\n1> take out cash \r\n2> balance\r\n3> exit\r\n>ERROR: Invalid Input, Please Try Again";
               }

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

            richTxtBoxScreen.Text = "1> 10\r\n2> 20\r\n3> 40\r\n4> 100\r\n5> 500";
        }

        private void getWithdraw() {

            if (txtBoxInput.Text == "")
            {
                dispOptions();
                step = 2;
            }
            else
            {



                int input = Convert.ToInt32(txtBoxInput.Text);

                if (input > 0 && input < 6)
                {

                    //opiton one is entered by the user
                    if (input == 1)
                    {

                        //attempt to decrement account by 10 punds
                        if (activeAccount.decrementBalance(10, this.isRace))
                        {
                            //if this is possible display new balance and await key press
                            richTxtBoxScreen.Text = "Withdrawing $10...\r\nNew Balance = $" + activeAccount.getBalance() + "\r\n(prese enter to continue)";

                        }
                        else
                        {
                            //if this is not possible inform user and await key press
                            richTxtBoxScreen.Text = "insufficent funds\r\n(prese enter to continue)";

                        }
                    }
                    else if (input == 2)
                    {
                        if (activeAccount.decrementBalance(20, this.isRace))
                        {
                            richTxtBoxScreen.Text = "Withdrawing $20...\r\nNew Balance = $" + activeAccount.getBalance() + "\r\n(prese enter to continue)";
                        }
                        else
                        {
                            richTxtBoxScreen.Text = "insufficent funds\r\n(prese enter to continue)";
                        }
                    }
                    else if (input == 3)
                    {
                        if (activeAccount.decrementBalance(40, this.isRace))
                        {
                            richTxtBoxScreen.Text = "Withdrawing $40...\r\nNew Balance = $" + activeAccount.getBalance() + "\r\n(prese enter to continue)";
                        }
                        else
                        {
                            richTxtBoxScreen.Text = "insufficent funds\r\n(prese enter to continue)";
                        }
                    }
                    else if (input == 4)
                    {
                        if (activeAccount.decrementBalance(100, this.isRace))
                        {
                            richTxtBoxScreen.Text = "Withdrawing $100...\r\nNew Balance = $" + activeAccount.getBalance() + "\r\n(prese enter to continue)";
                        }
                        else
                        {
                            richTxtBoxScreen.Text = "insufficent funds\r\n(prese enter to continue)";
                        }
                    }
                    else if (input == 5)
                    {
                        if (activeAccount.decrementBalance(500, this.isRace))
                        {
                            richTxtBoxScreen.Text = "Withdrawing $500...\r\nNew Balance = $" + activeAccount.getBalance() + "\r\n(prese enter to continue)";
                        }
                        else
                        {
                            richTxtBoxScreen.Text = "insufficent funds\r\n(prese enter to continue)";
                        }
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
                richTxtBoxScreen.Text = (" your current balance is : " + activeAccount.getBalance() + "\r\n(prese enter to continue)");
                step = 2;
                              
            }
        }


        //not sure why this doesnt work, cant figure it out
        private void exitATM()
        {
            //richTxtBoxScreen.Clear();
            //Thread.Sleep(200);
            exitMessage();
            if (richTxtBoxScreen.Text == "Returning Card, Have a nice day!")
            {
                this.Close();
                
            }
            //Application.Exit();
            //this.Close();

        }
        //not sure why the message wont display before the app closes
        private void exitMessage()
        {
            richTxtBoxScreen.Text = "Returning Card, Have a nice day!";
            Thread.Sleep(1000);
            richTxtBoxScreen.Invalidate();

        }

        //check the number of errors, if it is >3 block the card
        private void cardErrorCheck()
        {
            if(cardErrors >= 3)
            {
                richTxtBoxScreen.Text = "NOTE: Too Many Errors, the card has been temporarily blocked (Press Enter to Continue)";
                step = 4;
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
            exitATM();
        }

        private void btnSetRace_CheckedChanged(object sender, EventArgs e)
        {
            this.isRace = btnSetRace.Checked;
 
        }


        private void ATMDisplay_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxInput_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

    
