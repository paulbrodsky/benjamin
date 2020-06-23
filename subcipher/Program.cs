using System;
using System.Collections.Generic;

namespace subcipher
{
    class Program
    {
        private const string Format = "{0}";


        static void Main(string[] args)
        {




            var map = System.IO.File.ReadAllText(args[2]);

            var mapItems = map.Split("\r\n");

            var mapDictionary = new Dictionary<char, char>();

            foreach (var mapItem in mapItems)
            {
                var mapPair = mapItem.Split("=");

                mapDictionary.Add(mapPair[0][0], mapPair[1][0]);

                System.Console.WriteLine();
            }









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
