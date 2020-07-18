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
            if (map == null)
            {
                return new Dictionary<char, char>();
            }

            string[] mapItems = map.Split(
                new[] { Environment.NewLine },
                StringSplitOptions.None
            );

            var mapDictionary = new Dictionary<char, char>();

            foreach (var mapItem in mapItems)
            {
                if (mapItem.Length != 3)
                {
                    continue;
                }
                var mapPair = mapItem.Split("=".ToCharArray());
                var mapKeyChar = mapPair[0][0];
                var mapValueChar = mapPair[1][0];
                mapDictionary.Add(mapKeyChar, mapValueChar);
            }
            return mapDictionary;
        }

        public string EncryptMessage(string message, Dictionary<char, char> map)
        {

            if (message == null || map == null)
            {
                return string.Empty;
            }

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
            if (File.Exists(messageFileName) == false || File.Exists(mapFileName) == false)
            {
                return;
            }

            var message = File.ReadAllText(messageFileName);

            var map = File.ReadAllText(mapFileName);

            var mapDictionary = this.GetMap(map);

            var encryptedMessage = this.EncryptMessage(message, mapDictionary);

            File.WriteAllText(outputFileName, encryptedMessage);
        }

        public string DecryptMessage(string encryptedMessage, Dictionary<char, char> map)
        {

            if (encryptedMessage == null || map == null)
            {
                return string.Empty;
            }

            var decryptedMessage = string.Empty;

            foreach (char c in encryptedMessage)
            {
                if (map.ContainsKey(c))
                {
                    decryptedMessage += map[c];
                }
                else
                {
                    decryptedMessage += c;
                }
            }

            return decryptedMessage;
        }

    }
}