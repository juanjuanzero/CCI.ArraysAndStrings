using System;
using System.Collections.Generic;

namespace ArraysAndStrringsProblems.Problem1
{
    public static class Problem1Solution
    {
        public static bool isUniqueCharsJuan(string str)
        {
            var dict = new Dictionary<char, char>();
            for(var i = 0; i < str.Length; i++)
            {
                if (dict.ContainsKey(str[i]))
                {
                    return false;
                }
                else
                {
                    dict.Add(str[i], str[i]);
                }
            }
            return true;
        }

        public static bool isUniqueCharsASCII(string str)
        {
            if (str.Length > 128) return false;
            bool[] char_set = new bool[128]; //assuming its all ascii characters
            for(var i = 0; i < str.Length; i++)
            {
                var val = str[i];
                if (char_set[val])
                {
                    return false;
                }
                char_set[val] = true;
            }
            //if it makes it through the entire set then all is unique
            return true;
        }
    }
}
