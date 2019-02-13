using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            // put your code here
            int count = 0;

            foreach (char ch in str)
            {
                if (ch == 'a')
                    count++;
            }

            foreach (char ch in str)
            {
                if (ch == 'e')
                    count++;
            }

            foreach (char ch in str)
            {
                if (ch == 'i')
                    count++;
            }

            foreach (char ch in str)
            {
                if (ch == 'o')
                    count++;
            }

            foreach (char ch in str)
            {
                if (ch == 'u')
                    count++;
            }

            return count;
        }
    }
}
