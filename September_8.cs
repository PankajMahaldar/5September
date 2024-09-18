using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5September
{
    public class September_8
    {
        public void ReverseString(string s)
        {
            string[] Strings = s.Split(" ");
            for(int i= Strings.Length-1; i>=0; i--)
            {
                Console.Write(Strings[i]+" ");
            }
        }

        public void ReverseVowelString(string s)
        {
            int j = 0;
            string temp = "";
            char[] str = s.ToCharArray();
            for(int i=0; i< str.Length; i++)
            {
                if(IsVowel(str[i]))
                {
                    j++;
                    temp += str[i];
                }
            }
            for(int i= 0; i< str.Length; i++)
            {
                if (IsVowel(str[i]))
                {
                    str[i] = temp[--j];
                }
            }
            string.Join(" ", str);
            Console.WriteLine(str);
        }

        public static bool IsVowel(char c)
        {
            return (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' || c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
        }

        public string LongestPrefixString(string[] str)
        {
            if (str == null || str.Length == 0)
                return "-1";

            Array.Sort(str);

            string first = str[0];
            string last = str[str.Length - 1];
            int minLength = Math.Min(first.Length, last.Length);

            int i = 0;

            while(i < minLength && first[i] == last[i])
            {
                i++;
            }

            if (i == 0)
                return "-1";

            return first.Substring(0,i);

        }
    }
}
