using System;
using System.Collections.Generic;
using System.Text;

namespace lib
{
    public class Subcipher
    {
        public Dictionary<char, char> GetMap(string map)
        {
            string[] mapItems = map.Split(
                new[] { Environment.NewLine },
                StringSplitOptions.None
            );
            var mapDictionary = new Dictionary<char, char>();

            foreach (var mapItem in mapItems)
            {
                var mapPair = mapItem.Split("=".ToCharArray());
                mapDictionary.Add(mapPair[0][0], mapPair[1][0]);
            }

            return mapDictionary;
        }
    }
}
