using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static class GtWordCount
    {
        public static int GetWordCount(this string str)
        {
            if(!string .IsNullOrEmpty(str))
            {
                return str.Split(' ').Length;
            }
            return 0;
        }
    }
}
