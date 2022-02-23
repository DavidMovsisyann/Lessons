using System;

namespace Lesson4_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 151
            //int n = int.Parse(Console.ReadLine() );
            //int sum = 0;
            //for (int i = 0;i<100000; i++)
            //{
            //    if (i%n==0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);

            //Task 152

            //int n = int.Parse(Console.ReadLine());
            //int mult = 1;
            //for (int i = 1; i < 1000; i++)
            //{
            //    if (i % n == 0)
            //    {
            //        mult *= i;
            //    }
            //}
            //Console.WriteLine(sum);

            //Task 153 ---->??????

            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i < 1000; i++)
            //{
            //    if (i % n == 2)
            //    {
            //        sum += i; 
            //    }
            //}
            //Console.WriteLine(sum);

            //Task 154

            //int n = int.Parse(Console.ReadLine());
            //int mult = 1;
            //for (int i = 1; i < 1000; i++)
            //{
            //    if (i % n == 3)
            //    {
            //        mult *= i;
            //    }
            //}
            //Console.WriteLine(sum);

            //Task 155
            //int sum = 0;

            //for (int i = 10; i <100 ; i++)
            //{
            //    if(i%3==0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);

            //Task 156

            //int mult = 1;

            //for (int i = 10; i < 100; i++)
            //{
            //    if (i%3==0 && i%5==0)
            //    {
            //        mult *= i;
            //    }
            //}
            //Console.WriteLine(mult);

            //Task 157

            //int sum = 0;

            //for (int i = 100; i < 1000; i++)
            //{
            //    if (i%5 != 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);

            //Task 158

            //int mult = 1;

            //for (int i = 100; i < 1000; i++)
            //{
            //    if (i % 2 != 0 && i % 3 != 0)
            //    {
            //        mult *= i;
            //    }
            //}
            //Console.WriteLine(mult);

            //Task 159

            //int mult = 1;

            //for (int i = 100; i < 1000; i++)
            //{
            //    if (i % 3 != 1 && i % 4 != 2)
            //    {
            //        mult *= i;
            //    }
            //}
            //Console.WriteLine(mult);

            //Task 160
            //int res = 0;

            //for (int j = 1; j < 1000000; j++)
            //{
            //    for (int i = 100; i < 1000; i++)
            //    {
            //        if (i * 16 == j * j)
            //        {
            //            res = i;
            //            break;
            //        }
            //    }
            //    if (res > 0)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine(res);

            //Task 161

            //int res = 0;

            //for (int j = 1; j < 1000000; j++)
            //{
            //    for (int i = 1000; i < 10000; i++)
            //    {
            //        if (i * 26 == j * j)
            //        {
            //            res = i;
            //            break;
            //        }
            //    }
            //    if (res > 0)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine(res);

            //Task 162

            //int res = 0;

            //for (int j = 1; j < 1000000; j++)
            //{
            //    for (int i = 10000; i > 1000; --i)
            //    {
            //        if (i * 14 == j * j)
            //        {
            //            res = i;
            //            break;
            //        }
            //    }
            //    if (res > 0)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine(res);

            //Task 163

            //int res = 0;

            //for (int j = 1; j < 1000000; j++)
            //{
            //    for (int i = 10000; i > 1000; i--)
            //    {
            //        if (i * 18 == j * j)
            //        {
            //            res = i;
            //            break;
            //        }
            //    }
            //    if (res > 0)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine(res);

            //Task 164

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 100; i < 1000; i++)
            //{
            //    if (Math.Sqrt(i)==n)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}



            //Task 165

            //int n = int.Parse(Console.ReadLine());
            //int mult = 1;
            //bool t = false;
            //for (int i = 0; i < 1000; i++)
            //{
            //    mult *= 3;
            //    if (n == mult)
            //    {
            //        t = true;
            //    }

            //}
            //Console.WriteLine(t);

            //Task 166

            //int n = int.Parse(Console.ReadLine());
            //int mult = 1;
            //int y = 0;
            //for (int i = 0; i < 1000; i++)
            //{
            //    mult *= 4;
            //    if (n == mult)
            //    {
            //        y=1;
            //    }

            //}
            //Console.WriteLine(y);

            //Task 191

            //int n = int.Parse(Console.ReadLine());
            //int x = int.Parse(Console.ReadLine());

            //int mult = 1;
            //int sum = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    mult *= x;
            //    sum += mult;
            //}
            //Console.WriteLine(sum); 

            //Task 192

            //int n = int.Parse(Console.ReadLine());
            //int x = int.Parse(Console.ReadLine());

            //int mult = 1;
            //int sum = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    mult *= x;
            //    if (i % 2 == 0)
            //    {
            //        sum += mult;
            //    }
            //    else { sum -= mult; }
            //}
            //Console.WriteLine(sum);

            //Task 193

            //int n = int.Parse(Console.ReadLine());
            //int fact = 1;
            //int sum = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    if (i==1)
            //    {
            //        sum += i;
            //        continue;
            //    }
            //    for (int j = i; j > 0 ; j--)
            //    {
            //        fact *= j;
            //    }
            //    sum += fact;
            //    fact = 1;

            //}
            //Console.WriteLine(sum);

            //Task 198 -->?

            //int n = int.Parse(Console.ReadLine());
            //double x = double.Parse(Console.ReadLine());

            //double mult = 1;
            //double sum = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    mult *= x;
            //    if (i == 1)
            //    {
            //        sum +=x;
            //    }
            //    if (i % 2 == 0)
            //    {
            //        sum -= i/mult;
            //    }
            //    else { sum += mult; }
            //}
            //Console.WriteLine(sum);
        }
    }
}
