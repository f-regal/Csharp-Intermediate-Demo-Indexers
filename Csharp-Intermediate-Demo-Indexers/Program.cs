using System;

namespace Csharp_Intermediate_Demo_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Mosh";

            Console.WriteLine(cookie["name"]);
        }
    }
}
