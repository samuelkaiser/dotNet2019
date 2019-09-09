using System;

namespace Week2Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DateTime today = new DateTime();
            Console.WriteLine(today);
            Console.WriteLine(DateTime.Now.ToString("MMMM"));
            Console.ReadLine();
            string year = DateTime.Now.ToString("YYYY");
            string month = DateTime.Now.ToString("MMMM");
        }
    }
}
