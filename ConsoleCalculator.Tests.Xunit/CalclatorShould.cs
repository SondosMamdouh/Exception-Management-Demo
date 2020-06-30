using ErrorHandling;
using Xunit;

namespace ConsoleCalculator.Tests.Xunit
{
    public class CalclatorShould
    {
        [Fact]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();

                Assert.Throws<CalculationOperationNotSupportedException>(
                    ()=>sut.Calculate(1,1,"*"));
            
        }
    }
}
