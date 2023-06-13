using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderDecoder
{
    internal class UnlistedPhone
    {
        private string _name;
        private string _phone;
        private ICipher _cipher;
        public UnlistedPhone(string name, string phone, bool flag, byte key = 3)
        {
            if(flag)
            {
                _cipher = new BitCipher(key);
            }
            else 
            {
                _cipher = new SimpleCipher();
            }
            Name = name;
            Phone = phone;
        }
        public string Name
        {
            get
            {
                
                return _cipher.Decode(_name);
            }
            set
            {
                _name = _cipher.Encode(value);
            }
        }
        public string Phone
        {
            get
            {
                return _cipher.Decode(_phone);
            }
            set
            {
                _phone = _cipher.Encode(value);
            }
        }
        public override string ToString()
        {
            return $"Имя: {Name} Номер: {Phone}";
        }
    }
}
