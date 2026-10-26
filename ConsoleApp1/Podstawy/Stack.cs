using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Podstawy
{
    public class Stack<T>
    {
        private readonly List<T> _list = new List<T>(); // wewnętrzna lista do przechowywania elementów stosu
        public int Count => _list.Count; // właściwość zwracająca liczbę elementów na stosie

        //metoda dodająca element na stos
        public void Push(T obj)
        {
            if (obj == null)
                throw new ArgumentNullException("Cannot push null object onto the stack.");

            _list.Add(obj);
        }

        //metoda usuwająca i zwracająca element ze stosu
        public T Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("Cannot pop from an empty stack.");

            T obj = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return obj;
        }

        //metoda zwracająca element ze stosu bez usuwania go
        public T Peek()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("Cannot peek at an empty stack.");

            return _list[_list.Count - 1];
        }
    }
}
