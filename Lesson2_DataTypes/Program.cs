using System;

namespace Lesson2_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte byte_num = Convert.ToByte(Console.ReadLine());
            sbyte sbyte_num = sbyte.Parse(Console.ReadLine());
            int byte_sum = byte_num + byte_num;
            int byte_sub = byte_num - sbyte_num;
            int byte_mult = byte_num * sbyte_num;
            float byte_div = byte_num / sbyte_num;

            Console.WriteLine(byte_sum);
            Console.WriteLine(byte_sub);
            Console.WriteLine(byte_mult);
            Console.WriteLine(byte_div);

            short short_num = Convert.ToInt16(Console.ReadLine());
            ushort ushort_num = UInt16.Parse(Console.ReadLine());
            int short_sum = short_num + ushort_num;
            int short_sub = short_num - ushort_num;
            int short_mult = short_num * ushort_num;
            float short_div = short_num / ushort_num;


            Console.WriteLine(short_sub);
            Console.WriteLine(short_mult);
            Console.WriteLine(short_div);
            Console.WriteLine(short_sum);

            int int_num = Convert.ToInt32(Console.ReadLine());
            uint uint_num = uint.Parse(Console.ReadLine());
            long int_sum = int_num + uint_num;
            long int_sub = int_num - uint_num;
            long int_mult = int_num *uint_num;
            float int_div = int_num / uint_num;


            Console.WriteLine(int_sub);
            Console.WriteLine(int_mult);
            Console.WriteLine(int_div);
            Console.WriteLine(int_sum);

            long long_num1 = Convert.ToInt64(Console.ReadLine());
            long long_num2 = long.Parse(Console.ReadLine());
            long long_sum = long_num1 + long_num2;
            long long_sub = long_num1 - long_num2;
            long long_mult = long_num1 * long_num2;
            float long_div = long_num1 / long_num2;


            Console.WriteLine(long_sub);
            Console.WriteLine(long_mult);
            Console.WriteLine(long_div);
            Console.WriteLine(long_sum);


            float float_num1 = float.Parse(Console.ReadLine());
            float float_num2 = float.Parse(Console.ReadLine());
            float float_sum = float_num1 + float_num2;
            float float_sub = float_num1 - float_num2;
            float float_mult = float_num1 * float_num2;
            float float_div = float_num1 / float_num2;
             
            Console.WriteLine(float_sub);
            Console.WriteLine(float_mult);
            Console.WriteLine(float_div);
            Console.WriteLine(float_sum);


            double double_num1 = double.Parse(Console.ReadLine());
            double double_num2 = double.Parse(Console.ReadLine());
            double double_sum = double_num1 + double_num2;
            double double_sub = double_num1 - double_num2;
            double double_mult = double_num1 * double_num2;
            double double_div = double_num1 / double_num2;

            Console.WriteLine(double_sub);
            Console.WriteLine(double_mult);
            Console.WriteLine(double_div);
            Console.WriteLine(double_sum);

            decimal decimal_num1 = decimal.Parse(Console.ReadLine());
            decimal decimal_num2 = decimal.Parse(Console.ReadLine());
            decimal decimal_sum = decimal_num1 + decimal_num2;
            decimal decimal_sub = decimal_num1 - decimal_num2;
            decimal decimal_mult = decimal_num1 * decimal_num2;
            decimal decimal_div = decimal_num1 / decimal_num2;

            Console.WriteLine(decimal_sub);
            Console.WriteLine(decimal_mult);
            Console.WriteLine(decimal_div);
            Console.WriteLine(decimal_sum);

            bool trueFalse = Boolean.Parse(Console.ReadLine());
            Console.WriteLine(trueFalse);
            string boolString = trueFalse.ToString();

            char char_symb = 'd';
            string charString = char_symb.ToString();

            string str1 = Console.ReadLine().ToString();
            string str2 = Console.ReadLine().ToString();
            string str3 = str1 + str2;
            Console.WriteLine(str3);

        }
    }
}
