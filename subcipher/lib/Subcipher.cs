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

                var mapKey = mapPair[0];
                var mapKey1 = mapPair[0][0];
                var mapValue = mapPair[1];
                var mapValue1 = mapPair[1][0];

                if (mapPair.Length == 2)
                {
                    mapDictionary.Add(mapKey1, mapValue1);
                }


                if (mapPair.Length < 2)
                {
                    mapDictionary.Add(mapKey1, mapKey1);
                }
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

        public void EncryptMessageFiles(string messageFileName, string mapFileName, string outputFileName)
        {
            //read message file
            var message = File.ReadAllText(messageFileName);

            //read map file
            var map = File.ReadAllText(mapFileName);

            //run map file through get map
            var mapDictionary = this.GetMap(map);

            //run dictionary and message through encrypt message
            var encryptedMessage = this.EncryptMessage(message, mapDictionary);

            //make output file
            File.WriteAllText(outputFileName, encryptedMessage);
        }



    }
}