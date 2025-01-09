using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Task
{
    public Guid ID { get; }
    public bool Status { get; set; }
    public string TaskText { get; set; }

    public DateTime Time { get; }

    public Task(string taskText)
    {
        TaskText = taskText;
        Status = false;
        Time = DateTime.Now;
        ID = Guid.NewGuid();
    }

    public override string ToString()
    {
        return TaskText + " Status: " + Status + " Created: " + Time;
    }
}

