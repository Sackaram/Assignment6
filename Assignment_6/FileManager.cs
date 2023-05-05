using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_6
{
    /// <summary>
    /// The FileManager class provides methods to read and write a list of Task objects
    /// to a text file in CSV format.
    /// </summary>
    public class FileManager
    {

        /// <summary>
        /// Reads a list of Task objects from a CSV file located at the specified path.
        /// </summary>
        /// <param name="path">The path to the CSV file.</param>
        /// <returns>A List of Task objects parsed from the CSV file.</returns>
        public List<Task> ReadTasksFromCSV(string path)
        {
            string filePath = path ?? ".\\tasks.txt";  // if path = null, set to tasks.txt
            
            List<Task> tasks = new List<Task>();
            using (StreamReader sr = new StreamReader(filePath!))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] columns = line.Split(',');
                    DateTime dateTime = DateTime.Parse(columns[0] + " " + columns[1]);
                    PriorityType priority = (PriorityType)Enum.Parse(typeof(PriorityType), columns[2].Replace(' ', '_'));
                    string description = columns[3];
                    
                    tasks.Add(new Task(dateTime, priority, description));
                }
            }
            return tasks;
        }


        /// <summary>
        /// Writes a string to a file located at the specified path. If the file does not exist, it is created.
        /// </summary>
        /// <param name="output">The string to write to the file.</param>
        /// <param name="path">The path to the file.</param>
        public void WriteFile(string output, string path)
        {
            string filePath = path ?? ".\\tasks.txt"; // if path = null, set to tasks.txt

            if (!System.IO.File.Exists(filePath))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(filePath)) { }
            }
            System.IO.File.WriteAllText(filePath, output);
        }

    }

}
