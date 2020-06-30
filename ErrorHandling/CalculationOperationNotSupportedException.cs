using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    public class CalculationOperationNotSupportedException:CaculationException
    {
        public string Operation { get; }

        public CalculationOperationNotSupportedException()
            : base("Specified operation was out of the range of Vailed value")
        {

        }

        public CalculationOperationNotSupportedException(string operation)
            :this()
        {
            Operation = operation; 
        }

        public CalculationOperationNotSupportedException(string message,Exception innerException)
            :base(message,innerException)
        {

        }


        public CalculationOperationNotSupportedException(string operation,string message)
            :base(message)
        {
            Operation = operation;
        }


        public override string Message
        {
            get
            {
                string message = base.Message;

                if (Operation !=null)
                {
                    return message + Environment.NewLine +
                        $"Unsupported operation: {Operation}";
                }
                return message;
            }
        }
    }
}
