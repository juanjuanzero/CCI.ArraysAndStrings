using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrringsProblems.Problem7
{
    public static class Problem7Solution
    {
        public static List<List<int>> Rotate90Degrees(List<List<int>> matrix)
        {
            var listOfList = new List<List<int>>();
            for (int colPt = matrix.Count - 1; colPt >= 0; colPt--)
            {
                List<int> nList = new();
                for (int i = 0; i < matrix.Count; i++)
                {
                    //iterate over matrix to visit every row to grab the column,
                    //take all the columns and add it to a new list.
                    var row = matrix.ElementAt(i);
                    nList.Add(row.ElementAt(colPt));
                }
                listOfList.Add(nList);
            }

            return listOfList;
        }

        public static List<List<int>> RotateInplaceCci(List<List<int>> matrix)
        {
            //this problem is an onion
            int n = matrix.Count;
            //perform the swap at each layer of an onion
            for (int layer = 0; layer < n/2; layer++)
            {
                //setup the layer by capturing the indexes of the layer
                int first = layer; 

                //the last is the last item edge of a particular layer, its - layer because we are always moving inwards, up to the mid innermost layer.
                int last = n - 1 - layer;
                //looping throug the items on each particular edge, and performing the swap
                for(int i = first; i < last; i++)
                {
                    int offset = i - first;
                    int top = matrix[first][i]; //saving the top 

                    //left -> top
                    matrix[first][i] = matrix[last - offset][first];

                    //bottom -> left
                    matrix[last - offset][first] = matrix[last][last - offset];

                    //right -> bottom
                    matrix[last][last - offset] = matrix[i][last];

                    //top -> right
                    matrix[i][last] = top;
                }
            }

            return matrix;
        }

        public static List<List<int>> Rotate90DegreesInPlace(List<List<int>> matrix)
        {
            //loop through the entire matrix, the actions are 
            //if you know the col, you can derive the row position...
            var matrixCount = matrix.Count - 1;
            for (int row = 0; row < matrix.Count / 2; row++)
            {
                //visit every item
                for (int col = 0; col < matrix.Count; col++)
                {
                    //upper left -> lower left
                    var ul = matrix[row][col];
                    matrix[matrixCount - row][col] = ul;

                    //upper right -> upper left
                    var ur = matrix[row][matrixCount - col];
                    matrix[row][col] = ur;

                    //lower left -> lower right
                    var ll = matrix[matrixCount - row][col];
                    matrix[matrixCount - row][matrixCount - col] = ll;

                    //lower right -> upper right
                    var lr = matrix[matrixCount - row][matrixCount - col];
                    matrix[row][matrixCount - col] = lr;
                }


            }
            return matrix;

        }
    }


}
