using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Text;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void FirstTest()
        {
            TodoList core = new TodoList();
            Assert.Pass();
        }

        [Test]
        public void AddTaskTest()
        {
            TodoList core = new TodoList();

            core.AddTask("Go shopping");
            core.AddTask("Go to the gym");
            core.AddTask("Clean my room");
            core.AddTask("Sleep");

            Assert.That(core.Size(), Is.EqualTo(4));

        }

        [Test]
        public void PrintCompletedTasksTest()
        {
            TodoList core = new TodoList();

            core.AddTask("Go shopping");
            core.AddTask("Go to the gym");
            core.AddTask("Clean my room");
            core.AddTask("Sleep");

            core.SetAsCompleted("Sleep");
            core.SetAsCompleted("Go to the gym");

            string allTasks = core.PrintCompletedTasks();
            string temp = "Go to the gym Status: True\n" +
                          "Sleep Status: True\n";

            Assert.That(allTasks, Is.EqualTo(temp));
        }

        [Test]
        public void PrintUncompletedTasksTest()
        {
            TodoList core = new TodoList();

            core.AddTask("Go shopping");
            core.AddTask("Go to the gym");
            core.AddTask("Sleep");
            core.AddTask("Clean my room");

            core.SetAsCompleted("Sleep");
            core.SetAsCompleted("Go to the gym");

            string allTasks = core.PrintUnCompletedTasks();
            string temp = "Go shopping Status: False\n" +
                          "Clean my room Status: False\n";

            Assert.That(allTasks, Is.EqualTo(temp));
        }

        [Test]
        public void SearchFoundTest()
        {
            TodoList core = new TodoList();

            core.AddTask("Go shopping");
            core.AddTask("Go to the gym");
            core.AddTask("Clean my room");
            core.AddTask("Sleep");

            string temp = core.SearchForTask("Sleep");

            Assert.That(temp, Is.EqualTo("Sleep"));
        }

        public void SearchNotFoundTest()
        {
            TodoList core = new TodoList();

            core.AddTask("Go shopping");
            core.AddTask("Go to the gym");
            core.AddTask("Clean my room");
            core.AddTask("Sleep");

            string temp = core.SearchForTask("Eat");

            Assert.That(temp, Is.EqualTo("Not Found"));
        }

        [Test]
        public void SortAscendingTest()
        {
            TodoList core = new TodoList();

            core.AddTask("Go shopping");
            core.AddTask("Go to the gym");
            core.AddTask("Clean my room");
            core.AddTask("Sleep");
            core.AddTask("A");
            core.AddTask("Go to the gym or not");
            core.AddTask("Z");
            core.AddTask("Clean car");

            List<KeyValuePair<string, bool>> temp =  core.SortAscending();

            StringBuilder sb = new StringBuilder();

            foreach(KeyValuePair<string, bool> kp in temp)
            {
                sb.Append(kp.Key + " Status: " + kp.Value + "\n");
            }

            string list = sb.ToString();

            string correctSortedList = "A Status: False\n" +
                                       "Clean car Status: False\n" +
                                       "Clean my room Status: False\n" +
                                       "Go shopping Status: False\n" +
                                       "Go to the gym Status: False\n" +
                                       "Go to the gym or not Status: False\n" +
                                       "Sleep Status: False\n" +
                                       "Z Status: False\n";


            Assert.That(list, Is.EqualTo(correctSortedList));
        }

        [Test]
        public void SortDescendingTest()
        {
            TodoList core = new TodoList();

            core.AddTask("Go shopping");
            core.AddTask("Go to the gym");
            core.AddTask("Clean my room");
            core.AddTask("Sleep");
            core.AddTask("A");
            core.AddTask("Go to the gym or not");
            core.AddTask("Z");
            core.AddTask("Clean car");

            List<KeyValuePair<string, bool>> temp = core.SortDescending();

            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, bool> kp in temp)
            {
                sb.Append(kp.Key + " Status: " + kp.Value +"\n");
            }

            string list = sb.ToString();

            string correctSortedList = "Z Status: False\n" +
                                       "Sleep Status: False\n" +
                                       "Go to the gym or not Status: False\n"+
                                       "Go to the gym Status: False\n" +
                                       "Go shopping Status: False\n" +
                                       "Clean my room Status: False\n" +
                                       "Clean car Status: False\n" +
                                       "A Status: False\n";




            Assert.That(list, Is.EqualTo(correctSortedList));
        }

    }
}