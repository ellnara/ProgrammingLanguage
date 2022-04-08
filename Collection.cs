using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace ConsoleApp1
{
    class Collection<T> where T:ProgrammingLanguage
    {
        public T[] ProgramLanguages;
        public Collection()
        {
            ProgramLanguages = new T[0];
        }
        public void AddLanguage(T language)
        {
            Array.Resize(ref ProgramLanguages, ProgramLanguages.Length + 1);
            ProgramLanguages[^1] = language;
        }
        public void SortName()
        {
            for (int i = 0; i < ProgramLanguages.Length; i++)
            {
                for (int j = i+1; j < ProgramLanguages.Length; j++)
                {
                    Array.Sort(ProgramLanguages, (x, y) => String.Compare(x.Name, y.Name));
                }
            }
        }
        public void SortYear()
        {
            int temp=0;
            for (int i = 0; i < ProgramLanguages.Length; i++)
            {
                for (int j = i + 1; j < ProgramLanguages.Length; j++)
                {
                    if (ProgramLanguages[i].Year>ProgramLanguages[j].Year)
                    {
                        temp = ProgramLanguages[i].Year;
                        ProgramLanguages[i].Year = ProgramLanguages[j].Year;
                        ProgramLanguages[j].Year=temp;
                    }
                }
            }
        }
        public void ShowInfo()
        {
            foreach (var item in ProgramLanguages)
            {
                Console.WriteLine($"Programlama dilinin adi : {item.Name}\nYarandigi il: {item.Year}");
            }
        }
    }
    
}
