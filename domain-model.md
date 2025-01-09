## User Stories
- To remember what i need to do for the day, i want to be able to add tasks to a todo list
- To be able to see what i need to do, i want to see whats in my todo list
- To be able to see what tasks are done i want to see the status of the tasks
- To recognise my progress i want to be able to see only what tasks i already completed
- To recognise what i have left to do i want to be able to only see what tasks i have left
- To have easier access to my tasks, i would want to be able to search for specific tasks and receive if it exists or not
- If i get tasks that either is not within my scope or that is done since a while ago, i would want to remove tasks from my list
- To find my tasks easier in the list i would want to sort them alphabeticly in ascending order
- To find my tasks easier in the list i would want to sort them alphabeticly in descending order

## Domain Model

| Classes       | Methods/Properties                                 | Scenario                                       | Outputs                                                  |
|---------------|----------------------------------------------------|------------------------------------------------|----------------------------------------------------------| 
|ToDoList.cs    |AddTask(string task)                                |add task to todo list                           |                                                          |
|ToDoList.cs    |PrintToDoList()                                     |shows the whole todo list                       |string showing whole todolist                             |
|ToDoList.cs    |CompletedTasks()                                    |shows all the completed tasks                   |string showing all completed tasks                        |
|ToDoList.cs    |UnCompletedTasks()                                  |shows all the uncompleted tasks                 |string showing all uncompleted tasks                      |
|ToDoList.cs    |SearchForTask(string task)                          |looks for the searched task                     |returns the search task or a text with not found          |
|ToDoList.cs    |SetAsCompleted(string task)                         |set task as completed                           |													         |
|ToDoList.cs    |RemoveTask(string task)                             |task is not needed and can be removed           |bool that shows if it got removed or was not found													         |
|ToDoList.cs    |SortAscending()                                     |sorts the list in alphabetic ascending order    |                                                          |
|ToDoList.cs    |SortDescending()                                    |sorts the list in alphabetic descending order   |                                                          |
|Task.cs        |Property to store status                            |member to show                                  |bool showing the status                                   |
|Task.cs        |Property to store task as string                    |member to show                                  |string showing the task                                   |
|Task.cs        |Equals(Task other)                                  |in search for a task they need to be comparable |bool showing if equal or not                              |


