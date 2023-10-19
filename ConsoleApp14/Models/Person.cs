using ConsoleApp14.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Models
{
    internal class Person
    {
        private sbyte _age;
        public string FullName { get; set; }
        public sbyte Age


        {
            get
            {
                return _age;
            }

            set
            {
                    if (value < 0 || value > 125)
                    {
                        throw new InvalidAgeException("yas 0 ile 125 arasinda olmalidir");
                    }

                    else
                    {
                        _age = value;
                    }
            }
        } }
}
