using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialRentalSysteem
{
    class LogicException : Exception
    {
        public string Exception { get; set; }

        public LogicException(string exception)
        {
            this.Exception = exception;
        }
    }
}
