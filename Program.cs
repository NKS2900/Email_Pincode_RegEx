using System;

namespace EmailPincodeValidation
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome To Email_Pincode Validation***");
            Validation val = new Validation();
            Console.Write("Enter Pincode : ");
            string pincode = Console.ReadLine();
            Console.WriteLine(val.PincodeVal(pincode));
        }
    }
}
