namespace Assignment_6
{
    partial class ToDoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            changeButton = new Button();
            DeleteButton = new Button();
            addButton = new Button();
            toDoGroupBox = new GroupBox();
            descLabel = new Label();
            prioLabel = new Label();
            timeLabel = new Label();
            dateLabel = new Label();
            tasksListBox = new ListBox();
            descriptionTextBox = new TextBox();
            priorityComboBox = new ComboBox();
            dateTimePicker = new DateTimePicker();
            dateAndTimeLabel = new Label();
            toDoLabel = new Label();
            PriorityLabel = new Label();
            timer = new System.Windows.Forms.Timer(components);
            timerLabel = new Label();
            menuStrip = new MenuStrip();
            fileCTRLNToolStripMenuItem = new ToolStripMenuItem();
            nEWCtrlNToolStripMenuItem = new ToolStripMenuItem();
            openDataFileToolStripMenuItem = new ToolStripMenuItem();
            saveDataFileToolStripMenuItem = new ToolStripMenuItem();
            exitAltF4ToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            doneEditingButton = new Button();
            cancelEditButton = new Button();
            dateTimePickerToolTip = new ToolTip(components);
            timerLabelToolTip = new ToolTip(components);
            toDoGroupBox.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // changeButton
            // 
            changeButton.Location = new Point(92, 687);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(156, 44);
            changeButton.TabIndex = 0;
            changeButton.Text = "Change";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(357, 687);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(156, 44);
            DeleteButton.TabIndex = 1;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(357, 182);
            addButton.Name = "addButton";
            addButton.Size = new Size(194, 33);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // toDoGroupBox
            // 
            toDoGroupBox.Controls.Add(descLabel);
            toDoGroupBox.Controls.Add(prioLabel);
            toDoGroupBox.Controls.Add(timeLabel);
            toDoGroupBox.Controls.Add(dateLabel);
            toDoGroupBox.Controls.Add(tasksListBox);
            toDoGroupBox.Location = new Point(17, 221);
            toDoGroupBox.Name = "toDoGroupBox";
            toDoGroupBox.Size = new Size(1429, 460);
            toDoGroupBox.TabIndex = 3;
            toDoGroupBox.TabStop = false;
            toDoGroupBox.Text = "To Do";
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Location = new Point(545, 36);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(102, 25);
            descLabel.TabIndex = 12;
            descLabel.Text = "Description";
            // 
            // prioLabel
            // 
            prioLabel.AutoSize = true;
            prioLabel.Location = new Point(380, 36);
            prioLabel.Name = "prioLabel";
            prioLabel.Size = new Size(68, 25);
            prioLabel.TabIndex = 11;
            prioLabel.Text = "Priority";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(209, 36);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(52, 25);
            timeLabel.TabIndex = 10;
            timeLabel.Text = "Hour";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(38, 27);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(49, 25);
            dateLabel.TabIndex = 9;
            dateLabel.Text = "Date";
            // 
            // tasksListBox
            // 
            tasksListBox.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tasksListBox.FormattingEnabled = true;
            tasksListBox.ItemHeight = 24;
            tasksListBox.Location = new Point(23, 64);
            tasksListBox.Name = "tasksListBox";
            tasksListBox.Size = new Size(1385, 364);
            tasksListBox.TabIndex = 0;
            tasksListBox.SelectedIndexChanged += toDolistBox_SelectedIndexChanged;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(148, 140);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(884, 31);
            descriptionTextBox.TabIndex = 4;
            // 
            // priorityComboBox
            // 
            priorityComboBox.FormattingEnabled = true;
            priorityComboBox.Location = new Point(850, 80);
            priorityComboBox.Name = "priorityComboBox";
            priorityComboBox.Size = new Size(182, 33);
            priorityComboBox.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(280, 78);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(300, 31);
            dateTimePicker.TabIndex = 6;
            dateTimePicker.MouseHover += dateTimePicker_MouseHover;
            // 
            // dateAndTimeLabel
            // 
            dateAndTimeLabel.AutoSize = true;
            dateAndTimeLabel.Location = new Point(69, 80);
            dateAndTimeLabel.Name = "dateAndTimeLabel";
            dateAndTimeLabel.Size = new Size(124, 25);
            dateAndTimeLabel.TabIndex = 7;
            dateAndTimeLabel.Text = "Date and time";
            // 
            // toDoLabel
            // 
            toDoLabel.AutoSize = true;
            toDoLabel.Location = new Point(69, 146);
            toDoLabel.Name = "toDoLabel";
            toDoLabel.Size = new Size(57, 25);
            toDoLabel.TabIndex = 8;
            toDoLabel.Text = "To do";
            // 
            // PriorityLabel
            // 
            PriorityLabel.AutoSize = true;
            PriorityLabel.Location = new Point(756, 83);
            PriorityLabel.Name = "PriorityLabel";
            PriorityLabel.Size = new Size(68, 25);
            PriorityLabel.TabIndex = 9;
            PriorityLabel.Text = "Priority";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            timerLabel.Location = new Point(1199, 687);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(131, 60);
            timerLabel.TabIndex = 10;
            timerLabel.Text = "00:00";
            timerLabel.MouseHover += timerLabel_MouseHover;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileCTRLNToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1469, 33);
            menuStrip.TabIndex = 11;
            menuStrip.Text = "menuStrip";
            // 
            // fileCTRLNToolStripMenuItem
            // 
            fileCTRLNToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nEWCtrlNToolStripMenuItem, openDataFileToolStripMenuItem, saveDataFileToolStripMenuItem, exitAltF4ToolStripMenuItem });
            fileCTRLNToolStripMenuItem.Name = "fileCTRLNToolStripMenuItem";
            fileCTRLNToolStripMenuItem.Size = new Size(54, 29);
            fileCTRLNToolStripMenuItem.Text = "File";
            // 
            // nEWCtrlNToolStripMenuItem
            // 
            nEWCtrlNToolStripMenuItem.Name = "nEWCtrlNToolStripMenuItem";
            nEWCtrlNToolStripMenuItem.Size = new Size(291, 34);
            nEWCtrlNToolStripMenuItem.Text = "New                Ctrl + N";
            nEWCtrlNToolStripMenuItem.Click += NEWCtrlNToolStripMenuItem_Click;
            // 
            // openDataFileToolStripMenuItem
            // 
            openDataFileToolStripMenuItem.Name = "openDataFileToolStripMenuItem";
            openDataFileToolStripMenuItem.Size = new Size(291, 34);
            openDataFileToolStripMenuItem.Text = "Open data file";
            openDataFileToolStripMenuItem.Click += openDataFileToolStripMenuItem_Click;
            // 
            // saveDataFileToolStripMenuItem
            // 
            saveDataFileToolStripMenuItem.Name = "saveDataFileToolStripMenuItem";
            saveDataFileToolStripMenuItem.Size = new Size(291, 34);
            saveDataFileToolStripMenuItem.Text = "Save data file";
            saveDataFileToolStripMenuItem.Click += saveDataFileToolStripMenuItem_Click;
            // 
            // exitAltF4ToolStripMenuItem
            // 
            exitAltF4ToolStripMenuItem.Name = "exitAltF4ToolStripMenuItem";
            exitAltF4ToolStripMenuItem.Size = new Size(291, 34);
            exitAltF4ToolStripMenuItem.Text = "Exit              Alt + F4";
            exitAltF4ToolStripMenuItem.Click += exitAltF4ToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(164, 34);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // doneEditingButton
            // 
            doneEditingButton.Location = new Point(598, 182);
            doneEditingButton.Name = "doneEditingButton";
            doneEditingButton.Size = new Size(194, 33);
            doneEditingButton.TabIndex = 12;
            doneEditingButton.Text = "Done editing";
            doneEditingButton.UseVisualStyleBackColor = true;
            doneEditingButton.Visible = false;
            doneEditingButton.Click += doneEditingButton_Click;
            // 
            // cancelEditButton
            // 
            cancelEditButton.Location = new Point(838, 182);
            cancelEditButton.Name = "cancelEditButton";
            cancelEditButton.Size = new Size(194, 33);
            cancelEditButton.TabIndex = 13;
            cancelEditButton.Text = "Cancel editing";
            cancelEditButton.UseVisualStyleBackColor = true;
            cancelEditButton.Visible = false;
            cancelEditButton.Click += cancelEditButton_Click;
            // 
            // ToDoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1469, 750);
            Controls.Add(cancelEditButton);
            Controls.Add(doneEditingButton);
            Controls.Add(timerLabel);
            Controls.Add(PriorityLabel);
            Controls.Add(toDoLabel);
            Controls.Add(dateAndTimeLabel);
            Controls.Add(dateTimePicker);
            Controls.Add(priorityComboBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(toDoGroupBox);
            Controls.Add(addButton);
            Controls.Add(DeleteButton);
            Controls.Add(changeButton);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            Name = "ToDoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ToDo Reminder by Viktor Hansson";
            FormClosing += ToDoForm_FormClosing;
            toDoGroupBox.ResumeLayout(false);
            toDoGroupBox.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button changeButton;
        private Button DeleteButton;
        private Button addButton;
        private GroupBox toDoGroupBox;
        private ListBox tasksListBox;
        private TextBox descriptionTextBox;
        private ComboBox priorityComboBox;
        private DateTimePicker dateTimePicker;
        private Label dateAndTimeLabel;
        private Label toDoLabel;
        private Label PriorityLabel;
        private Label descLabel;
        private Label prioLabel;
        private Label timeLabel;
        private Label dateLabel;
        private System.Windows.Forms.Timer timer;
        private Label timerLabel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileCTRLNToolStripMenuItem;
        private ToolStripMenuItem nEWCtrlNToolStripMenuItem;
        private ToolStripMenuItem openDataFileToolStripMenuItem;
        private ToolStripMenuItem saveDataFileToolStripMenuItem;
        private ToolStripMenuItem exitAltF4ToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button doneEditingButton;
        private Button cancelEditButton;
        private ToolTip dateTimePickerToolTip;
        private ToolTip timerLabelToolTip;
    }
}