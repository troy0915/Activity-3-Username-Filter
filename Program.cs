using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_3Username_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = new List<string>();
            Console.WriteLine("Enter 5 usernames:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Username {i + 1}: ");
                string username = Console.ReadLine();
                usernames.Add(username);
            }
            Console.Write("Enter a character to search for in the usernames: ");
            char searchChar = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line
            Console.WriteLine("\nUser names containing the character '{0}':", searchChar);
            bool found = false;

            foreach (var username in usernames)
            {
                if (username.ToLower().Contains(searchChar.ToString().ToLower()))
                {
                    Console.WriteLine(username);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No usernames contain the character '{0}'.", searchChar);
            }
        }
    }
}
    

