using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Extension
{
    public class InvalidAgeException : Exception
    {

        public InvalidAgeException()
        {
            
        }

        public InvalidAgeException(string message) : base(message)
        {
            
        }
        
    }
}
