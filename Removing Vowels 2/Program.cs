using System;

namespace Removing_Vowels_2
{
    class Program
    {
        public static string Rev_Special_Chars(string str)
        {

            string[] chars = new string[] { "a", "e", "i", "o", "u" };

            for (int i = 0; i < chars.Length; i++)
            {
                if (str.Contains(chars[i]))
                {
                    str = str.Replace(chars[i], "");
                }
            }
            return str;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter some text ");

                string first_string = Console.ReadLine();
                string second_str = first_string;
                string third_str = Rev_Special_Chars(second_str);

                Console.WriteLine(third_str);

                Console.WriteLine("Would you like to enter more text? Y or N?");
                string user_choice = Console.ReadLine().ToLower();

                if (user_choice == "n")
                {
                    Console.WriteLine("Good bye!");
                    break;
                }
            }


        }
    }
}
