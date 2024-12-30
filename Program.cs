using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ASS_3_C_
{



    internal class Program

    {
        #region Q3
        static (int, int) Fourparamets(int num1, int num2, int num3, int num4)
        {

            int sum = num1 + num2;
            int sub = num3 - num4;
            return (sum, sub);


        }
        #endregion

        #region Q4



        static int Calacdigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        #endregion

        #region Q5

        static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region Q6
        static (int, int) MinMax(ref int[] Arr)
        {
            int min = 0;
            int max = 0;

            Arr = new int[] { 5, 8, 9, 7, 4 };

            for (int i = 1; i <= Arr.Length; i++)
            {
                if (Arr[i] < min)
                {
                    min = Arr[i];
                }

                if (Arr[i] > max)
                {
                    max = Arr[i];
                }
            }
            return (min, max);

        }
        #endregion

        #region Q7

        static long CalculateFactorial(int num)
        {
            long result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }


        #endregion

        #region Q8
        static string ChangeChar(string strin, int position, char newChar)
        {
            char[] charArray = strin.ToCharArray();
            charArray[position] = newChar;
            return new string(charArray);
        }
        #endregion



        #region Q9






        #endregion


        #region Q10
        static int CalculateSum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;

        }
        #endregion


        #region Q14

        static int FindSecondLargest(int[] nums)
        {
            
            int firstLargest, secondLargest;
            if (nums[0] > nums[1])
            {
                firstLargest = nums[0];
                secondLargest = nums[1];
            }
            else
            {
                firstLargest = nums[1];
                secondLargest = nums[0];
            }

            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] > firstLargest)
                {
                    secondLargest = firstLargest;
                    firstLargest = nums[i];
                }
                else if (nums[i] > secondLargest && nums[i] != firstLargest)
                {
                    secondLargest = nums[i];
                }
            }

            return secondLargest;
        }
        #endregion









        static void Main(string[] args)
        {

            //Q3
            //Console.WriteLine(  Fourparamets(2, 2, 5, 4) );

            //Q4
            //Console.WriteLine(Calacdigits(5));

            //Q5
            //Console.WriteLine(IsPrime(2));

            //Q6
            //int[] Numbers = { 1, 2, 5, 6 };
            //Console.WriteLine(MinMax(ref Numbers));

            //Q7
            //Console.WriteLine(CalculateFactorial(3));

            //Q8
            //Console.WriteLine(ChangeChar("Ahmed", 1, 'p'));

            //Q9
            //#region Q9
            //Console.Write("Enter the size of the identity matrix (n): ");
            //int n = int.Parse(Console.ReadLine());
            //
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //
            //        Console.Write(" 1 ");
            //    }
            //
            //    Console.WriteLine();
            //}
            //#endregion

            //--------------- 10

            //int[] numbers = { 34, 72, 13, 44}; 
            //
            //int sum = CalculateSum(numbers); 
            //Console.WriteLine(sum); 
            //
            //Console.ReadLine();


            // ---------> 12

            // Console.Write("Enter the size of the array: ");
            // int size = int.Parse(Console.ReadLine());
            //
            // int[] array = new int[size];
            //
            // for (int i = 0; i < size; i++)
            // {
            //     Console.Write($"Enter value for element [{i}]: ");
            //     array[i] = int.Parse(Console.ReadLine());
            // }
            //
            // for (int i = 0; i < array.Length; i++)
            // {
            //     int count = 1;
            //     if (array[i] != -1) 
            //     {
            //         for (int j = i + 1; j < array.Length; j++)
            //         {
            //             if (array[i] == array[j])
            //             {
            //                 count++;
            //                 array[j] = -1;  
            //             }
            //         }
            //         Console.WriteLine($"Element {array[i]} occurs {count} times.");
            //     }
            // }
            //
            // Console.ReadLine();



            // 13 >>>> 6 

            //---------------------  14

            // Console.Write("Enter the size of the array: ");
            // int size = int.Parse(Console.ReadLine());
            //
            // int[] array = new int[size];
            //
            // for (int i = 0; i < size; i++)
            // {
            //     Console.Write($"Enter value for element [{i}]: ");
            //     array[i] = int.Parse(Console.ReadLine());
            // }
            //
            // int secondLargest = FindSecondLargest(array);
            //
            // Console.WriteLine($"The second largest element in the array is: {secondLargest}");
            //
            // Console.ReadLine();

            //------------- 18

            // Console.Write("Enter the number of rows: ");
            // int rows = int.Parse(Console.ReadLine());
            //
            // Console.Write("Enter the number of columns: ");
            // int cols = int.Parse(Console.ReadLine());
            //
            // int[,] array1 = new int[rows, cols];
            // int[,] array2 = new int[rows, cols];
            //
            // for (int i = 0; i < rows; i++)
            // {
            //     for (int j = 0; j < cols; j++)
            //     {
            //         Console.Write($"Enter value for element [{i},{j}] in the first array: ");
            //         array1[i, j] = int.Parse(Console.ReadLine());
            //     }
            // }
            //
            // for (int i = 0; i < rows; i++)
            // {
            //     for (int j = 0; j < cols; j++)
            //     {
            //         array2[i, j] = array1[i, j];
            //     }
            // }
            //
            // Console.WriteLine("The elements of the second array are:");
            // for (int i = 0; i < rows; i++)
            // {
            //     for (int j = 0; j < cols; j++)
            //     {
            //         Console.Write(array2[i, j] + " ");
            //     }
            //     Console.WriteLine();
            // }
            //
            // Console.ReadLine();


            // --------- 19
           
               // Console.Write("Enter the size of the array: ");
               // int size = int.Parse(Console.ReadLine());
               //
               // int[] array = new int[size];
               //
               // for (int i = 0; i < size; i++)
               // {
               //     Console.Write($"Enter value for element [{i}]: ");
               //     array[i] = int.Parse(Console.ReadLine());
               // }
               //
               // Console.WriteLine("Array in reverse order:");
               // for (int i = size - 1; i >= 0; i--)
               // {
               //     Console.Write(array[i] + " ");
               // }
               //
               // Console.ReadLine();
            }
        }


    }






    





    


