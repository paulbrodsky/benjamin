using System;
using System.Collections.Generic;

namespace subcipher
{
    class Program
    {
        private const string Format = "{0}";


        static void Main(string[] args)
        {

            try
            {
                string myString = "hello";

                System.Console.WriteLine(myString.Length);
                throw new Exception();
            }
            catch (System.NullReferenceException)
            {
                System.Console.WriteLine("caught a null reference exception");
            }
            catch (Exception exc)
            {

                System.Console.WriteLine("caught an exception");


            }


        }
    }
}
