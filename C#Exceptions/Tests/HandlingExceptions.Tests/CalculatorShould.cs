using System;
using Xunit;
using HandlingExceptions ;

namespace HandlingExceptions.Tests
{
    public class CalculatorShould
    {
        [Fact]
        public void ThrowWhenUnsupportedOperation()
        {
            var c = new Calculator() ;
            
            Assert.Throws<CalculationOperationNotSupportedException>( () => c.Calculate(1,1,"*") )   ;
        }

        [Fact]
        public void ThrowWhenCalculatorException()
        {
            var c = new Calculator() ;
            
            Assert.Throws<CalculatorException>( () => c.Calculate(1,1,"*") )   ;

        }
    }
}
