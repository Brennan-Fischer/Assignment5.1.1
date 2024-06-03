using System.Security.Cryptography.X509Certificates;

namespace Assignment5._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer to determine if it is a palindrome");
            string userInput = Console.ReadLine();
            testPalindrome(userInput);


            static bool testPalindrome(string userInput)
            {
                for (int i = 0; i < userInput.Length / 2; i++)
                {
                    if (userInput[i] != userInput[userInput.Length - 1 - i])
                    {
                        Console.WriteLine("false, not a palidrome");
                        return false;
                    }
                }
                Console.WriteLine("True, a palindrome");
                return true;


            }
        }
    }
}
