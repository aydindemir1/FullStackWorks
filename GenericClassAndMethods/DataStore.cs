using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassAndMethods
{

    public class DataStore<T>
    {
        private List<T> _data = new List<T>();

        public void Add(T item)
        {
            _data.Add(item);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _data.Count)
                throw new IndexOutOfRangeException("Index out of range");

            return _data[index];
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= _data.Count)
                throw new IndexOutOfRangeException("Index out of range");

            _data.RemoveAt(index);
        }

        public void DisplayAll()
        {
            foreach (var item in _data)
            {
                Console.WriteLine(item);
            }
        }
    }

   

}
