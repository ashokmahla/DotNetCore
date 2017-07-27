using System;
using System.Collections.Generic;
using System.Linq;
using WebApiPoc.Interfaces;
using WebApiPoc.Models;
namespace WebApiPoc.Repository
{
    public class ToDoRepository : IToDoRepository
    {
    
        private List<ToDoItem> _toDoList;

        public ToDoRepository()
        {
          InitializeData()  ;
        }
        public IEnumerable<ToDoItem> All 
        {
             get {return _toDoList;}
        }

        public bool DoesItemExists(string id)
        {
           return _toDoList.Any(item => item.ID == id);
        }

        public ToDoItem Find(string id)
        {
            return _toDoList.FirstOrDefault(item => item.ID == id);
        }

        public void Insert(ToDoItem item)
        {
             _toDoList.Add(item);
        }

        public void Update(ToDoItem item)
        {
           var todoItem = this.Find(item.ID);
           var index = _toDoList.IndexOf(todoItem);
           _toDoList.RemoveAt(index);
           _toDoList.Insert(index,item);
        }

        public void Delete(string id)
        {
           _toDoList.Remove(this.Find(id));
        }

        private void InitializeData()
        {
            _toDoList = new List<ToDoItem>();

            var toDoItem1 = new ToDoItem {
                ID = "1",
                Name = "Computer",
                Notes = "Windows",
                Done = false
            };
            _toDoList.Add(toDoItem1);
        }
    }
}