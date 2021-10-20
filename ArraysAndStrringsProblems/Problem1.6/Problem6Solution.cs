using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrringsProblems.Problem6
{
    public static class Problem6Solution
    {
        public static string compressJuan(string str)
        {
            string compressedString = string.Empty;
            int counter = 1;
            char s = str[0];
            for(var i = 1; i < str.Length; i++) 
            { 
                if(s == str[i])
                {
                    counter++;
                }
                else
                {
                    compressedString += s + counter.ToString();
                    s = str[i];
                    counter = 1;
                }
            }

            compressedString += s + counter.ToString();

            return compressedString;
        }

        public static string compressCCI(string str)
        {
            //count the number of letter duplicates
            int size = countLetterGroup(str);
            StringBuilder compressedString = new StringBuilder(size);
            int counter = 1;
            char s = str[0];
            for(var i = 1; i < str.Length; i++) 
            { 
                if(s == str[i])
                {
                    counter++;
                }
                else
                {
                    compressedString.Append(s);
                    compressedString.Append(counter);
                    s = str[i];
                    counter = 1;
                }
            }

            compressedString.Append(s);
            compressedString.Append(counter);

            return compressedString.ToString();
        }

        public static int countLetterGroup(string str)
        {
            int counter = 1;
            char s = str[0];
            for(var i = 1; i < str.Length; i++)
            {
                if(s != str[i])
                {
                    counter++;
                    s = str[i];
                }
            }
            return counter;
        }
    }
}
