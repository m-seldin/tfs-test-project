using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLibrary
{
    public class HelperFunctions
    {
        public string MyConcat(string a, string b)
        {
            return a + b + "c";
        }

        public int MyPlus(int a, int b)
        {
            return a + b;
        }

        public int MyMinus(int a, int b) => b - a;

    }
}
