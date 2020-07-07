using System.Reflection;
using System.IO;
using System.Text;
using Xunit;
using lib;
using System.Collections.Generic;

namespace tests
{
    public class SubcipherTests
    {
        [Fact]
        public void TestGetMap()
        {
            var subcipher = new Subcipher();

            var map = "A=Z\r\nB=Y\r\nC=X";

            Dictionary<char, char> result = subcipher.GetMap(map);
            Assert.Equal(3, result.Keys.Count);

            Assert.True(result.ContainsKey('A'));
            Assert.Equal('Z', result['A']);

            Assert.True(result.ContainsKey('B'));
            Assert.Equal('Y', result['B']);

            Assert.True(result.ContainsKey('C'));
            Assert.Equal('X', result['C']);
        }

        [Fact]
        public void TestGetMapEmptyLine()
        {
            var subcipher = new Subcipher();

            var map = "A=Z\r\n\r\nB=Y\r\nC=X";

            Dictionary<char, char> result = subcipher.GetMap(map);
            Assert.Equal(3, result.Keys.Count);
        }

        [Fact]
        public void TestEncryptMessage()
        {
            var subcipher = new Subcipher();

            var message = "Stupid!";

            var map = new Dictionary<char, char>();
            map.Add('t', 'm');
            map.Add('u', 'a');
            map.Add('p', 'r');
            map.Add('i', 't');
            map.Add('d', 'y');

            var encryptedMessage = subcipher.EncryptMessage(message, map);

            Assert.Equal("Smarty!", encryptedMessage);
        }

        [Fact]
        public void TestEncryptMessageFile()
        {
            var mapFileName = "./TestMap.txt";
            var messageFileName = "./TestMessage.txt";
            var outputFileName = "./TestEncrypted.txt";

            using (var file = new StreamWriter(mapFileName))
            {
                file.Write("t=m\r\nu=a\r\np=r\r\ni=t\r\nd=y");
            }

            using (var file = new StreamWriter(messageFileName))
            {
                file.Write("Stupid!");
            }

            var subcipher = new Subcipher();
            subcipher.EncryptMessageFiles(messageFileName, mapFileName, outputFileName);

            Assert.True(File.Exists(outputFileName));

            using (var reader = new StreamReader(outputFileName))
            {
                Assert.Equal("Smarty!", reader.ReadToEnd());
            }
        }
    }
}
