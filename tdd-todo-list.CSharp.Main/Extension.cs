using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        private List<Task> taskList;
        public TodoListExtension() { 
            taskList = new List<Task>();
        }

        public void AddTask(string task) 
        {
            taskList.Add(new Task(task));
        }

        public void AddTask(Task task)
        {
            taskList.Add(task);
        }

        public Task GetTaskByID(Guid ID)
        {
            foreach (Task task in taskList)
            {
                if (task.ID.Equals(ID))
                {
                    return task;
                }
            }

            return null;
        }

        public void ChangeNameByID(Guid guid, string name)
        {
            foreach (Task task in taskList)
            {
                if(task.ID.Equals(guid))
                {
                    task.TaskText = name;
                    break;
                }
            }
        }

        public void ChangeStatusByID(Guid guid)
        {
            foreach (Task task in taskList)
            {
                if (task.ID.Equals(guid))
                {
                    task.Status = !task.Status;
                    break;
                }
            }
        }

        public string PrintTodoList()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Task task in taskList)
            {
                sb.Append(task.ToString() + "\n");
            }

            return sb.ToString();
        }
    }
}
