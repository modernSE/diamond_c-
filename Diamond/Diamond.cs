using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    public class Diamond
    {
        public String Print(int n)
        {
            if (n <= 0 || n % 2 == 0)
            {
                return null;
            }
            var builder = new StringBuilder(new String(Make(n, n)));
            for (int i = n - 2; i > 0; i -= 2)
            {
                char[] chars = Make(n, i);
                builder.Insert(0, chars);
                builder.Append(chars);
            }
            return builder.ToString();
        }

        private char[] Make(int i, int j)
        {
            int amount = ((i - j) / 2);
            var chars = new char[amount + j + 1];
            if (amount > 0)
            {
                Fill(chars, 0, amount, ' ');
            }
            Fill(chars, amount, amount + j, '*');
            chars[chars.Length - 1] = '\n';
            return chars;
        }

        private void Fill(char[] sourceArray, int indexFrom, int indexTo, char symbol)
        {
            for (var a = indexFrom; a < indexTo; a++)
            {
                sourceArray[a] = symbol;
            }
        }
    }
}
