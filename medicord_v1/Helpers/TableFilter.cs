using System;
using System.Collections.Generic;
using System.Text;

namespace medicord_v1.Helpers
{
    public static class TableFilter
    {
        //make ' [ ] * % safe to type
        public static string EscapeLike(string s)
        {
            var sb = new StringBuilder();
            foreach (char c in s)
            {
                if (c == '\'') sb.Append("''");
                else if (c is '[' or ']' or '*' or '%') sb.Append('[').Append(c).Append(']');
                else sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
