using Blazor.Application.Models;
using Blazor.Application.Providers;
using System.Collections.Generic;
using System.Linq;

namespace Blazor.Application.Managers
{
    public class TodoManager : ITodoManager
    {
        private readonly IDataProvider<TodoItem> _provider;
        private int _itemCount = 0;

        public TodoManager(IDataProvider<TodoItem> provider)
        {
            _provider = provider;
        }

        public void Add(TodoItem item)
        {
            item.Id = _itemCount++;
            _provider.Add(item);
        }

        public void ToggleDone(TodoItem item)
        {
            var index = _provider.IndexOf(item);
            
            item.IsDone = item.IsDone ? false : true;

            _provider.Update(index, item);
        }

        public IList<TodoItem> GetAll()
        {
            return _provider.GetAll();
        }
    }
}
