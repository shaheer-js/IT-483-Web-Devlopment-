using System;
namespace Week_D_2
{
    public class Lab04
    {
        public Lab04()
        {

            int a = 1, b = 3, c = 5;
            double x = 2.2, y = 4.4, z = 6.6, ans;

            ans = average(a, b);
            Console.WriteLine("\naverage(a,b) = " + ans);

            ans = average(a, b, c);
            Console.WriteLine("\naverage(a,b,c) = " + ans);

            ans = average(x, y);
            Console.WriteLine("\naverage(x,y) = " + ans);

            ans = average(x, y, z);
            Console.WriteLine("\naverage(x,y,z) = " + ans);

        }

            public double average(double n1, double n2)
            {
                return (n1 + n2) / 2.0;
            }

            public double average (double n1, double n2, double n3)
            {

                return (n1 + n2 + n3) / 3.0;
            }

            //Problem Description
            //Q1: NO! we don't need the (int) parameter.

            //Q2: NO! it returns different values.

            //Q3: Yes! it is legal, because they both work on the arguments above.
    
    }

}



