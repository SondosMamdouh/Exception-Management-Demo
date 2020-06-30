using ErrorHandling;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator.Tests.Nunit
{
    public class CalculatorShould
    {
        [Test]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();

            Assert.That(() => sut.Calculate(1, 1, "+"),
                Throws.TypeOf<CalculationOperationNotSupportedException>());
        }
    }
}
