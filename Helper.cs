using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DESCSharpProject
{
    class Helper
    {
        public static string Mode;
        public static string setProcessType(string mode)
        {
            if (mode == "1")
            {
                Mode = "Encrypt";
            }
            else if (mode == "2")
            {
                Mode = "Decrypt";
            }
            return Mode;
        }
    }
}
