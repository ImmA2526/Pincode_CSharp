using System;
using System.Text.RegularExpressions;

namespace Pincode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Welcome To Pincode Program************");
            PincodeCheker Pin = new PincodeCheker();
            Console.Write("Enter Pincode: ");
            string Pn = Console.ReadLine();
            Console.WriteLine(Pin.Pincod(Pn));
        }
    }
}
