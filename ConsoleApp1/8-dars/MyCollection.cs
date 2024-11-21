using System.Collections;

namespace ConsoleApp1._8_dars
{
    public class MyCollection<T> : IList<T>
    {
        private List<T> _items;
        public MyCollection()
        {
            _items = new List<T>();
        }

        public T this[int index] 
        { 
            get
            {
                return _items[index];
            }
            set
            {
                _items[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return _items.Count;
            }
            // set ishlatilmaydi, faqatgina bundan olib ishlatish mumkin
        }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Clear()
        {
            _items.Clear(); 
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /*IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }*/
    }
}
