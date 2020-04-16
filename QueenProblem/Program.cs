using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueenProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 0,0,0,0,0,0},
                            { 0,0,0,0,0,0},
                            { 0,0,0,0,0,0},
                            { 0,0,0,0,0,0},
                            { 0,0,0,0,0,0},
                            { 0,0,0,0,0,0}
            };

            //int[] firstArray = { 2, 4, 6, 1, 3, 5 }; //True

            //int[] firstArray = { 3, 4, 2, 1, 6, 5 }; //False

            //int[] firstArray = { 3, 5, 2, 3, 1, 5 };  //False

            int[] firstArray = { 4, 3, 6, 5, 2, 1 }; // False

            for (int index = 0; index <= firstArray.Length -1 ; index++)
            {
                //Console.WriteLine(index);
                array[firstArray[index] - 1, index] = 1;
            }

            for (int row = 0; row <= firstArray.Length - 1; row++)
            {
                Console.Write(row);
                for (int col = firstArray.Length - 1; col >= 0 ; col--)
                {
                    Console.Write(array[row, col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(Check_If_No_Queen_Is_Present_On_Same_Row_And_Column(array));

            Console.WriteLine(Check_If_No_Queen_Is_Present_On_Diagnol(array));

            Console.ReadKey();

            /*int[] secondArray = { 3, 4, 2, 1, 6, 5 }; //False

            int[] thirdArray = { 3, 5, 2, 3, 1, 5 };  //False

            Console.WriteLine(Check_If_No_Queen_Is_Present_On_Same_Row_Or_Position(firstArray));
            Console.WriteLine(Check_If_No_Queen_Is_Present_On_Same_Row_Or_Position(secondArray));
            Console.WriteLine(Check_If_No_Queen_Is_Present_On_Same_Row_Or_Position(thirdArray));
            Console.ReadKey();*/
        }

        static bool Check_If_No_Queen_Is_Present_On_Diagnol(int[,] array)
        {
            var returnResult = false;
            for (int row = 0; row <= 4; row++)
            {
                Console.Write("r:" + row);
                int sameRowCount = 0;
                for (int col = row; col <= 4; col++)
                {
                    Console.Write("c:" + col);
                    if (array[row, col] == 1 || array[row + 1, col + 1] == 1)
                    {
                        sameRowCount++;
                    }
                    Console.WriteLine();
                }
                if (sameRowCount > 1)
                {
                    returnResult = false;
                    break;
                }
                else
                {
                    returnResult = true;
                }
            }
            return returnResult;
        }

        static bool Check_If_No_Queen_Is_Present_On_Same_Row_And_Column(int[,] array)
        {
            var returnResult = false;
            for (int row = 0; row <= 5; row++)
            {
                int sameRowCount = 0;
                for (int col = 0; col <= 5; col++)
                {
                    if(array[row, col] == 1)
                    {
                        sameRowCount++;
                    }
                }
                if (sameRowCount > 1)
                {
                    returnResult = false;
                    break;
                }
                else
                {
                    returnResult = true;
                }
            }
            return returnResult;
        }

        static bool Check_If_No_Queen_Is_Present_On_Same_Row_Or_Position(int[] array)
        {
            var returnResult = false;
            for (int row = 0; row <= array.Length - 1; row++)
            {
                for (int col = row; col <= array.Length - 1; col++)
                {
                    if (Math.Abs(array[row + 1] - array[row]) == 1 || (array[row] - array[col]) == 0)
                    {
                        returnResult = false;
                    }
                    else
                    {
                        returnResult = true;
                    }
                }
            }
            
            return returnResult;
        }
    }
}
