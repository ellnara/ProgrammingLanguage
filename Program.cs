using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgrammingLanguage Csharp = new ProgrammingLanguage("C#", 2000);

            ProgrammingLanguage Cplusplus = new ProgrammingLanguage("C++", 1985);

            Collection<ProgrammingLanguage> Languages = new Collection<ProgrammingLanguage>();
            Languages.AddLanguage(Csharp);
            Languages.AddLanguage(Cplusplus);
            Languages.SortName();
            Languages.SortYear();
            Languages.ShowInfo();
        }
    }
}
