using System;
using lib;


namespace subcipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var subcipher = new Subcipher();

            if (args.Length != 4)
            {
                System.Console.WriteLine("");
                return;
            }

            if (args[0] == "encrypt")
            {
                subcipher.EncryptMessageFiles(args[1], args[2], args[3]);
            }



        }
    }
}
