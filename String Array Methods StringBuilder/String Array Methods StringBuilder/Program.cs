using System.Text;

namespace String_Array_Methods_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            //int[] numbers = {1,-2,3,4,-25,-6,55 };
            //if (Positive(numbers) != null)
            //{
            //    Positive(numbers);

            //    foreach (int i in numbers)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion
            #region Task2

            //string word = Console.ReadLine();
            //Palindrome(word);

            #endregion
            #region Task3

            //string word = "NNNahiidd";
            //RemoveRep(ref word);

            //Console.WriteLine(word);

            #endregion
            #region Task4

            //string text = Console.ReadLine();
            //SeperateWords(text);

            #endregion
            #region Task5

            //First4Letters("Messi");

            #endregion
            #region Task6

            //Console.WriteLine(Domain("test@code.edu.az"));

            #endregion
            #region Task7

            //Console.WriteLine(IsOnlyLetters("Messi_10"));

            #endregion
            #region Task8

            //Console.WriteLine(Capitalize("SALAM nECESEN, NEyiRSEN"));

            #endregion
            #region Task9

            //string[] fullNames = { "Nahid Mehdili", "Filankes Filankesov", "Lamine Yamal"};
            //string[] firstNames = FirstNames(fullNames);
            //foreach (var item in firstNames)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
        }
        public static int[] Positive(int[] arr) 
        {
            if (arr == null)
            {
                Console.WriteLine("Array evvelceden assign olmalidir");
                return null;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<0)
                {
                    arr[i] = -arr[i];
                }
            }

            return arr;
        }

        public static void Palindrome(string word)
        {
            StringBuilder reverse = new ();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse.Append(word[i]);
            }

            if (word == reverse.ToString())
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        public static string RemoveRep(ref string word) 
        {
            StringBuilder result = new();
            foreach (var letter in word)
            {
                if (result.ToString().IndexOf(letter) == -1)
                {
                    result.Append(letter);
                }
            }
            word = result.ToString();
            return word;
        }

        public static void SeperateWords(string text)
        {
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    Console.WriteLine(word);
                }
            }
        }

        public static void First4Letters(string word)
        {
            if(word.Length > 3)
                Console.WriteLine(word.Substring(0, 4));
            else
                Console.WriteLine("Verilmis stringde 4 herf yoxdur");
        }

        public static string Domain(string email)
        {
            int index = email.IndexOf('@');
            return email.Substring(index+1);
        }

        public static bool IsOnlyLetters(string word)
        {
            foreach (char letter in word)
            {
                if (!Char.IsLetter(letter))
                    return false;
            }
            return true;
        }

        public static string Capitalize(string text)
        {
            string start = text.Substring(0, 1).ToUpper();
            string rest = text.Substring(1).ToLower();

            return start + rest;
        }

        public static string[] FirstNames(string[] names)
        {
            string[] firstNames = new string[names.Length];

            for (int i = 0; i < names.Length; i++)
            {
                string[] parts = names[i].Split(' ');
                firstNames[i] = parts[0];
            }

            return firstNames;
        }


    }
}
