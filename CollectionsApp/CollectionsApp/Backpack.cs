using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsApp
{
    public class Backpack<T> : IBag<T>
    {
        public List<T> Bag = new List<T>();
        public IEnumerator<T> GetEnumerator()
        {
           foreach(T item in Bag)
            {
                yield return item;
            }
        }

        public void Pack(T item)
        {
            Bag.Add(item);
        }

        public T Unpack(int index)
        {
            T item = Bag[index];
            Bag.RemoveAt(index);
            return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
