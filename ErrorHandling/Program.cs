using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //global unhanled exceptions
            AppDomain appDomain = AppDomain.CurrentDomain;
            appDomain.UnhandledException +=new UnhandledExceptionEventHandler(HandleException);

            Console.WriteLine("Enter firist number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation");
            string operation =Console.ReadLine().ToUpperInvariant();


            var calculator = new Calculator();
            try
            {
                int result = calculator.Calculate(number1, number2, operation); //exception filiter
                Console.WriteLine(result);
            }
            //catch(ArgumentNullException ex) when(ex.ParamName=="operation")
            //{ 
            //    Console.WriteLine($"operation wasnt provided. {ex}");

            //}
            //catch(ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine($"operation wasnt supported. {ex}");
            //}

            catch(CalculationOperationNotSupportedException ex)
            {

                Console.WriteLine(ex);
            }

            catch (CaculationException ex)
            {

                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"\nsomthing get wrong. {ex}");

            }
            finally
            {
                Console.WriteLine("...finally. ");

            }



            Console.WriteLine("\nPress enter to exit. ");
            Console.ReadLine();
        }

        private static void HandleException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine($"Sorry ther was a problem we have to close. Details: {e.ExceptionObject}");
        }
    }
}
