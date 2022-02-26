using System;

namespace Lesson6_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Hello();

            //Task 2
            string name = Console.ReadLine();
            Hello(name);

            //Task 3
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Sum(a, b);

            //Task 4
            string text = "dasd adas ";
            SpaceCount(text);

            //Task 5

            int[] arr = { 15, 4566, 5, 4, 657 };
            ArrSum(arr);

            //Task 6
            int num1 = 34;
            int num2 = 455;
            FirstSecond(num1, num2);


            //Task 7
            int numb1 = int.Parse(Console.ReadLine());
            int numb2 = int.Parse(Console.ReadLine());
            double res = Raising(numb1, numb2);

            //Task 8 

            int length = int.Parse(Console.ReadLine());
            FibSequence(length);

            //Task 9
            int primeNum = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(primeNum));

            //Task 10
            int number = int.Parse(Console.ReadLine());
            SumofDigits(number);

            //Task 11
            int numb = int.Parse(Console.ReadLine());
            int fact = Factorial(numb);

            // Task 12
            int fibonacci = int.Parse(Console.ReadLine());
            Fibonacci(fibonacci);

            //Method in Method
            int c = int.Parse(Console.ReadLine());
            Fibonacci(Factorial(c));

            //Array with Method
            int[] array = { Factorial(45),Factorial(12),Factorial(79)};
        }

        //Task 1 method

        public static void Hello()
        {
            Console.WriteLine("Hello friends!" + '\n' + "Have a nice day!");
        }

        //Task 2 Method

        public static void Hello(string name)
        {
            Console.WriteLine($"Hello friend {name}!" + '\n' + "Have a nice day!");
        }

        //Task 3 Method

        public static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        //Task 4 Method

        public static void SpaceCount(string text)
        {
            int count = 0;
          char[] str = text.ToCharArray() ;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;  
                }
            }
            Console.WriteLine(count);
        }

        //Task 5 Method

        public static void ArrSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }

        //Task 6 Method

        public static void FirstSecond(int a,int b)
        {
            Console.WriteLine($"First number is{a},second number is {b}");
        }

        //Task 7 Method

        public static double Raising(int a, int b)
        {
            return Math.Pow(a,b);
        }

        //Task 8 Method

        public static void FibSequence(int length)
        {
            int[] fib = new int[length];
            fib[0] = 1;
            fib[1] = 1;
            for (int i = 2; i < fib.Length; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
            }
            foreach (var item in fib)
            {
                Console.WriteLine(item);
            }
        }

        //Task 9 Method

        public static bool IsPrime(int num)
        {
            int count = 0;
            for (int i = 1; i < num; i++)
            {
                if (num%i==0)
                {
                    count++;
                }
            }
            if (count==1)
            {
                return true;
            }

            return false;
        }
        //Task 10 Method

        public static void SumofDigits(int a)
        {
            string aStr = a.ToString();
            int sum = 0;
            for (int i = 0; i < aStr.Length; i++)
            {
                sum += int.Parse(aStr.Substring(i, 1));
            }
            Console.WriteLine(sum);
        }
        //Task 11 Method
        public static int Factorial(int a)
        {
            int fact = 1;
            for (int i = 1; i <= a; i++)
            {
                fact *= i; 
            }
            return fact;
        }
        //Task 12 Method

        public static void Fibonacci(int length)
        {
            int[] fib = new int[length];
            fib[0] = 1;
            fib[1] = 1;
            for (int i = 2; i < fib.Length; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
            }
            Console.WriteLine(fib[fib.Length-1]);
        }
    }
}

