using System;
using System.Text;

namespace TimeTrackerLite.Utils
{
    public static class DBHelper
    {
        public static string ToDB(this string s)
        {
            var sb = new StringBuilder();
            var first = true;
            foreach (var c in s)
            {
                if (!first && char.IsUpper(c))
                    sb.Append('_');
                first = false;
                sb.Append(c);
            }
            return sb.ToString().ToLower();
        }
    }
}
