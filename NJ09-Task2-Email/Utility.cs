using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NJ09_Task2_Email
{
    public static class Utility
    {
        public static string StringWithCommas<T>(IEnumerable<T> input)
        {
            int length = input.Count();

            var result = new StringBuilder();

            int i = 1;
            foreach (var item in input)
            {
                result.Append(item);
                if (i < length) result.Append(", ");
                i++;
            }

            return result.ToString();
        }
    }
}
