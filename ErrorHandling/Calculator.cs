using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
   public class Calculator
    {  
        public int Calculate(int numbaer1,int number2,string operation)
        {
            string nonNullOperation = operation ?? throw new ArgumentNullException(nameof(operation));
            //if (operation is null)
            //{
            //    throw new ArgumentNullException(nameof(operation  ));
            //}
            if (nonNullOperation =="/")
            {
                try
                {
                    return Devide(numbaer1, number2);
                }

                //catch (DivideByZeroException ex)
                catch(ArithmeticException ex)
                {
                    //rethrowing the exception
                    //throw ;
                    //wraping the exception =>make new instance from another class 
                    //throw new ArithmeticException("error accurred during caculation. ",ex);
                    throw new CaculationException(ex);
                }
            }
            else
            {
                //Console.WriteLine("Unknown Operation. ");
                //return 0;

                //throw new ArgumentOutOfRangeException(nameof(operation),
                //    "the mathimatical operation is not supported");

                throw new CalculationOperationNotSupportedException(operation);

            }
        }

        private int Devide(int number,int devisor)
        {
            return number / devisor;
        }
    }
}
