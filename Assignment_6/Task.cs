using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    /// <summary>
    /// Represents a task object that has a dateTime, priority, and description.
    /// </summary>
    public class Task
    {
        public DateTime DateTime { get; set; }
        public PriorityType Priority { get; set; }
        public string Description { get; set; }


        /// <summary>
        /// Initializes a new instance of the Task class with the specified dateTime, priority, and description.
        /// </summary>
        /// <param name="dateTime">The dateTime for the task.</param>
        /// <param name="priority">The priority of the task.</param>
        /// <param name="description">The description of the task.</param>
        public Task(DateTime dateTime, PriorityType priority, string description)
        {
            DateTime = dateTime;
            Priority = priority;
            Description = description;
        }


        /// <summary>
        /// Returns a string that represents the current Task object, formatted as "date  time  Priority   Description".
        /// But with a padding of 25.
        /// </summary>
        /// <returns>A string representation of the Task object.</returns>
        public override string ToString()
        {
            string date = DateTime.ToString("yyyy-MM-dd").PadRight(25, ' ');
            string time = DateTime.ToString("HH:mm:ss").PadRight(25, ' ');
            string prio = Priority.ToString().Replace('_', ' ').PadRight(25, ' ');
            string description = Description;

            return date + time + prio + description;
        }


        /// <summary>
        /// Returns a string that represents the current Task object in CSV format, as "Date,Time,Priority,Description".
        /// </summary>
        /// <returns>A string representation of the Task object in CSV format.</returns>
        public string ToCSV()
        {
            string date = DateTime.ToString("yyyy-MM-dd");
            string time = DateTime.ToString("HH:mm:ss");
            string prio = Priority.ToString().Replace('_', ' ');
            string description = Description;

            return $"{date},{time},{prio},{description}";
        }

    }

}
