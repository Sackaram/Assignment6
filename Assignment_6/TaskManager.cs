using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    /// <summary>
    /// Manages the collection of tasks in the to-do list application.
    /// </summary>
    public class TaskManager
    {
        private List<Task> tasks = new List<Task>();


        /// <summary>
        /// Adds a new task to the task list.
        /// </summary>
        /// <param name="task">The task to add to the list.</param>
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }


        /// <summary>
        /// Updates an existing task with the specified properties.
        /// </summary>
        /// <param name="task">The task to update.</param>
        /// <param name="dateTime">The new deadline for the task.</param>
        /// <param name="priorityType">The new priority for the task.</param>
        /// <param name="description">The new description for the task.</param>
        public void UpdateTask(Task task, DateTime dateTime, PriorityType priorityType, string description)
        {
            task.DateTime = dateTime;
            task.Priority = priorityType;
            task.Description = description;
        }


        /// <summary>
        /// Removes all tasks from the task list.
        /// </summary>
        public void ClearTasks()
        {
            tasks.Clear();
        }


        /// <summary>
        /// Removes the specified task from the task list.
        /// </summary>
        /// <param name="task">The task to remove from the list.</param>
        public void RemoveTask(Task task)
        {
            tasks.Remove(task);
        }


        /// <summary>
        /// Returns the task at the specified index in the task list.
        /// </summary>
        /// <param name="index">The index of the task to return.</param>
        /// <returns>The task at the specified index.</returns>
        public Task GetTask(int index)
        {
            return tasks[index];
        }


        /// <summary>
        /// Returns a list of all tasks in the task list.
        /// </summary>
        /// <returns>A list of all tasks.</returns>
        public List<Task> GetTasks()
        {
            return tasks;
        }

    }

}
