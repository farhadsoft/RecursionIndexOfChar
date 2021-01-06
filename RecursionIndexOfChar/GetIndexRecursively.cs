using System;

namespace RecursionIndexOfChar
{
    public static class GetIndexRecursively
    {
        public static int GetIndexOfChar(string str, char value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return FindChar(str, value, str.Length);
        }

        public static int GetIndexOfChar(string str, char value, int startIndex, int count)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return FindChar(str, value, count, startIndex);
        }

        public static int FindChar(string str, char value, int count, int startIndex = 0)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (startIndex >= str.Length)
            {
                return -1;
            }

            if (str[startIndex] == value)
            {
                return startIndex;
            }

            startIndex++;
            count--;

            if (count == 0)
            {
                return -1;
            }

            return FindChar(str, value, count, startIndex);
        }
    }
}
