using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace isogram
{
    public class Class1
    {
        public static bool Isogram(string input)
        {
            bool check = true;
            string str = Regex.Replace(input, "-", "");
            char[] inputArr = str.ToCharArray();
            Array.Sort(inputArr);
            for (int i=0; i < (str.Length - 1); i++)
            {
                if(inputArr[i] == inputArr[i+1])
                {
                    check = false;
                    break;
                }
            }

            return check;
        }
    }
}
