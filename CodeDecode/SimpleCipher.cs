using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderDecoder
{
    internal class SimpleCipher : ICipher
    {
        public string Encode(string str)
        {
            string code = "";
            for (int i = 0; i < str.Length; ++i)
            {
                code += (char)(str[i] + 1);
            }
            return code;
        }
        public string Decode(string str)
        {
            string decode = "";
            for (int i = 0; i < str.Length; ++i)
            {
                decode += (char)(str[i] - 1);
            }
            return decode;
        }
    }
}
