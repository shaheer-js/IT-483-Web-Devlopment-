using System;

namespace Week_C_2
{
    public class Lab02
{
    public Lab02()
    {
        string rx = "0";
        string tint = "0";
        double total = 0.0;
        Console.WriteLine("What kind of glasses would you like?");
        while ((rx != "1") && (rx != "2"))//Console.ReadLine() is used to take input in a string
            {
            Console.WriteLine("1 -> prescription, 2 -> non-prescription");
            string rxin = Console.ReadLine();//In this case input is going to be for two different types of prescriptions for glasses
            rx = rxin;
        }
            Console.WriteLine("\nWhat kind of coating would you like?");
        while ((tint != "1") && (tint != "2"))//Input for coating
        {
            Console.WriteLine("1 -> anti-glare, 2 -> brown tint");
            string tintin = Console.ReadLine();
                tint = tintin;
        }
        if (tint == "1")
        {
            total += 12.5;//cost of the glass type
        }
        if (tint == "2")
        {
            total += 9.99;
        }
        if (rx == "1")
        {
            total += 40;
        }
        if (rx == "2")
        {
            total += 25;
        }
        Console.WriteLine("Your total cost is " + total.ToString());
    }
}
}





