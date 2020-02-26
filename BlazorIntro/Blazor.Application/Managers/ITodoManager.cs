using Blazor.Application.Models;
using System.Collections.Generic;

namespace Blazor.Application.Managers
{
    public interface ITodoManager
    {
        void Add(TodoItem item);
        IList<TodoItem> GetAll();
        void ToggleDone(TodoItem item);
    }
}