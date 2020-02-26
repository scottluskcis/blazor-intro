using System.Collections.Generic;

namespace Blazor.Application.Providers
{
    public class InMemoryDataProvider<T> : IDataProvider<T>
    {
        private readonly IList<T> _list;

        public InMemoryDataProvider()
        {
            _list = new List<T>();
        }

        public void Add(T item)
        {
            _list.Add(item);
        }

        public T Get(int index)
        {
            return _list[index];
        }

        public IList<T> GetAll()
        {
            return _list;
        }

        public int IndexOf(T item)
        {
            return _list.IndexOf(item);
        }

        public void Update(int index, T item)
        {
            _list[index] = item;
        }
    }
}
