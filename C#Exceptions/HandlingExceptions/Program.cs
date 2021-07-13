using System;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Calculator();
            
            System.Console.WriteLine("Enter 1st num : ");
            int n1  = int.Parse(Console.ReadLine()) ;
            
            System.Console.WriteLine(" ");
            
            System.Console.WriteLine("Enter 2nd num : ");
            var n2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine(" ");

            System.Console.WriteLine("Enter Operation : ");

            var o = Console.ReadLine() ;

            System.Console.WriteLine(" ");

            try
            {
                System.Console.WriteLine(c.Calculate(n1,n2,null));
            }
            catch (ArgumentNullException e) when (e.ParamName == "n2") 
            {
                
                System.Console.WriteLine($"Operation was not provided:\n {e}");

            }
            catch (ArgumentOutOfRangeException e)
            {
                System.Console.WriteLine($"Operation is not supported:\n {e}");
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Something Went Wrong : \n" + e );                
            }
            finally
            {
                System.Console.WriteLine("Finally Block is always executed");
            }

        }
    }
}
