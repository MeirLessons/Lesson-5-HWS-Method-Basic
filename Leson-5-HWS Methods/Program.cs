using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leson_5_HWS_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Qst 8:
            //int num = int.Parse(Console.ReadLine());
            PrintNumberName(3);
            PrintNumberName(4);

            //Qst 9:
            Console.WriteLine(PrintNumbers(int.Parse(Console.ReadLine())));

            //Qst 11:
            CheckIfNumberIsPrime(11);

            //Qst 12:
            int[] arrToCheckPrime = { 3, 6, 8, 11, 15, 21 };
            CheckArrayForPrimeNumbers(arrToCheckPrime);

            //Qst 13:
            int[] arrToCheckBigger1 = { 3, 6, 8, 11, 15, 21 };
            int[] arrToCheckBigger2 = { 5, 2, 6, 15, 222, 14 };
            int firstIsBigger = WhichArrayIsBigger(arrToCheckBigger1, arrToCheckBigger2);

            //Qst 14:
            int[,] createdMatrix = BuildRandomMatrix();
            CheckIfNumberExistInMatrix(createdMatrix, 15);

            //Qst 15:
            int[] myArray = { 3, 10, 1, 1, -1 };
            SortArray(myArray);

        }

        #region Qst 15

        private static void SortArray(int[] arrToSort)
        {
            int min, index = 0;
            for (int i = 0; i < arrToSort.Length - 1; i++)
            {
                min = arrToSort[i];//10
                for (int j = i + 1; j < arrToSort.Length; j++)
                {
                    if (arrToSort[j] < min)
                    {
                        min = arrToSort[j];//-1
                        index = j;
                    }
                }
                arrToSort[index] = arrToSort[i];
                arrToSort[i] = min;
            }
        }

        #endregion

        #region Qst 14

        public static int[,] BuildRandomMatrix()
        {
            int[,] matrix = new int[10, 10];
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(50);//567
                }
            }
            return matrix;
        }
       
        public static bool CheckIfNumberExistInMatrix(int[,] mtrx, int numToCheck)
        {
            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    if (mtrx[i, j] == numToCheck)
                        return true;
                }
            }
            return false;
        }

        #endregion

        #region Qst 13
        /// <summary>
        /// Check Which Array Is bigger
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns>int</returns>
        public static int WhichArrayIsBigger(int[] arr1, int[] arr2)
        {
            int sumOfArr1 = 0, sumOfArr2 = 0, currentNubmer;
            for (int i = 0; i < arr1.Length; i++)
            {
                currentNubmer = arr1[i];
                sumOfArr1 += currentNubmer;
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                currentNubmer = arr2[i];
                sumOfArr2 += currentNubmer;
            }

            return (sumOfArr1 > sumOfArr2 ? 1 : sumOfArr1 < sumOfArr2 ? -1 : 0);
        }

        #endregion

        #region Qst 12

        public static void CheckArrayForPrimeNumbers(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                bool isPrime = CheckIfNumberIsPrime(currentNumber);
                string primeOrNot = isPrime ? "Prime" : "Not Prime";
                Console.WriteLine($"Number {i} Is : {primeOrNot}");
            }
        }

        #endregion

        #region Qst 11

        public static bool CheckIfNumberIsPrime(int numToCheck)
        {
            int m = numToCheck / 2;

            for (int i = 2; i <= m; i++)
            {
                if (numToCheck % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region Qst 9
        private static bool PrintNumbers(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i);
            }

            return (number > 10);

        }

        #endregion

        #region Qst 8
        public static void PrintNumberName(int num)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
            }
        }

        #endregion

        public static string GetClientDetails()
        {
            if (DateTime.Now.Hour == 8)
                return "Yes";
            else if (DateTime.Now.Hour == 7)
                return "No";
            else
                return "";
        }

        public static void CalcAndPrint(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
            return;
            Console.WriteLine();
        }


    }
}
