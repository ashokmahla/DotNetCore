using System.Collections.Generic;
using WebApiPoc.Models;
namespace WebApiPoc.Interfaces
{
    public interface IToDoRepository
    {
        bool DoesItemExists(string id);
        IEnumerable<ToDoItem> All {get;}
        ToDoItem Find (string id);
        void Insert(ToDoItem item);
        void Update(ToDoItem item);
        void Delete(string item);
    }
}