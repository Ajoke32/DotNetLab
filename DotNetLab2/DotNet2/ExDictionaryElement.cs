using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet2
{
    public class ExDictionaryElement<T,U,V>
    {
        public T Key { get; set; } 
        public U FirstValue { get; set; } 
        public V SecondValue { get; set; } 
        public ExDictionaryElement(ExDictionary<T,U,V>.Entity dict)
        {
            Key = dict.key;
            FirstValue = dict.first_value;
            SecondValue = dict.second_value;
        }

    }
}
