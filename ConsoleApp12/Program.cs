namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> languages = new SortedList<int, string>();

            languages.Add(2001, "C#");
            languages.Add(1983, "C++");
            languages.Add(1995, "Java");
            languages.Add(1972, "C");
            languages.Add(1992, "Python");

            foreach (var item in languages)
            {
                Console.WriteLine("Praqramlasdirma dili:" + item.Value + "Yaranma tarixi:" + item.Key);
            }
        }
    }
}