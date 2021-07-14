using System ;

namespace HandlingExceptions
{
    public class CalculationOperationNotSupportedException : CalculatorException
    {
        public string Operation { get; set; }
        public CalculationOperationNotSupportedException() : base("Specified operation was out of range of valid values")
        {
            
        }

        public CalculationOperationNotSupportedException(string operation ) :this()
        {
            Operation = operation ;
        }
        public CalculationOperationNotSupportedException(string msg , CalculatorException innerException) : base(msg,innerException)
        {
            
        }
        public CalculationOperationNotSupportedException(string operation , string msg) : base(msg)
        {
            Operation = operation ; 
        }

        public override string Message
        {
            get
            {
                string msg = base.Message ;

                if (Operation != null)
                {
                    return msg + Environment.NewLine +$"Unsupported Operation ({Operation})" ;
                }

                return msg ;
            }
        }
    }
}