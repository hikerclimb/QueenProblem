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
            //6 by 6 array
            int[,] array = { { 0,0,0,0,0,0},
                            { 0,0,0,0,0,0},
                            { 0,0,0,0,0,0},
                            { 0,0,0,0,0,0},
                            { 0,0,0,0,0,0},
                            { 0,0,0,0,0,0}
            };

            //various cases I tested called firstArray

            //int[] firstArray = { 2, 4, 6, 1, 3, 5 }; //True

            //int[] firstArray = { 3, 4, 2, 1, 6, 5 }; //False

            //int[] firstArray = { 3, 5, 2, 3, 1, 5 };  //False

            //int[] firstArray = { 4, 3, 6, 5, 2, 1 }; // False

            int[] firstArray = { 1, 1, 1, 1, 1, 1 }; // False

            Console.WriteLine(RunFunction(array, firstArray));
            Console.ReadKey();
        }

        //run the following program
        static bool RunFunction(int[,] array, int[] firstArray)
        {

            for (int index = 0; index <= firstArray.Length - 1; index++)
            {
                //Console.WriteLine(index);
                array[firstArray[index] - 1, index] = 1;
            }

            for (int row = 0; row <= firstArray.Length - 1; row++)
            {
                //Console.Write(row);
                for (int col = 0; col <= firstArray.Length - 1; col++)
                {
                    //Console.Write(array[row, col] + " ");
                }
                //Console.WriteLine();
            }

            var rowCheck = Check_If_No_Queen_Is_Present_On_Same_Row(array);

            var RightDiagnolCheck = Check_If_No_Queen_Is_Present_On_RightAngled_Diagnol(array);

            var LeftDiagnolCheck = Check_If_No_Queen_Is_Present_On_LeftAngled_Diagnol(array);

            return rowCheck && RightDiagnolCheck && LeftDiagnolCheck;
        }

        static bool Check_If_No_Queen_Is_Present_On_RightAngled_Diagnol(int[,] array)
        {
            var returnResult = false;
            for (int row = 0; row <= 4; row++)
            {
                //Console.Write("r:" + row);
                int sameRowCount = 0;
                for (int col = row; col <= 4; col++)
                {
                    //Console.Write("c:" + col);
                    if (array[row, col] == 1 || array[row + 1, col + 1] == 1)
                    {
                        sameRowCount++;
                    }
                    //Console.WriteLine();
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

        static bool Check_If_No_Queen_Is_Present_On_LeftAngled_Diagnol(int[,] array)
        {
            var returnResult = false;
            for (int row = 4; row >= 0; row--)
            {
                //Console.Write("r:" + row);
                int sameRowCount = 0;
                for (int col = row; col >= 1; col--)
                {
                    //Console.Write("c:" + col);
                    if (array[row, col] == 1 || array[row - 1, col - 1] == 1)
                    {
                        sameRowCount++;
                    }
                    //Console.WriteLine();
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

        static bool Check_If_No_Queen_Is_Present_On_Same_Row(int[,] array)
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
    }
}
