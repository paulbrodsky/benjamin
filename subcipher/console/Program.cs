using System;
using System.Collections.Generic;

namespace subcipher
{
    class Program
    {
        private const string Format = "{0}";


        static void Main(string[] args)
        {

            if (args[0] == "encrypt")
            {
                string Message = System.IO.File.ReadAllText(args[1]);
                var firstcharacter = Message[0];

                foreach (KeyValuePair<char, char> mapItem in mapDictionary)
                {
                    Message = Message.Replace(mapItem.Key, mapItem.Value);
                }

                System.Console.WriteLine(Message);

            }


            if (args[0] == "decrypt")
            {
                string Message = System.IO.File.ReadAllText(args[1]);
                var firstcharacter = Message[0];

                foreach (KeyValuePair<char, char> mapItem in mapDictionary)
                {
                    Message = Message.Replace(mapItem.Value, mapItem.Key);
                }

                System.Console.WriteLine(Message);

            }




        }
    }
}
