using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsLibrary
{
    public static class StringExtensions
    {
        public static int WordCount(this String str)
        {
            if (str == null) 
            { 
                return 0;
            }

            return str.Split(new char[] { ' ', '.', '?', '!' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static bool ToBool(this String str)
        {
            if (str != null) 
            {
                return str.ToLower() == "true"; 
            }

            return true;
        }
    }
}
