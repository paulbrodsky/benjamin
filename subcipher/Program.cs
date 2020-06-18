using System;

namespace subcipher
{
    class Program
    {
        private const string Format = "{0}";
        private const string Path = @"C:\Users\b3nb0\Downloads\Encryption\Message.txt";

        static void Main(string[] args)
        {
            if (args[0] == "encrypt"){
                  string text = System.IO.File.ReadAllText(Path);
                  System.Console.WriteLine(Format, text);
            } 
            else{
                System.Console.WriteLine("it didn't work");
            }
        }
    }
}
