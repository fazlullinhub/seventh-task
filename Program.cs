using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "I'm so fucked up by this bitch!!Someday i'll kill her!!!!";

            List<string> badWords = new List<string> { "fucked", "bitch", "kill" };

            int replacedCount = 0;

            foreach (string word in badWords)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                    replacedCount++;
                }
            }

            Console.WriteLine("Filtered text:" + text);
            Console.WriteLine("Total bad words replaced: " + replacedCount);
        }
    }
}
