using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WordInPlural
{
    class WordInPlural
    {
        static void Main()
        {
            string words = Console.ReadLine();

            {

                if (words.EndsWith("y"))
                {
                    words = words.Remove(words.Length - 1);//To remove the final character, subtract one from the Length.
                    //One common use for Remove is to erase or delete the final character in a string, or erase the first character. 
                    Console.WriteLine(words + "ies");

                }
                else if (words.EndsWith(("o")) || words.EndsWith(("ch")) ||
                    words.EndsWith(("s")) ||
                    words.EndsWith(("sh")) ||
                    words.EndsWith(("x")) ||
                    words.EndsWith(("z")))
                {

                    Console.WriteLine(words + "es");
                }
                else
                {
                    Console.WriteLine(words + "s");

                }
            }

        }
    }

}
