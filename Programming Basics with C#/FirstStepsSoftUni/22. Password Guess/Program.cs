using System;

namespace _22._Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string correctPass = "s3cr3t!P@ssw0rd";
            string inputPass = Console.ReadLine();
            bool password = inputPass == correctPass;
            if (password)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
