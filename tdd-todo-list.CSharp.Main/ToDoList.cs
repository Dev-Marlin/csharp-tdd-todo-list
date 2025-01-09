using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        /*private List<Task> taskList;
        public TodoList() { 
            taskList = new List<Task>();
        }

        public void AddTask(string task)
        {
            taskList.Add(new Task(task));
        }

        public string PrintToDoList()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Task t in taskList)
            {
                sb.Append(t.TaskText + " Status: " + t.Status);
            }

            return sb.ToString();
        }

        public string CompletedTasks()
        {
            StringBuilder sb = new StringBuilder();

            taskList.Where(t => t.Status).ToList().ForEach(t => sb.Append(t.TaskText + " Status: " + t.Status +"\n"));

            return sb.ToString();
        }

        public string UnCompletedTasks()
        {
            StringBuilder sb = new StringBuilder();

            taskList.Where(t => t.Status).ToList().ForEach(t => sb.Append(t.TaskText + " Status: " + t.Status + "\n"));

            return sb.ToString();
        }

        public string SearchForTask(string other)
        {
            foreach (Task t in taskList)
            { 
                if(t.TaskText.Equals(other))
                {
                    return t.TaskText;
                }
            }

            return "Not found";
        }

        public void SortAscending()
        {
            taskList.Sort((t1, t2) => t1.TaskText.CompareTo(t2.TaskText));
        }

        public void SortDescending()
        {
            taskList.Sort((t1, t2) => t2.TaskText.CompareTo(t1.TaskText));
        }

        public int Size()
        {
            return taskList.Count;
        }

        private class Task
        {
            public bool Status { get; set; }
            public string TaskText { get; }

            public Task(string taskText)
            {
                TaskText = taskText;
                Status = false;
            }
        }*/

        private Dictionary<string, bool> Tasks;

        public TodoList()
        {
            Tasks = new Dictionary<string, bool>();
        }

        public void AddTask(string task)
        {
            Tasks.Add(task, false);
        }

        public string PrintToDoList()
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, bool> kp in Tasks)
            {
                sb.Append(kp.Key + " Status: " + kp.Value);
            }

            return sb.ToString();
        }

        public string PrintCompletedTasks()
        {
            StringBuilder sb = new StringBuilder();

            Tasks.Where(t => t.Value).ToList().ForEach(t => sb.Append(t.Key + " Status: " + t.Value + "\n"));

            return sb.ToString();
        }

        public string PrintUnCompletedTasks()
        {
            StringBuilder sb = new StringBuilder();

            Tasks.Where(t => !t.Value).ToList().ForEach(t => sb.Append(t.Key + " Status: " + t.Value + "\n"));

            return sb.ToString();
        }

        public string SearchForTask(string other)
        {
            foreach (KeyValuePair<string, bool> t in Tasks)
            {
                if (t.Key.Equals(other))
                {
                    return t.Key;
                }
            }

            return "Not found";
        }

        public List<KeyValuePair<string, bool>> SortAscending()
        {
            List<KeyValuePair<string, bool>> temp = Tasks.ToList();
            temp.Sort((t1, t2) => t1.Key.CompareTo(t2.Key));
            return temp;
        }

        public List<KeyValuePair<string, bool>> SortDescending()
        {
            List<KeyValuePair<string, bool>> temp = Tasks.ToList();
            temp.Sort((t1, t2) => t2.Key.CompareTo(t1.Key));
            return temp;
        }

        public int Size()
        {
            return Tasks.Count;
        }

        public void SetAsCompleted(string task)
        {
            foreach (KeyValuePair<string, bool> t in Tasks)
            {
                if (t.Key.Equals(task))
                {
                    Tasks[task] = true;
                }
            }
        }

        public bool RemoveTask(string task)
        {
            foreach (KeyValuePair<string, bool> t in Tasks)
            {
                if (t.Key.Equals(task))
                {
                    Tasks.Remove(t.Key);
                    return true;
                }
            }

            return false;
        }
    }
}
