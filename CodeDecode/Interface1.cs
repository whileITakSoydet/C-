using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderDecoder
{
    internal interface ICipher
    {
        string Encode(string str);
        string Decode(string str);
    }
}
