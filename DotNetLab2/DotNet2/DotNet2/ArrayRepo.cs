using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet2
{
    public static class ArrayRepo
    {
        public static int GetValueCount<T>(this T[] arr, T needle) where T : IComparable<T>
        {
            int count = 0;
            
            foreach (T item in arr)
            {
                if (EqualityComparer<T>.Default.Equals(item,needle))
                {
                    count++;
                }
            }
            return count;
        }
        public static T[] Unique<T>(this T[] arr)
        {
            T[] result = {};
            int i = 0;
            foreach (T item in arr)
            {
                if (!result.Contains(item))
                {
                    Array.Resize(ref result,result.Length+1);
                    result[i] = item;
                    i++;
                }
            }
            return result;
        }
    }
    public class Person
    {
        public Person(int id, string? name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age;

        public int GetAge()
        {
            return Age;
        }
    }
}
