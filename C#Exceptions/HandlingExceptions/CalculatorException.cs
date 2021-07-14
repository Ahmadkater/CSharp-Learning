using System ;

namespace HandlingExceptions
{
    public class CalculatorException : Exception
    {
        private static string _defaultMsg = "An error occured during calcualtion , ensure that correct parameters and operations are passed".ToUpper();

        // using predfine msg
        public CalculatorException() : base(_defaultMsg)
        {
        }

        // using user supplied msg
        public CalculatorException(string msg) : base(msg)
        {
            
        }

        // using predfined msg and wrapped inner exception
        public CalculatorException(Exception innerException ) : base(_defaultMsg,innerException)
        {
            
        }

        // using user supplied msg and wrapped inner exception
        public CalculatorException(string msg , Exception innerException) : base(msg,innerException)
        {
            
        }
    }
}