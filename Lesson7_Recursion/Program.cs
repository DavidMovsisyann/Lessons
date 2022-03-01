using System;

namespace Lesson7_Recursion
{
    class Program
    {
        //Task Enum
        enum ErrorList
        {
            Metadata_file_could_not_be_found,
            System_Out_Of_Range,
            StackOverFlow,
            Dot_Expected,
            Cannot_convert

        }
        static void Main(string[] args)
        {
            //Task 1 

            int fibNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < fibNum; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            //Task 2
            int errorNum = int.Parse(Console.ReadLine());
            switch (errorNum)
            {
                case 0:
                    Console.WriteLine(ErrorList.Metadata_file_could_not_be_found);
                    break;
                case 1:
                    Console.WriteLine(ErrorList.System_Out_Of_Range);
                    break;
                case 2:
                    Console.WriteLine(ErrorList.StackOverFlow);
                    break;
                case 3:
                    Console.WriteLine(ErrorList.Dot_Expected);
                    break;
                case 4:
                    Console.WriteLine(ErrorList.Cannot_convert);
                    break;
            }
            //Task 4

            int num = int.Parse(Console.ReadLine());
            MultTable(num, 1);

            //Task 5

            int n = int.Parse(Console.ReadLine());
            isPrime(n, 1);
        }

        //Task 1 Method
        public static int Fibonacci(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return Fibonacci(num - 2) + Fibonacci(num - 1);
        }   
        //Task 4 Method

        public static void MultTable(int num, int i)
        {
            if (i > 10)
            {
                return;
            }
            Console.WriteLine(num + " * " + i + " = " + num * i);
            MultTable(num, i+1);
        }
        //Task 5 Method ----->?????????

        public static void isPrime(int n,int i)
        {
            int count1 = 0;
            int count2 = 0;
            int t = n;
            if (i == t)
            {
                Console.WriteLine(count2);
            }
            if (n % i != 0)
            {
                count1++;
            }
            if (count1 == 1)
            {
                count2++;
            }
            else 
            {
                isPrime(n-1, i + 1);
            }
            
        }

    }
}
