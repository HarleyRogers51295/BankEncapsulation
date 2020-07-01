using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        //private field for balance that starts at 0.
        private double _balance = 0;
        //sets the balance to 0 and makes it so the user cant directly minipulate it.
        public double Balance 
        { 
            get//we are getting the _balance here
        {
            return _balance;
        }
            set//here we set the _balance to the value.
        {
             _balance = value;
        }
        }
        //Here we have the user input for the GetBalance method.
        public string UserInput { get; set; }
       

        //method that stores an input into the field _balance.
        public void Deposit(double value)//This needs to be void since it does not return a value.
        {
            Balance += value; //this takes the Balance and adds the input too it.
        }
        public void GetBalance()
        {//this takes the user input  and sees what we do with it.
            if(UserInput == "y")
            {
                Console.WriteLine( $"Your current balance is ${Balance}.");
            }
            else
            {
                Console.WriteLine( "ok.");
            }
            
        }
    }
}
