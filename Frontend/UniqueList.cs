using System.Collections;
using System.Collections.Generic;

namespace Frontend
{
    public class UniqueList<T> : IList<T>
    {
        private List<T> _list;

        #region Constructors
        public UniqueList()
        {
            _list = new List<T>();
        }

        public UniqueList(int capacity)
        {
            _list = new List<T>(capacity);
        }
        #endregion

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public void Add(T item)
        {
            if (!Contains(item)) _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(T item) => _list.Contains(item);

        public void CopyTo(T[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item) => _list.Remove(item);

        public int Count => _list.Count;
        public bool IsReadOnly => false;
        public int IndexOf(T item) => _list.IndexOf(item);

        public void Insert(int index, T item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public T this[int index]
        {
            get { return _list[index]; }
            set { _list[index] = value; }
        }
    }

}
