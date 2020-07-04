// TOOLBOX
// VARIABLES
// ASSIGNMENT OPERATOR
// DATA STRUCTURES (STRINGS, ARRAY, CHAR, INTEGER)
// FUNCTIONS
// ARGUMENT
// LOOPS
// CONDITIONAL STATEMENT
// EQUALITY

using System;
using System.IO;
using System.Collections.Generic;

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

        public string EncryptMessage(string message, Dictionary<char, char> map)
        {
            var encryptedMessage = string.Empty;

            foreach (char c in message)
            {
                if (map.ContainsKey(c))
                {
                    encryptedMessage += map[c];
                }
                else
                {
                    encryptedMessage += c;
                }
            }

            return encryptedMessage;
        }
    }
}