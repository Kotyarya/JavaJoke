using System;
using System.Linq;

namespace JavaJoke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Java Bardzo!");

            using (var translator = new JavaVerboseTranslator())
            {
                string input = "HelloWorld";
                string javafied = translator.Translate(input);
                Console.WriteLine($"Oryginał: {input}");
                Console.WriteLine($"Java wersja: {javafied}");

                string test = "LoginService";
                Console.WriteLine($"LINQ rozszerzenie: {test.ToJava()}");
            }
        }
    }
}