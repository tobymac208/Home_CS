using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Home_CS.POJO.TODOItem
{
    class TodoItemList
    {
        private List<TodoItem> todoItems;

        public TodoItemList()
        {
            todoItems = new List<TodoItem>();
        }

        public List<TodoItem> GetTodoItems()
        {
            return Clone(); // clone this instance and return it
        }

        /** Add an item. */
        public bool AddTodoItem(TodoItem newItem)
        {
            foreach (TodoItem currentItem in todoItems)
            {
                if (currentItem.Equals(newItem))
                {
                    return false; // cannot add the item
                }
            }
            todoItems.Add(newItem);
            return true;
        }

        /** Remove an item. */
        public bool RemoveTodoItem(TodoItem item)
        {
            for (int i = 0; i < todoItems.Count; i++)
            {
                if (todoItems.ElementAt(i).Equals(item))
                {
                    todoItems.RemoveAt(i); // remove the item
                    return true;
                }
            }
            return false;
        }

        /** Set the whole thing equal to one list. */
        public void SetTodoItems(List<TodoItem> list)
        {
            todoItems = list;
        }

        public List<TodoItem> Clone()
        {
            List<TodoItem> items = new List<TodoItem>();
            foreach (TodoItem item in todoItems)
            {
                items.Add(item);
            }
            return items;
        }
    }
}
