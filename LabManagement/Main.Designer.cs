﻿namespace LabManagement
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Calendar = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImportScheduleButton = new System.Windows.Forms.Button();
            this.Classes = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Lockers = new System.Windows.Forms.TabPage();
            this.buttonSendCombo = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.Edit = new System.Windows.Forms.TabControl();
            this.Configuration = new System.Windows.Forms.TabPage();
            this.LockerTypes = new System.Windows.Forms.TabPage();
            this.Print = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.Parts = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Rooms = new System.Windows.Forms.TabPage();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Users = new System.Windows.Forms.TabPage();
            this.userDataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Settings = new System.Windows.Forms.TabPage();
            this.Description = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabControl1.SuspendLayout();
            this.Calendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Classes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Lockers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.Edit.SuspendLayout();
            this.Parts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Rooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Calendar);
            this.tabControl1.Controls.Add(this.Classes);
            this.tabControl1.Controls.Add(this.Lockers);
            this.tabControl1.Controls.Add(this.Parts);
            this.tabControl1.Controls.Add(this.Rooms);
            this.tabControl1.Controls.Add(this.Users);
            this.tabControl1.Controls.Add(this.Settings);
            this.tabControl1.Location = new System.Drawing.Point(3, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 591);
            this.tabControl1.TabIndex = 0;
            // 
            // Calendar
            // 
            this.Calendar.Controls.Add(this.button6);
            this.Calendar.Controls.Add(this.button5);
            this.Calendar.Controls.Add(this.button4);
            this.Calendar.Controls.Add(this.pictureBox1);
            this.Calendar.Controls.Add(this.ImportScheduleButton);
            this.Calendar.Location = new System.Drawing.Point(4, 22);
            this.Calendar.Name = "Calendar";
            this.Calendar.Padding = new System.Windows.Forms.Padding(3);
            this.Calendar.Size = new System.Drawing.Size(791, 565);
            this.Calendar.TabIndex = 0;
            this.Calendar.Text = "Calendar";
            this.Calendar.UseVisualStyleBackColor = true;
            this.Calendar.Click += new System.EventHandler(this.Calendar_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(162, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(162, 64);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(162, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Upload";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ImportScheduleButton
            // 
            this.ImportScheduleButton.Location = new System.Drawing.Point(162, 6);
            this.ImportScheduleButton.Name = "ImportScheduleButton";
            this.ImportScheduleButton.Size = new System.Drawing.Size(107, 23);
            this.ImportScheduleButton.TabIndex = 0;
            this.ImportScheduleButton.Text = "Import Schedule";
            this.ImportScheduleButton.UseVisualStyleBackColor = true;
            this.ImportScheduleButton.Click += new System.EventHandler(this.ImportSchedule_Click);
            // 
            // Classes
            // 
            this.Classes.Controls.Add(this.button7);
            this.Classes.Controls.Add(this.pictureBox2);
            this.Classes.Controls.Add(this.button2);
            this.Classes.Location = new System.Drawing.Point(4, 22);
            this.Classes.Name = "Classes";
            this.Classes.Padding = new System.Windows.Forms.Padding(3);
            this.Classes.Size = new System.Drawing.Size(791, 565);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(162, 35);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "Edit";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Lockers
            // 
            this.Lockers.Controls.Add(this.buttonSendCombo);
            this.Lockers.Controls.Add(this.pictureBox7);
            this.Lockers.Controls.Add(this.Edit);
            this.Lockers.Controls.Add(this.Print);
            this.Lockers.Controls.Add(this.Import);
            this.Lockers.Location = new System.Drawing.Point(4, 22);
            this.Lockers.Name = "Lockers";
            this.Lockers.Padding = new System.Windows.Forms.Padding(3);
            this.Lockers.Size = new System.Drawing.Size(791, 565);
            this.Lockers.TabIndex = 2;
            this.Lockers.Text = "Lockers";
            this.Lockers.UseVisualStyleBackColor = true;
            this.Lockers.Click += new System.EventHandler(this.Lockers_Click);
            // 
            // buttonSendCombo
            // 
            this.buttonSendCombo.Location = new System.Drawing.Point(162, 64);
            this.buttonSendCombo.Name = "buttonSendCombo";
            this.buttonSendCombo.Size = new System.Drawing.Size(107, 23);
            this.buttonSendCombo.TabIndex = 7;
            this.buttonSendCombo.Text = "Email Combinations";
            this.buttonSendCombo.UseVisualStyleBackColor = true;
            this.buttonSendCombo.Click += new System.EventHandler(this.buttonSendCombinations);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(6, 6);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(150, 150);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // Edit
            // 
            this.Edit.Controls.Add(this.Configuration);
            this.Edit.Controls.Add(this.LockerTypes);
            this.Edit.Location = new System.Drawing.Point(5, 162);
            this.Edit.Name = "Edit";
            this.Edit.SelectedIndex = 0;
            this.Edit.Size = new System.Drawing.Size(784, 293);
            this.Edit.TabIndex = 5;
            // 
            // Configuration
            // 
            this.Configuration.Location = new System.Drawing.Point(4, 22);
            this.Configuration.Name = "Configuration";
            this.Configuration.Padding = new System.Windows.Forms.Padding(3);
            this.Configuration.Size = new System.Drawing.Size(776, 267);
            this.Configuration.TabIndex = 0;
            this.Configuration.Text = "Configuration";
            this.Configuration.UseVisualStyleBackColor = true;
            this.Configuration.Click += new System.EventHandler(this.Configuration_Click);
            // 
            // LockerTypes
            // 
            this.LockerTypes.Location = new System.Drawing.Point(4, 22);
            this.LockerTypes.Name = "LockerTypes";
            this.LockerTypes.Padding = new System.Windows.Forms.Padding(3);
            this.LockerTypes.Size = new System.Drawing.Size(776, 267);
            this.LockerTypes.TabIndex = 1;
            this.LockerTypes.Text = "Locker Types";
            this.LockerTypes.UseVisualStyleBackColor = true;
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(162, 35);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(107, 23);
            this.Print.TabIndex = 4;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(162, 6);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(107, 23);
            this.Import.TabIndex = 3;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            // 
            // Parts
            // 
            this.Parts.Controls.Add(this.button11);
            this.Parts.Controls.Add(this.button10);
            this.Parts.Controls.Add(this.button9);
            this.Parts.Controls.Add(this.button8);
            this.Parts.Controls.Add(this.pictureBox3);
            this.Parts.Location = new System.Drawing.Point(4, 22);
            this.Parts.Name = "Parts";
            this.Parts.Size = new System.Drawing.Size(791, 565);
            this.Parts.TabIndex = 3;
            this.Parts.Text = "Parts";
            this.Parts.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(161, 61);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(67, 23);
            this.button11.TabIndex = 8;
            this.button11.Text = "Inventory";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(161, 90);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(67, 23);
            this.button10.TabIndex = 7;
            this.button10.Text = "Locations";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(161, 32);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 23);
            this.button9.TabIndex = 6;
            this.button9.Text = "Add";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(161, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 23);
            this.button8.TabIndex = 5;
            this.button8.Text = "Edit";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(5, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Rooms
            // 
            this.Rooms.Controls.Add(this.button14);
            this.Rooms.Controls.Add(this.button13);
            this.Rooms.Controls.Add(this.button12);
            this.Rooms.Controls.Add(this.pictureBox4);
            this.Rooms.Location = new System.Drawing.Point(4, 22);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(791, 565);
            this.Rooms.TabIndex = 4;
            this.Rooms.Text = "Rooms";
            this.Rooms.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(161, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(67, 23);
            this.button14.TabIndex = 8;
            this.button14.Text = "Edit";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(161, 32);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(67, 23);
            this.button13.TabIndex = 7;
            this.button13.Text = "Storage";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(161, 61);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(67, 23);
            this.button12.TabIndex = 6;
            this.button12.Text = "Locations";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(5, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 150);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // Users
            // 
            this.Users.Controls.Add(this.userDataGrid);
            this.Users.Controls.Add(this.pictureBox5);
            this.Users.Location = new System.Drawing.Point(4, 22);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(791, 565);
            this.Users.TabIndex = 5;
            this.Users.Text = "Users";
            this.Users.UseVisualStyleBackColor = true;
            // 
            // userDataGrid
            // 
            this.userDataGrid.AllowUserToOrderColumns = true;
            this.userDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.firstName,
            this.lastName,
            this.emailAddress,
            this.userType});
            this.userDataGrid.Location = new System.Drawing.Point(5, 159);
            this.userDataGrid.Name = "userDataGrid";
            this.userDataGrid.Size = new System.Drawing.Size(782, 402);
            this.userDataGrid.TabIndex = 5;
            this.userDataGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView_CellEdit);
            this.userDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.userDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.userDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
            this.userDataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.userDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.userDataGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.userDataGrid_RowStateChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First";
            this.firstName.Name = "firstName";
            this.firstName.Width = 200;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last";
            this.lastName.Name = "lastName";
            this.lastName.Width = 200;
            // 
            // emailAddress
            // 
            this.emailAddress.HeaderText = "email";
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.Width = 200;
            // 
            // userType
            // 
            this.userType.HeaderText = " User Type";
            this.userType.Name = "userType";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(5, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(150, 150);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.Description);
            this.Settings.Controls.Add(this.Version);
            this.Settings.Controls.Add(this.pictureBox6);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(791, 565);
            this.Settings.TabIndex = 6;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(530, 30);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 13);
            this.Description.TabIndex = 7;
            this.Description.Text = "Description";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(530, 3);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(42, 13);
            this.Version.TabIndex = 6;
            this.Version.Text = "Version";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(150, 150);
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 601);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "EE Lab Management";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.Calendar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Classes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Lockers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.Edit.ResumeLayout(false);
            this.Parts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Rooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Calendar;
        private System.Windows.Forms.Button ImportScheduleButton;
        private System.Windows.Forms.TabPage Classes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage Parts;
        private System.Windows.Forms.TabPage Rooms;
        private System.Windows.Forms.TabPage Users;
        private System.Windows.Forms.TabPage Lockers;
        private System.Windows.Forms.TabControl Edit;
        private System.Windows.Forms.TabPage Configuration;
        private System.Windows.Forms.TabPage LockerTypes;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button buttonSendCombo;
        private System.Windows.Forms.DataGridView userDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn userType;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label Description;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}