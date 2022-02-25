using System;

namespace Lesson5_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 211
            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    count += arr[i];
                }
            }
            Console.WriteLine(count / arr.Length);

            //Task 214

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    count += arr[i];
                }
            }
            Console.WriteLine(count / arr.Length);

            //Task 215

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(sum);

            //Task 216

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int mult = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    mult *= arr[i];
                }
            }
            Console.WriteLine(mult);

            //Task 217

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int mult = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    mult *= arr[i] * arr[i];
                }
            }
            Console.WriteLine(mult);

            //Task 218

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 0)
                {
                    arr[i] *= -1;
                }
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(sum);

            //Task 219

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % k == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            //Task 220

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int positive = 0;
            int negative = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0)
                {
                    positive++;
                }
                else { negative++; }
            }
            Console.WriteLine(positive);
            Console.WriteLine(negative);

            //Task 221

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i >= a && i <= b)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(sum);

            //Task 222

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int mult = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i >= a && i < b)
                {
                    mult *= arr[i];
                }
            }
            Console.WriteLine(mult);

            //Task 223

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > a && i < b)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            //Task 224

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 0)
                {
                    arr[i] *= -1;
                }
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < k)
                {
                    sum += arr[i] * arr[i] * arr[i];
                }
            }
            Console.WriteLine(sum);


            //Task 225

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 0)
                {
                    arr[i] *= -1;
                }
            }

            int mult = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < t)
                {
                    mult *= arr[i];
                }
            }
            Console.WriteLine(mult);

            //Task 226

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 0)
                {
                    arr[i] *= -1;
                }
            }

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < k)
                {
                    count++;
                }
            }
            Console.WriteLine(count);


            //Task 227

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % k == 0)
                {
                    count += arr[i];
                }
            }
            Console.WriteLine(count / arr.Length);

            //Task 228

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % k == 0)
                {
                    count += arr[i];
                }
            }
            Console.WriteLine(count);

            //Task 229

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int mult = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] - i == 0)
                {
                    mult *= arr[i];
                }
            }
            Console.WriteLine(mult);

            //Task 231

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count += arr[i] * arr[i];
                }
            }
            Console.WriteLine(count);

            //Task 232

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] - i == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            //Task 233

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int mult = 1;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    mult *= arr[i];
                    sum += arr[i];
                }
            }
            Console.WriteLine(mult);
            Console.WriteLine(sum);

            //Task 234

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(sum / arrLength);

            //Task 236

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int mult = 1;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    mult *= arr[i];
                    count++;
                }
            }
            Console.WriteLine(mult);
            Console.WriteLine(count);

            //Task 237

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            //Task 238

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(sum / arrLength);

            //Task 240

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 7 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            //Task 241

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % k == 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(sum);

            //Task 242

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int mult = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    mult *= arr[i];
                }
            }
            Console.WriteLine(mult);

            //Task 243

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            //Task 244

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int mult = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 5 == 2)
                {
                    mult *= arr[i];
                }
            }
            Console.WriteLine(mult);

            //Task 245

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] + i % 3 == 0)
                {
                    sum += arr[i] * arr[i];
                }
            }
            Console.WriteLine(sum);

            //Task 246

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    if (i == j * j)
                    {
                        sum += arr[i];
                    }
                }
            }
            Console.WriteLine(sum / arrLength);

            //Task 248

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Pow(arr[i] + i, 2) % k == 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(sum);

            //Task 249

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] - i) * -1 > k)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            //Task 250

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int mult = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] * i % 3 == 2)
                {
                    mult *= arr[i] * arr[i];
                }
            }
            Console.WriteLine(mult);

            //Task 251

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }

            }
            Console.WriteLine(maxValue);

            //Task 252

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int minValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }

            }
            Console.WriteLine(minValue);

            //Task 253

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int minValue = arr[0];
            int maxValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }

            }
            Console.WriteLine(minValue + maxValue);


            //Task 254

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter {i} number of array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int minValue = arr[0];
            int maxValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }

            }
            Console.WriteLine(minValue * maxValue);

            //Task 255

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int j = 0; j < arrLength; j++)
            {
                Console.WriteLine($"Enter {j} number of array");
                arr[j] = int.Parse(Console.ReadLine());
            }

            int maxValue = arr[0];
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }

            }
            Console.WriteLine(maxValue + i);

            //Task 256

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int j = 0; j < arrLength; j++)
            {
                Console.WriteLine($"Enter {j} number of array");
                arr[j] = int.Parse(Console.ReadLine());
            }

            int minValue = arr[0];
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }

            }
            Console.WriteLine(minValue + i);

            //Task 257

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int j = 0; j < arrLength; j++)
            {
                Console.WriteLine($"Enter {j} number of array");
                arr[j] = int.Parse(Console.ReadLine());
            }

            int maxValue = arr[0];
            int maxNum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                    maxNum = i;
                }

            }
            Console.WriteLine(maxNum);

            //Task 258

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int j = 0; j < arrLength; j++)
            {
                Console.WriteLine($"Enter {j} number of array");
                arr[j] = int.Parse(Console.ReadLine());
            }

            int maxValue = arr[0];
            int maxNum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= maxValue)
                {
                    maxValue = arr[i];
                    maxNum = i;
                }

            }
            Console.WriteLine(maxNum);

            //Task 259

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int j = 0; j < arrLength; j++)
            {
                Console.WriteLine($"Enter {j} number of array");
                arr[j] = int.Parse(Console.ReadLine());
            }

            int minValue = arr[0];
            int minNum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                    minNum = i;
                }

            }
            Console.WriteLine(minNum);

            //Task 260

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int j = 0; j < arrLength; j++)
            {
                Console.WriteLine($"Enter {j} number of array");
                arr[j] = int.Parse(Console.ReadLine());
            }

            int minValue = arr[0];
            int minNum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= minValue)
                {
                    minValue = arr[i];
                    minNum = i;
                }

            }
            Console.WriteLine(minNum);

            //Task 261

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] X = new int[arrLength];
            int[] Y = new int[arrLength];


            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter  {i} number of X array");
                X[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter  {i} number of Y array");
                Y[i] = int.Parse(Console.ReadLine());
            }

            int sumX = 0;
            int sumY = 0;
            for (int i = 0; i < X.Length; i++)
            {
                sumX += X[i];
                sumY += Y[i];
            }
            Console.WriteLine((sumX / X.Length) * (sumY / Y.Length));

            //Task 263

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] X = new int[arrLength];
            int[] Y = new int[arrLength];


            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter  {i} number of X array");
                X[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter  {i} number of Y array");
                Y[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] > 0 || Y[i] > 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            //Task 264

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] X = new int[arrLength];
            int[] Y = new int[arrLength];


            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter  {i} number of X array");
                X[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter  {i} number of Y array");
                Y[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] < 0 || Y[i] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            //Task 265

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] X = new int[arrLength];
            int[] Y = new int[arrLength];


            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter  {i} number of X array");
                X[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter  {i} number of Y array");
                Y[i] = int.Parse(Console.ReadLine());
            }

            int xSum = 0;
            int yMult = 1;
            for (int i = 0; i < X.Length; i++)
            {
                xSum += X[i];
                yMult += Y[i];

            }
            Console.WriteLine(xSum / yMult);

            //Task 266

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] X = new int[arrLength];
            int[] Y = new int[arrLength];


            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter  {i} number of X array");
                X[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter  {i} number of Y array");
                Y[i] = int.Parse(Console.ReadLine());
            }

            int xSum = 0;
            int ySum = 1;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 != 0)
                {
                    xSum += X[i];
                }
                if (Y[i] % 2 == 0)
                {
                    ySum += Y[i];
                }


            }
            Console.WriteLine(xSum - ySum);

            //Task 267

            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] X = new int[arrLength];
            int[] Y = new int[arrLength];


            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"Enter  {i} number of X array");
                X[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter  {i} number of Y array");
                Y[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 7 == 0)
                {
                    sum += X[i];
                }
                if (Y[i] % 7 == 0)
                {
                    sum += Y[i];
                }
            }
            Console.WriteLine(sum);

            //Task 271

            char[] arr = { 'a', 'c', 'a', 'r' };
            int count = 0;
            foreach (var item in arr)
            {
                if (arr[item] == 'a')
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            //Task 272

            char[] arr = { 'a', 'c', 'a', 'r' };
            int n = int.Parse(Console.ReadLine());
            bool t = false;
            int count = 0;
            foreach (var item in arr)
            {
                if (arr[item] == 'b')
                {
                    count++;
                }
                if (count >= n / 2)
                {
                    t = true;
                }
            }
            Console.WriteLine(t);


            //Task 273

            char[] arr = { 'a', 'c', 'a', 'r' };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 's')
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);

            //Task 274

            char[] arr = { 'a', 'c', 'a', 'r' };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 'h')
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum / arr.Length);

            //Task 275

            char[] arr = { 'a', 'c', 'a', 'r' };
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 'k')
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            //Task 276

            char[] arr = { 'a', 'c', 'a', 'r' };
            bool t = false;
            int count = 0;
            foreach (var item in arr)
            {
                if (arr[item] == 'r')
                {
                    t = true;
                }

            }
            Console.WriteLine(t);

            //Task 277

            char[] arr = { 'a', 'c', 'a', 'r' };
            char[] arr2 = new char[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 'd')
                {
                    arr2[i] = arr[i];
                }
            }
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }

            //Task 278

            char[] arr = { 'a', 'c', 'a', 'r' };
            char[] arr2 = new char[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    arr2[i] = arr[i];
                }
            }
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }

            //Task 279

            char[] arr = { 'a', 'c', 'a', 'r' };
            char[] arr2 = new char[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 'k')
                {
                    arr2[i] = arr[i];
                }
            }
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }

            ////Task 280

            char[] arr = { 'a', 'c', 'a', 'r' };
            char[] arr2 = new char[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 'f')
                {
                    arr2[i] = arr[i];
                    arr2[++i] = 'f';
                }
            }
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }

        }
    }
}
