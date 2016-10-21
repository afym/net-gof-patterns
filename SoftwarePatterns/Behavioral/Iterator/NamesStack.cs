using System;
using System.Collections;
using System.Collections.Generic;

namespace SoftwarePatterns.Behavioral.Iterator
{
    public class NamesStack<T> : IEnumerable<T>
    {
        private T[] Names;
        private int Counter;

        public NamesStack(int Size) 
        {
            this.Counter = 0;
            this.Names = new T[Size];
        }

        public void Add(T Name) 
        {
            this.Names[Counter++] = Name;
        }

        public T Last() 
        {
            return this.Names[Counter - 1];
        }

        public T First() 
        {
            return this.Names[0];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int Index = 0; Index < Counter; Index++)
            {
                yield return this.Names[Index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}