using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter random letters (Ex. abcd):");
            string input = Console.ReadLine();
            char[] array = input.ToCharArray();
            int count = 1;

            foreach (char c in input)
            {
                for (int i = 0; i < Array.IndexOf(array, c) + 1; i++)
                {
                    if (i == 0)
                    {
                        Console.Write(Char.ToUpper(c));
                    }
                    else
                    {
                        Console.Write(Char.ToLower(c));
                    }
                }

                count++;

                if (count <= input.Length)
                {
                    Console.Write("-");
                }
            }

            Console.Read();
        }
    }
}
