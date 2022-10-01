using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm.EventArgs
{
    public class ErorrArgs
    {
        public ErorrArgs(string name, string message, int code)
        {
            Name = name;
            Message = message;
            Code = code;
        }
        public string Name { get; }
        public string Message { get; } = string.Empty;
        public int Code { get; }

    }
}
