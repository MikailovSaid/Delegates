using System;

namespace Delegates
{
    class Program
    {
        public delegate bool Divide(int num);
        public delegate bool ChangeLetters(string str);
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(CheckNum, 21, 22, 42, 55));
            Console.WriteLine(FirstLetterToUpper(CheckName,"Said"));
            
        }
        
        public static bool CheckNum(int num)
        {
            return num % 21 == 0;
        }
        public static int Sum(Divide func, params int[] nums)
        {
            var sum = 0;
            foreach (var item in nums)
            {
                if (func(item))
                {
                    sum += item;
                }
            }

            return sum;
        }

        public static bool CheckName(string str)
        {
            return str.Length > 3;
        }
        public static string FirstLetterToUpper(ChangeLetters str, string name)
        {
            return name.ToUpper().Substring(0,1);

        }


    }
}