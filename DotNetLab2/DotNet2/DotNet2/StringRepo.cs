using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet2
{
    public static class StringRepo
    {
        public static string ReverseStr(this string obj)
        {
            char[] arr = obj.ToArray();
            Array.Reverse(arr);
            obj = String.Join("", arr);
            return obj;
        }
        public static int GetSymbolCount(this string obj,char needle)
        {
            char[] arr = obj.ToCharArray();
            obj = "";
            foreach(char c in arr)
            {
                if(c == needle)
                {
                    obj += c;
                }
            }
            return obj.Length;
        }

    }
}
