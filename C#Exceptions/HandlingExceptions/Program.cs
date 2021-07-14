using System;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Global unhandled exception handling using appdomain
            AppDomain currentAppDomain = AppDomain.CurrentDomain ;
            currentAppDomain.UnhandledException += new UnhandledExceptionEventHandler(HandlingException);
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
                System.Console.WriteLine(c.Calculate(n1,n2,o));
            }
            catch (CalculatorException e)
            {
                System.Console.WriteLine(e);
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

        private static void HandlingException(object sender, UnhandledExceptionEventArgs e)
        {
            System.Console.WriteLine($"There is a problem, error ##### \n {e.ExceptionObject}" );
        }
    }
}
