using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryDictionary
{
    internal class Glossary
    {
        private Dictionary<string, string> _dictionary;
        public Glossary()
        {
            _dictionary = new Dictionary<string, string>();
            _dictionary.Add("Россия", "Russia");
            _dictionary.Add("США", "USA");
            _dictionary.Add("Китай", "China");
            _dictionary.Add("Германия", "Germany");
            _dictionary.Add("Франция", "French");
        }
        public void AddWords(string first, string second)
        {
            _dictionary.Add(first, second);
        }
        public void DellRussianWords(string key)
        {
            if (_dictionary.ContainsKey(key))
            {
                _dictionary.Remove(key);
            }
            else
            {
                throw new Exception("Слово отсутствует в словаре");
            }
        }
        public void DellEnglishWords(string key)
        {
            if (_dictionary.ContainsValue(key))
            {
                foreach (var item in _dictionary)
                {
                    if (item.Value == key)
                    {
                        key = item.Key;
                        break;
                    }
                }
                _dictionary.Remove(key);
            }
            else
            {
                throw new Exception("Слово отсутствует в словаре");
            }
        }

        public string GetRussianWord(string key)
        {
            if(_dictionary.ContainsKey(key))
            {
                return _dictionary[key];
            }
            else
            {
                throw new Exception("Слово отсутствует в словаре");
            }
        }
        public string GetEnglishWord(string key)
        {
            if(_dictionary.ContainsValue(key))
            {
                foreach (var item in _dictionary)
                {
                    if(item.Value == key)
                    {
                        return item.Key;
                    }
                }
                return "";
            }
            else
            {
                throw new Exception("Слово отсутствует в словаре");
            }
        }
        public void ShowWords()
        {
            foreach(var item in _dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
