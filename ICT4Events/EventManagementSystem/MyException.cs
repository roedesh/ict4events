using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    class MyException : Exception
    {
        public MyException()
            : base()
        {
        }

        public MyException(String message)
            : base(message)
        {
        }
    }
}
