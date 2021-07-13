using System;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Calculator();
            
            System.Console.WriteLine("Enter 1st num : ");
            var n1  = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine(" ");
            
            System.Console.WriteLine("Enter 2nd num : ");
            var n2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine(" ");

            System.Console.WriteLine("Enter Operation : ");

            var o = Console.ReadLine() ;

            System.Console.WriteLine(" ");

            try
            {
                System.Console.WriteLine(c.Calculate(n1,n2,o));
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Something Went Wrong : " + e.Message + " .");                
            }

        }
    }
}
