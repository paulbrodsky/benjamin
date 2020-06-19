using System;

namespace subcipher
{
    class Program
    {
        private const string Format = "{0}";
       

        static void Main(string[] args)
        {
            if (args[0] == "encrypt"){
                    string text = System.IO.File.ReadAllText(args[1]);
                    System.Console.WriteLine(text);
                    
            } 
            else{
                System.Console.WriteLine("Message Not Found.");
            }
        }
    }
}
