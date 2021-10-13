using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrringsProblems.Problem3
{
    public static class Problem3Solution
    {
        public static string Urlify(string s, int trueLength)
        {
            //count how many spaces first, for every space there are an additional character
            char[] str = s.ToCharArray();
            int spaceCount = 0;
            for(var a = trueLength - 1; a >= 0; a--)
            {
                if(s[a] == ' ')
                {
                    spaceCount++;
                }
            }

            int newIndex = trueLength - 1 + spaceCount * 2;
            if (newIndex + 1 < s.Length) str[newIndex + 1] = '\0'; //a null character at the end
            //loop through the original string
            for(int oldIndex = trueLength -1; oldIndex >= 0; oldIndex -= 1)
            {
                if(str[oldIndex] == ' ')
                {
                    str[newIndex] = '0';
                    str[newIndex - 1] = '2';
                    str[newIndex - 2] = '%';
                    newIndex -= 3;
                }
                else
                {
                    str[newIndex] = str[oldIndex];
                    newIndex -= 1;
                }
            }
            var ex = string.Join(string.Empty, str);

            return ex;
        }
    }
}
