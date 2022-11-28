using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Diagnostics;


namespace DotNet2
{
    public class ExDictionary<T, U, V> : IEnumerable
    {

        private struct Entity
        {
            public T key;
            public U first_value;
            public V second_value;
            public int index;
        }
        private int count = 0;
        private Entity[] entities = { };
        public int Length { get; set; } = 0;
        public void Add(T key, U first_val, V second_val)
        {
            if (FindEntityByKey(key) < 0)
            {
                Array.Resize(ref entities, entities.Length + 1);
                entities[count].key = key;
                entities[count].first_value = first_val;
                entities[count].second_value = second_val;
                entities[count].index = count;
                count++;
                Length = count;
            }
            else
            {
                ThrowHelper.ThrowArgumentException("Key already exist");
            }
        }
        private int FindEntityByKey(T key)
        {
            for (int i = 0; i < count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(entities[i].key, key))
                {
                    return i;
                }
            }
            return -1;
        }
        private object FindEntityByIndex(int index)
        {
            if (index <= count)
            {
                if (entities[index].index <= entities.Length && entities[index].index > -
               1)
                {
                    return entities[index];
                }
            }
            return -1;
        }
        public bool Remove(T key)
        {
            int i = FindEntityByKey(key);
            if (i >= 0)
            {

                entities[i].key = default(T);
                entities[i].first_value = default(U);
                entities[i].second_value = default(V);
                count--;
                Length = count;


                return true;
            }
            return false;
        }
        public object this[object key]
        {
            get
            {
                int i = FindEntityByKey((T)key);
                if (i >= 0)
                {
                    return $"{entities[i].first_value} {entities[i].second_value}";
                }
                return "Not exist";
            }
        }
        public bool KeyIsExist(T key)
        {
            if (FindEntityByKey(key) >= 0)
            {
                return true;
            }
            return false;
        }
        public bool ValuesIsExist(U first, V second)
        {
            for (int i = 0; i < count; i++)
            {
                if (EqualityComparer<U>.Default.Equals(entities[i].first_value, first) &&
               EqualityComparer<V>.Default.Equals(entities[i].second_value, second))
                {
                    return true;
                }
            }
            return false;
        }
        private class EntityEnumerator : IEnumerator/*,IExDictionaryEnumerator*/
        {
            private ExDictionary<T, U, V> _dictionary;
            private int position;
            private ExDictionaryElement<T, U, V> current;
            private int index;



            public EntityEnumerator(ExDictionary<T, U, V> dictionary)
            {
                _dictionary = dictionary;
                position = -1;
                index = 0;
                current = new ExDictionaryElement<T, U, V>();
            }
            public bool MoveNext()
            {

                position++;
                if (position >= 0 && position < _dictionary.Length)
                    current = new ExDictionaryElement<T, U,
                   V>(_dictionary.entities[position].key, _dictionary.entities[position].first_value,
                   _dictionary.entities[position].second_value);
                return (position < _dictionary.Length);
            }
            public void Reset()
            {
                position = -1;
                index = 0;

            }
            public void Dispose()
            {

            }
            object IEnumerator.Current
            {
                get
                {
                    return new ExDictionaryElement<T, U, V>(current.Key,
               current.FirstValue, current.SecondValue);
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new EntityEnumerator(this);
        }
        private class EtEnumerator : IEnumerator/*,IExDictionaryEnumerator*/
        {
            private Person[] person = { new Person(1, "a", 45), new Person(4, "b", 25), new Person(8, "C", 25) };
            private int position;
            private ExDictionaryElement<T, U, V> current;
            private int index;



            public EtEnumerator()
            {
                
                position = -1;

            }
            public bool MoveNext()
            {

                position++;
                return (position < person.Length);
            }
            public void Reset()
            {
                position = -1;
                index = 0;

            }
            public void Dispose()
            {

            }
            object IEnumerator.Current
            {
                get
                {
                    return person[position];
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new EtEnumerator();
        }

    }

}


