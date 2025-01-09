using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        [Test]
        public void SearchByIDTest()
        {
            TodoListExtension _extension = new TodoListExtension();
            Task task = new Task("Eat");

            _extension.AddTask("Go shopping");
            _extension.AddTask(task);
            _extension.AddTask("Go to the gym");
            _extension.AddTask("Clean my room");
            _extension.AddTask("Sleep");

            Guid id = task.ID;

            Task same = _extension.GetTaskByID(id);

            Assert.That(same, Is.EqualTo(task));
        }

        [Test]
        public void ChangeNameByIDTest()
        {
            TodoListExtension _extension = new TodoListExtension();
            Task task = new Task("Eat");

            _extension.AddTask("Go shopping");
            _extension.AddTask(task);
            _extension.AddTask("Go to the gym");
            _extension.AddTask("Clean my room");
            _extension.AddTask("Sleep");

            Guid id = task.ID;

            _extension.ChangeNameByID(id, "Work");

            Task same = _extension.GetTaskByID(id);

            Assert.That(same.TaskText, Is.EqualTo("Work"));
        }

        [Test]
        public void ChangeStatusByIDTest()
        {
            TodoListExtension _extension = new TodoListExtension();
            Task task = new Task("Eat");

            _extension.AddTask("Go shopping");
            _extension.AddTask(task);
            _extension.AddTask("Go to the gym");
            _extension.AddTask("Clean my room");
            _extension.AddTask("Sleep");

            Guid id = task.ID;

            _extension.ChangeStatusByID(id);

            Task same = _extension.GetTaskByID(id);

            Assert.That(same.Status, Is.EqualTo(true));
        }
    }
}
