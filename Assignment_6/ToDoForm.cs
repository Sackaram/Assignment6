
namespace Assignment_6
{
    public partial class ToDoForm : Form
    {
        // Programming in C#-VT23
        // Assignment 6
        // Viktor Hansson
        // 05/05/23


        TaskManager taskManager = new TaskManager();
        FileManager fileManager = new FileManager();
        string filePath = "tasks.txt";

        public ToDoForm()
        {
            InitializeComponent();
            InitilizeGUI();
        }

        /// <summary>
        /// Initializes the GUI by setting the data source for the priorityComboBox to the PriorityType enumeration,
        /// customizing the format of the dateTimePicker, and setting the initial values of the timerLabel and dateTimePicker controls.
        /// If there are no tasks in the taskManager, it disables the changeButton and DeleteButton.
        /// </summary>
        private void InitilizeGUI()
        {
            priorityComboBox.DataSource = Enum.GetValues(typeof(PriorityType));
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = " yyyy-MM-dd         HH:mm:ss ";
            timerLabel.Text = DateTime.Now.ToString("hh:mm:ss");
            dateTimePicker.Value = DateTime.Now;

            if (taskManager.GetTasks().Count == 0)
            {
                changeButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
        }


        /// <summary>
        /// Updates the GUI by clearing the tasksListBox and populating it with the tasks in the taskManager.
        /// Enables/disables the appropriate buttons and resets the descriptionTextBox and dateTimePicker to their default values.
        /// </summary>
        private void UpdateGUI()
        {
            addButton.Visible = true;
            DeleteButton.Visible = true;
            doneEditingButton.Visible = false;
            cancelEditButton.Visible = false;

            DeleteButton.Enabled = false;
            changeButton.Enabled = false;


            tasksListBox.Items.Clear();  
            foreach (Task task in taskManager.GetTasks())
            {
                tasksListBox.Items.Add(task.ToString());
            }

            descriptionTextBox.Clear();
            dateTimePicker.Value = DateTime.Now;
        }

        // This event handler is triggered when the user selects an item in the tasksListBox.
        // If one or more items are selected, it enables the changeButton and DeleteButton to allow the user to modify or remove the selected task.
        private void toDolistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tasksListBox.SelectedIndices.Count > 0)
            {
                changeButton.Enabled = true;
                DeleteButton.Enabled = true;
            }
        }

        // Updates the timerLabel control to show the time remaining until the selected task's deadline or the local time if no task is selected.
        // Uses different colors to indicate whether the deadline is approaching, has passed, or is far away.
        // Triggered by a timer control at a regular interval.
        private void timer_Tick(object sender, EventArgs e)
        {
            if (tasksListBox.SelectedIndices.Count > 0)
            {
                int index = tasksListBox.SelectedIndex;
                TimeSpan timeLeft = taskManager.GetTask(index).DateTime - DateTime.Now;
                if (timeLeft.CompareTo(TimeSpan.Zero) < 0)
                {
                    timerLabel.Text = TimeSpan.Zero.ToString();
                    timerLabel.ForeColor = Color.Red;
                }
                else if (timeLeft < TimeSpan.FromHours(24))
                {
                    timerLabel.Text = (taskManager.GetTask(index).DateTime - DateTime.Now).ToString(@"hh\:mm\:ss");
                    timerLabel.ForeColor = Color.Yellow;
                }
                else
                {
                    timerLabel.Text = (taskManager.GetTask(index).DateTime - DateTime.Now).ToString(@"dd\:hh\:mm\:ss");
                    timerLabel.ForeColor = Color.LawnGreen;
                }
            }
            else
            {
                timerLabel.Text = DateTime.Now.ToString("hh:mm:ss");
            }
        }

