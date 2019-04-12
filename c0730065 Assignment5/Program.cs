using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Assignment_5

{

    //Parminder kaur bhangu

    //c0730065

    class Program

    {
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine("the longest word is : ");
            Console.WriteLine(a.MyFunctionA("Analaytical Lovelace wrote the first algorithm designed for processing by an Analytical Engine."));
        }


        public String MyFunctionA(string input)
        {

            string[] words = input.Split(' ');
            int wordarrayLength = words.Length;
            String longestword = words[0];
            int[] wordsLength = new int[words.Length]; 
            for (int s = 0; s < words.Length; s++)
            {
                wordsLength[s] = words[s].Length;
            }


            string currentWord = words[0];
            string nextWord;

            for (int y = 0; y < words.Length - 1; y++)
            {
                currentWord = words[y];

                nextWord = words[y + 1];
                if (words[y + 1].Equals(words[y]))
                {
                    longestword = words[y + 1];
                }


            }
            return longestword;

        }


    }
}



        







           