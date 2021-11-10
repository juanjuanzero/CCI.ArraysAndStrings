using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrringsProblems.Problem8
{
    public static class Problem8Solution
    {
        public static List<List<int>> ZeroMatrix(List<List<int>> matrix)
        {
            bool[] zeroRows = new bool[matrix.Count];
            bool[] zeroCols = new bool[matrix[0].Count];

            //loop through the rows of each array
            for (int row = 0; row < matrix.Count; row++)
            {
                for (int col = 0; col < matrix[row].Count; col++)
                {
                    //if you encounter a zero set the row to true and set the col to true
                    if(matrix[row][col] == 0)
                    {
                        zeroRows[row] = true;
                        zeroCols[col] = true;
                    }
                }
            }

            //then just loop through the zeroRows and cols again to create the zeroes
            for (int row = 0; row < matrix.Count; row++)
            {

                //loop through the cols and decide when to use
                for (int col = 0; col < matrix[row].Count; col++)
                {
                    if (zeroRows[row])
                    {
                        matrix[row][col] = 0;
                    }
                    else
                    {
                        if (zeroCols[col])
                        {
                            matrix[row][col] = 0;
                        }
                    }
                }
            }

            return matrix;
        }
    }


}