        // This event handler is triggered when the user clicks on the "Add" button to create a new task.
        // If the descriptionTextBox is not empty, it creates a new Task object with the current date, selected priority, and description values entered by the user.
        // The new task is then added to the taskManager and the GUI is updated to reflect the new task.
        // If the descriptionTextBox is empty, it displays an error message.
        private void addButton_Click(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text.Trim().Length > 0)
            {
                DateTime dateTime = dateTimePicker.Value;
                PriorityType prio = (PriorityType)priorityComboBox.SelectedItem;
                string desc = descriptionTextBox.Text.Trim();

                Task task = new Task(dateTime, prio, desc);
                taskManager.AddTask(task);

                UpdateGUI();
            }
            else
            {
                MessageBox.Show("You need to submit some description", "Error input");
            }
        }

        // This event handler is triggered when the user clicks on the "Delete" button to remove a selected task.
        // If a task is selected in the tasksListBox, it displays a confirmation dialog to confirm deleting the task.
        // If the user confirms the deletion, the selected task is removed from the taskManager and the GUI is updated to reflect the change.
        // If no task is selected, it displays an error message.
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (tasksListBox.SelectedIndices.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this task?", "Delete Task",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int index = tasksListBox.SelectedIndex;
                    taskManager.RemoveTask(taskManager.GetTask(index));
                    UpdateGUI();
                }
            }
            else
            {
                MessageBox.Show("You must select a task!", "Error");
            }
        }

        // This event handler is triggered when the user clicks on the "Change" button while editing a task.
        // If a task is selected in the tasksListBox, it populates the editing fields with the task's current date, priority, and description values.
        // It also enables the "Done" and "Cancel" editing buttons, and disables the "Add" and "Delete" buttons.
        // If no task is selected, it displays an error message.
        private void changeButton_Click(object sender, EventArgs e)
        {
            if (tasksListBox.SelectedIndices.Count > 0)
            {
                int index = tasksListBox.SelectedIndex;
                Task task = taskManager.GetTask(index);

                dateTimePicker.Value = task.DateTime;
                descriptionTextBox.Text = task.Description;
                priorityComboBox.SelectedIndex = priorityComboBox.Items.IndexOf(task.Priority);

                doneEditingButton.Visible = true;
                cancelEditButton.Visible = true;

                DeleteButton.Visible = false;
                addButton.Visible = false;
            }
            else
            {
                MessageBox.Show("You must select a task!", "Error");
            }
        }


        private void cancelEditButton_Click(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        // This event handler is triggered when the user clicks on the "Done" button while editing a task.
        // It updates the task in the taskManager with the new date, priority, and description values entered by the user.
        // Finally, it updates the GUI to reflect the changes made to the task.
        private void doneEditingButton_Click(object sender, EventArgs e)
        {
            int index = tasksListBox.SelectedIndex;
            taskManager.GetTask(index).DateTime = dateTimePicker.Value;
            taskManager.GetTask(index).Priority = (PriorityType)priorityComboBox.SelectedItem;
            taskManager.GetTask(index).Description = descriptionTextBox.Text.Trim();

            UpdateGUI();
        }


        // This event handler is triggered when the user clicks on the "New" menu item in the main menu,
        //  or uses the Ctrl+N keyboard shortcut to create a new task list.
        // If there are unsaved tasks, it displays a confirmation message to confirm discarding them.
        // If the user confirms or there are no unsaved tasks, the task data is cleared and the GUI is updated to reflect the empty task list.
        private void NEWCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Your data might not be saved in a file, are you sure you want to create a new list?",
                                                  "Confirmation", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                taskManager.ClearTasks();
                UpdateGUI();
            }
        }

        // This event handler handles the user's request to open a text file containing task data.
        // If there are unsaved tasks, it displays a confirmation message to confirm discarding them.
        // If the user confirms or there are no unsaved tasks, the task data is cleared and the OpenFileDialog is displayed
        // to allow the user to select the file to open. If the user selects a file and clicks "OK", the task data is read from the file,
        // parsed from CSV format, and added to the taskManager. Finally, the GUI is updated to reflect the new task data.
        private void openDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (taskManager.GetTasks().Count > 0)
            {
                DialogResult answer = MessageBox.Show("Your data might not be saved in a file, are you sure you want to open a new one?",
                                                      "Confirmation", MessageBoxButtons.YesNo);
                if (answer == DialogResult.No) { return; }
            }

            taskManager.ClearTasks();
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Open a text file";
                dialog.Filter = "Text files (*.txt)|*.txt"; // only txt files
                dialog.InitialDirectory = @"C:\Users\UserName\Documents";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = dialog.FileName ?? filePath;
                    foreach (Task task in fileManager.ReadTasksFromCSV(fileName))
                    {
                        taskManager.AddTask(task);
                    }
                    UpdateGUI();
                }
            }
        }

        // This event handler is triggered when the user clicks on the "Save data file" menu item in the main menu.
        // It displays a SaveFileDialog to allow the user to select a location and file name for the text file that will store the task data.
        // If the user selects a file and clicks "OK", the task data is saved to the selected file in CSV format.
        // If the user cancels the dialog, nothing happens.
        private void saveDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Select a text file";
                dialog.Filter = "Text files (*.txt)|*.txt";
                dialog.InitialDirectory = @"C:\Users\UserName\Documents";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = dialog.FileName ?? filePath;
                    fileManager.WriteFile(taskManager.GetTasks().Aggregate("", (acc, x) => acc + x.ToCSV() + '\n'), filePath);
                }
            }
        }

        // This event handler is triggered when the user clicks on the "Exit" menu item in the main menu, or uses the Alt+F4 keyboard shortcut to close the form.
        // If there are unsaved tasks, it displays a message box to confirm whether the user wants to close the form.
        // If the user clicks "Yes", the form is closed. If the user clicks "No", the form remains open.
        // If there are no unsaved tasks, the form is closed immediately.
        private void exitAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (taskManager.GetTasks().Count > 0)
            {
                DialogResult answer = MessageBox.Show("Your data might not be saved in a file, are you sure you want to close?",
                                                      "Confirmation", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            this.Close();
        }


        // This creates an instance of the AboutBox form and displays it as a dialog box.
        // The dialog box provides information about the software, such as the version number and the author.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        // This event handler is triggered when the user attempts to close the form.
        // If there are unsaved tasks, it displays a message box to confirm whether the user wants to close the form.
        // If the user clicks "Yes", the form is closed. If the user clicks "No", the form remains open.
        private void ToDoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (taskManager.GetTasks().Count > 0)
            {
                DialogResult answer = MessageBox.Show("Your data might not be saved in a file, are you sure you want to close?",
                                                      "Confirmation", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    return;
                }
            }
        }


        // This is triggered when the mouse hovers over a DateTimePicker control.
        // It sets the tooltip text to explain how to select a date from the calendar control to be used as a task deadline.
        private void dateTimePicker_MouseHover(object sender, EventArgs e)
        {
            dateTimePickerToolTip.ToolTipTitle = "Date Selection";
            dateTimePickerToolTip.SetToolTip(dateTimePicker, "Select a date from the calendar, to be the deadline for your task.");
        }

        // Sets tooltip for timerLabel to show remaining time until task deadline.
        // If >24hrs, also displays days remaining. Shows local time if no task selected.
        private void timerLabel_MouseHover(object sender, EventArgs e)
        {
            timerLabelToolTip.ToolTipTitle = "Countdown timer";
            timerLabelToolTip.SetToolTip(timerLabel, "If a task is selected, this displays the time left untill the deadline of the task.\n" +
                                                     "If the time untill the deadline is > 24 hours, it also shows the days remaining.\n" +
                                                     "If no task is selected, the timer shows your local time.");
        }
    }

}