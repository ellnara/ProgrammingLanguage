using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ProgrammingLanguage
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public ProgrammingLanguage(string name, int year)
        {
            Name = name;
            Year = year;
        }
    }
}
