using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet2
{
    public readonly struct ExDictionaryElement<T, U, V>
    {
        public T Key { get; }
        public U FirstValue { get; }
        public V SecondValue { get; }
        public ExDictionaryElement(T key, U first, V second)
        {
            Key = key;
            FirstValue = first;
            SecondValue = second;
        }
    }
}
