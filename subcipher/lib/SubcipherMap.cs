using System;
using System.Collections.Generic;

namespace lib
{
    public class SubcipherMap
    {
        public Dictionary<char, char> GetMap(string[] args)
        {
            var map = System.IO.File.ReadAllText(args[2]);

            var mapItems = map.Split("\r\n".ToCharArray());

            var mapDictionary = new Dictionary<char, char>();

            foreach (var mapItem in mapItems)
            {
                var mapPair = mapItem.Split("=".ToCharArray());

                mapDictionary.Add(mapPair[0][0], mapPair[1][0]);

                System.Console.WriteLine();


            }

            return mapDictionary;
        }
    }
}
