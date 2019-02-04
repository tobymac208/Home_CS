using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_CS.POJO.TODOItem
{
    class TodoItem
    {
        private string title;
        private string description;
        private bool completed;

        public TodoItem(string title, string description, bool completed)
        {
            this.title = title;
            this.description = description;
            this.completed = completed;
        }

        // GETTERS & SETTERS
        public String Title
        {
            get{ return title; }
            set { title = value; }
            
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public bool Completed
        {
            get { return completed; }
            set { Completed = value; }
        }

        public bool Equals(TodoItem item)
        {
            // TODO: Implement
            return false;
        }
    }
}
