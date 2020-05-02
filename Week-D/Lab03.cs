using System;
namespace Week_D
{
    public class Lab03
    {
        public double account = 45.32;
        public double ammtIn;
        public double subtraction;

        public Lab03()
        {
            Console.WriteLine("Please enter an ammount\n negative for withdrawl,\n positive for deposit\n\n");

            this.ammtIn = Convert.ToDouble(Console.ReadLine());

            if (this.ammtIn > 0)
            {
                this.account += ammtIn;
                Console.WriteLine("you have deposited $" + this.ammtIn.ToString());
                Console.WriteLine("\nAccount balance: $" + this.account.ToString());
            }
            else if (this.ammtIn < 0)
            {
                this.subtraction = this.account + this.ammtIn;
                if (this.subtraction < 0)
                {
                    Console.WriteLine("\nYou can't take that much out!!");
                }
                else if (this.subtraction > 0)
                {
                    Console.WriteLine("\nYou're account balance is: $" + this.subtraction);
                    Console.WriteLine("\n Here is your $" + Math.Abs(this.ammtIn));
           
                }
            }
        }
    }
}


