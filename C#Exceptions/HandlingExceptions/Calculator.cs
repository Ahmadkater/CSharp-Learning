using System ;

namespace HandlingExceptions
{
    public class Calculator
    {
       
       public int Calculate(int n1 , int n2 , string operation)
       {
           string nonNullOp = operation?? throw new ArgumentNullException(nameof(operation),"Cannot be null") ;

           if (nonNullOp == "/")
           {
               try
               {
                   return Divide(n1,n2) ;
               }
               catch (DivideByZeroException e)
               {
                   
                   //throw;
                   // wrapping exceptions
                   throw new CalculatorException("Error Occured during division" ,e);

               }
           }
           else
           {
               throw new CalculationOperationNotSupportedException(operation);
           }
       }

        private int Divide(int n1, int n2)
        {
            return n1 / n2 ;
        }

    }
}