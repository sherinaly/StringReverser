using System;

namespace Reverser
{
    class ProgramTest
    {
        private static void Main(string[] args)
        {
            
                Console.Write("Input a string to reverse [or press ENTER to terminate]: ");
                try
                {    
                    var inputPhrase = Console.ReadLine();
                    while (inputPhrase.Length > 0)
                    {
                        var reversedString = StringReverser.ReverseWordOrderInThisString(inputPhrase);
                        Console.WriteLine("Output String: " + reversedString);
                        Console.Write("Input a string to reverse  [or press ENTER to terminate]: ");
                        inputPhrase = Console.ReadLine();
                    }
                }            
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
           
        }
    }
}