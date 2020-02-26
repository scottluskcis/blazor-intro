using System.Collections.Generic;

namespace Blazor.Application.Providers
{
    public interface IDataProvider<T>
    {
        void Add(T item);
        IList<T> GetAll();
        void Update(int index, T item);
        int IndexOf(T item);
        T Get(int index);
    }
}