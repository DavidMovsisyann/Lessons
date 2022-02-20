using System;

namespace Lesson3_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //int num = int.Parse(Console.ReadLine());
            //int thousands = num / 1000 * 1000;
            //int houndreds = (num - thousands) / 100 * 100;
            //int dozens = (num - thousands - houndreds) / 10 * 10;
            //int points = num - thousands - houndreds - dozens;

            //Console.WriteLine($"{thousands} + {houndreds} + {dozens} + {points}");


            //Task 2
            //string first_name = Console.ReadLine();
            //string last_name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Hello,I'm {first_name} {last_name},I'm {age} years old ");
            //Console.WriteLine("Hello,I'm {0} {1},I'm {2} years old", first_name, last_name, age);

            //Task 3
            //string daysofWeek = Console.ReadLine();
            //int days_num = 0;
            //switch (daysofWeek)
            //{
            //    case "Monday":
            //        days_num = 1;
            //        break;

            //    case "Tuesday":
            //        days_num = 2;
            //        break;

            //    case "Wednesday":
            //        days_num = 3;
            //        break;

            //    case "Thursday":
            //        days_num = 4;
            //        break;

            //    case "Friday":
            //        days_num = 5;
            //        break;

            //    case "Saturday":
            //        days_num = 6;
            //        break;

            //    case "Sunday":
            //        days_num = 7;
            //        break;
            //}
            //Console.WriteLine(days_num);

            //Task 4 

            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int num3 = int.Parse(Console.ReadLine());
            //int num4 = int.Parse(Console.ReadLine());
            //int maxValue1;
            //int maxValue2;
            //int minValue1;
            //int minValue2;
            //int firstnum;
            //int secondnum;
            //int thirdnum;
            //int fourthnum;

            //if (num1 > num2)
            //{
            //    maxValue1 = num1;
            //    minValue1 = 2;
            //}
            //else { maxValue1 = num2; minValue1 = num1; }

            //if (num3 > num4)
            //{
            //    maxValue2 = num3;
            //    minValue2 = num4;
            //}
            //else { maxValue2 = num4;minValue2 = num3; }

            //if (maxValue1 > maxValue2)
            //{
            //    firstnum = maxValue1; secondnum = maxValue2;
            //}
            //else { firstnum = maxValue2;secondnum = maxValue1; }

            //if (minValue1 > minValue2)
            //{
            //    thirdnum = minValue1; fourthnum = minValue2;
            //}
            //else { thirdnum = minValue2;fourthnum = minValue1;  };

            //Console.WriteLine(firstnum);
            //Console.WriteLine(secondnum);
            //Console.WriteLine(thirdnum);
            //Console.WriteLine(fourthnum);

            //Task 21

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int maxValue;

            //if (a > b)
            //{
            //    maxValue = a;
            //}
            //else { maxValue = b; }
            //if (c > maxValue)
            //{ maxValue = c; }

            //Console.WriteLine( maxValue );

            //Task 22

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int minValue;

            //if (a > b)
            //{
            //    minValue = b;
            //}
            //else { minValue = a; }
            //if (c < minValue)
            //{ minValue = c; }

            //Console.WriteLine(minValue);

            //Taks 23

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a == 1)
            //{
            //    Console.WriteLine(true);
            //}
            //else if (b == 1)
            //{ Console.WriteLine(true); }
            //else if (c == 1)
            //{ Console.WriteLine(true); }
            //else
            //{ Console.WriteLine(false); }

            //Task 24

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a == 2 && b == 2)
            //{
            //    Console.WriteLine(true);
            //}
            //else if (a == 2 && c == 2)
            //{
            //    Console.WriteLine(true);
            //}
            //else if (c == 2 && b ==2)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            //Task 25 

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int y = 2;

            //if (a + b > c)
            //{
            //    y = 1;
            //}
            //else if (a + c > b)
            //{
            //    y = 1;
            //}
            //else if (b + c > a)
            //{
            //    y = 1;
            //}
            //Console.WriteLine(y);

            //Taks 26

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a % 2 == 0)
            //{
            //    Console.WriteLine("1");
            //}
            //else if (b % 2 == 0)
            //{
            //    Console.WriteLine("1");
            //}
            //else if (b % 2 == 0)
            //{ 
            //    Console.WriteLine("1");
            //}
            //else { Console.WriteLine("2"); }

            //Task 29

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int firstnum = 0;
            //int secondnum = 0;
            //int thirdnum = 0;

            //if (a > b)
            //{
            //    firstnum = a;
            //    secondnum = b;
            //}
            //else
            //{
            //    firstnum = b;
            //    secondnum = a;
            //}

            //if (c > firstnum)
            //{
            //    thirdnum = secondnum;
            //    secondnum = firstnum;
            //    firstnum = c;
            //}
            //else if (c > secondnum)
            //{
            //    thirdnum = secondnum;
            //    secondnum = c;
            //}
            //else { thirdnum = c; }

            //Console.WriteLine($"{thirdnum},{secondnum},{firstnum}");

            //Task 30

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int firstnum = 0;
            //int secondnum = 0;
            //int thirdnum = 0;

            //if (a > b)
            //{
            //    firstnum = a;
            //    secondnum = b;
            //}
            //else
            //{
            //    firstnum = b;
            //    secondnum = a;
            //}

            //if (c > firstnum)
            //{
            //    thirdnum = secondnum;
            //    secondnum = firstnum;
            //    firstnum = c;
            //}
            //else if (c > secondnum)
            //{
            //    thirdnum = secondnum;
            //    secondnum = c;
            //}
            //else { thirdnum = c; }

            //Console.WriteLine($"{firstnum},{secondnum},{thirdnum}" );


            //Task 51

            //bool t = false;
            //int num = int.Parse(Console.ReadLine());
            //int houndreds = num / 100;
            //int dozens = (num - houndreds * 100) / 10;
            //int points = num % 10;

            //if (points == houndreds + dozens)
            //{ t = true; }

            //Console.WriteLine(t);

            //Task 52

            //bool t = false;
            //int num = int.Parse(Console.ReadLine());
            //int houndreds = num / 100;
            //int dozens = (num - houndreds * 100) / 10;
            //int points = num % 10;

            //if (houndreds == dozens)
            //{ t = true; }
            //else if (dozens == points)
            //{ t = true; }
            //else if (houndreds == points)
            //{ t = true; }

            //Console.WriteLine(t);

            //Task 53

            //int num = int.Parse(Console.ReadLine());
            //int k = int.Parse(Console.ReadLine());
            //int houndreds = num / 100;
            //int dozens = (num - houndreds * 100) / 10;
            //int points = num % 10;
            //int res = houndreds + dozens + points;

            //if (num > k)
            //{
            //    Console.WriteLine(num / res);
            //}
            //else { Console.WriteLine(num/points); }

            //Task 54

            //int num = int.Parse(Console.ReadLine());
            //int houndreds = num / 100;
            //int dozens = (num - houndreds * 100) / 10;
            //int points = num % 10;
            //int maxValue;

            //if (houndreds> dozens)
            //{
            //    maxValue = houndreds;
            //}
            //else { maxValue = dozens; }
            //if (points > maxValue)
            //{ maxValue = points; }

            //Console.WriteLine( maxValue );

            //Task 55

            //int num = int.Parse(Console.ReadLine());
            //int houndreds = num / 100;
            //int dozens = (num - houndreds * 100) / 10;
            //int points = num % 10;
            //int minValue;

            //if (houndreds < dozens)
            //{
            //    minValue = houndreds;
            //}
            //else { minValue = dozens; }
            //if (points < minValue)
            //{ minValue = points; }

            //Console.WriteLine(minValue);

            //Task 56

            //int num = int.Parse(Console.ReadLine());
            //int houndreds = num / 100;
            //int dozens = (num - houndreds * 100) / 10;
            //int points = num % 10;
            //int res = houndreds + points + dozens;

            //if (points > dozens)
            //{
            //    Console.WriteLine(res / num);
            //}
            //else { Console.WriteLine(num); }

            //Task 57

            //int num = int.Parse(Console.ReadLine());
            //int houndreds = num / 100;
            //int dozens = (num - houndreds * 100) / 10;
            //int points = num % 10;

            //if (num > 300)
            //{ Console.WriteLine(dozens / points); }
            //else { Console.WriteLine(houndreds/points); }

            //Task 58

            //int num = int.Parse(Console.ReadLine());
            //int houndreds = num / 100;
            //int dozens = (num - houndreds * 100) / 10;
            //int points = num % 10;
            //char f;

            //if (dozens + houndreds < 5)
            //{
            //    f = 'a';
            //}
            //else { f = 'b'; }
            //Console.WriteLine(f);

            //Task 59

            //int num = int.Parse(Console.ReadLine());
            //int houndreds = num / 100;
            //int dozens = (num - houndreds * 100) / 10;
            //int points = num % 10;


            //int firstnum = 0;
            //int secondnum = 0;
            //int thirdnum = 0;

            //if (houndreds > dozens)
            //{
            //    firstnum = houndreds;
            //    secondnum = dozens;
            //}
            //else
            //{
            //    firstnum = dozens;
            //    secondnum = houndreds;
            //}

            //if (points > firstnum)
            //{
            //    thirdnum = secondnum;
            //    secondnum = firstnum;
            //    firstnum = points;
            //}
            //else if (points > secondnum)
            //{
            //    thirdnum = secondnum;
            //    secondnum = points;
            //}
            //else { thirdnum = points; }

            //Console.WriteLine($"{firstnum},{secondnum},{thirdnum}");

            //Task 60

            //int num = int.Parse(Console.ReadLine());
            //int houndreds = num / 100;
            //int dozens = (num - houndreds * 100) / 10;
            //int points = num % 10;


            //int firstnum = 0;
            //int secondnum = 0;
            //int thirdnum = 0;

            //if (houndreds > dozens)
            //{
            //    firstnum = houndreds;
            //    secondnum = dozens;
            //}
            //else
            //{
            //    firstnum = dozens;
            //    secondnum = houndreds;
            //}

            //if (points > firstnum)
            //{
            //    thirdnum = secondnum;
            //    secondnum = firstnum;
            //    firstnum = points;
            //}
            //else if (points > secondnum)
            //{
            //    thirdnum = secondnum;
            //    secondnum = points;
            //}
            //else { thirdnum = points; }

            //Console.WriteLine($"{thirdnum},{secondnum},{firstnum}");

           


        }
    }
}
