﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsApp
{
    class Backpack<T> : IBag<T>
    {
        public Dictionary<string, Book> Bag = new Dictionary<string, Book>();
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Pack(T item)
        {
            throw new NotImplementedException();
        }

        public T Unpack(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}