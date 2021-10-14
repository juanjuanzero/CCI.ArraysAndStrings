using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrringsProblems.Problem5
{
    public static class Problem5Solution
    {
        public static bool oneEditAway(string a, string b)
        {
            if (Math.Abs(a.Length - b.Length) > 1) return false; //if you need more than one insertion.
            bool x = false;
            if(a.Length > b.Length)
            {
                x = loopForEdits(b, a);
            }
            else
            {
                x = loopForEdits(a, b);
            }

            
            return x;
        }

        public static bool loopForEdits(string first, string second)
        {
            //second is always longer than the first
            int counter = 0;
            int j = 0;
            for(var i = 0; i < first.Length; i++)
            {
                if(counter <= 1)
                {
                    if(first[i] != second[j])
                    {
                        if(first.Length != second.Length)
                        {
                            //its a next error
                            j+=1;
                        }
                        counter++;
                    }
                    j += 1;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
