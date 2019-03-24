﻿namespace SomerenUI
{
    partial class SomerenUI
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
            System.Windows.Forms.ColumnHeader KamerNummer;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinkSupplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashregisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.imgDashboardLogo = new System.Windows.Forms.PictureBox();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.pnl_Revenue = new System.Windows.Forms.Panel();
            this.lbl_endDate = new System.Windows.Forms.Label();
            this.lbl_startDate = new System.Windows.Forms.Label();
            this.lbl_Revenue = new System.Windows.Forms.Label();
            this.listViewRevenue = new System.Windows.Forms.ListView();
            this.pnl_DrinkSupply = new System.Windows.Forms.Panel();
            this.lblDrankVoorraad = new System.Windows.Forms.Label();
            this.listViewDrankVoorraad = new System.Windows.Forms.ListView();
            this.imgStudentsLogo = new System.Windows.Forms.PictureBox();
            this.pnl_Students = new System.Windows.Forms.Panel();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Students = new System.Windows.Forms.Label();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.AantalBedden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Docentenkamer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Teachers = new System.Windows.Forms.Panel();
            this.listViewTeachers = new System.Windows.Forms.ListView();
            this.teacherId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teacherSupervisor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teacherVak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgTeachersLogo = new System.Windows.Forms.PictureBox();
            this.lbl_Teachers = new System.Windows.Forms.Label();
            this.pnl_Rooms = new System.Windows.Forms.Panel();
            this.imgRoomsLogo = new System.Windows.Forms.PictureBox();
            this.lblRooms = new System.Windows.Forms.Label();
            this.Sales = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Revenue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberOfCustomers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            KamerNummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboardLogo)).BeginInit();
            this.pnl_Revenue.SuspendLayout();
            this.pnl_DrinkSupply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudentsLogo)).BeginInit();
            this.pnl_Students.SuspendLayout();
            this.pnl_Teachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTeachersLogo)).BeginInit();
            this.pnl_Rooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRoomsLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // KamerNummer
            // 
            KamerNummer.Text = "Kamernummer";
            KamerNummer.Width = 100;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.barToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.dashboardToolStripMenuItem.Text = "Application";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.lecturersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // barToolStripMenuItem
            // 
            this.barToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drinkSupplyToolStripMenuItem,
            this.cashregisterToolStripMenuItem,
            this.revenueToolStripMenuItem});
            this.barToolStripMenuItem.Name = "barToolStripMenuItem";
            this.barToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.barToolStripMenuItem.Text = "Bar";
            // 
            // drinkSupplyToolStripMenuItem
            // 
            this.drinkSupplyToolStripMenuItem.Name = "drinkSupplyToolStripMenuItem";
            this.drinkSupplyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drinkSupplyToolStripMenuItem.Text = "Drink supply";
            this.drinkSupplyToolStripMenuItem.Click += new System.EventHandler(this.drinkSupplyToolStripMenuItem_Click);
            // 
            // cashregisterToolStripMenuItem
            // 
            this.cashregisterToolStripMenuItem.Name = "cashregisterToolStripMenuItem";
            this.cashregisterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cashregisterToolStripMenuItem.Text = "Cashregister";
            // 
            // revenueToolStripMenuItem
            // 
            this.revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            this.revenueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.revenueToolStripMenuItem.Text = "Revenue report";
            this.revenueToolStripMenuItem.Click += new System.EventHandler(this.revenueToolStripMenuItem_Click);
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.imgDashboardLogo);
            this.pnl_Dashboard.Controls.Add(this.lbl_Dashboard);
            this.pnl_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(940, 470);
            this.pnl_Dashboard.TabIndex = 2;
            // 
            // imgDashboardLogo
            // 
            this.imgDashboardLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgDashboardLogo.Image")));
            this.imgDashboardLogo.InitialImage = null;
            this.imgDashboardLogo.Location = new System.Drawing.Point(805, 0);
            this.imgDashboardLogo.Name = "imgDashboardLogo";
            this.imgDashboardLogo.Size = new System.Drawing.Size(130, 123);
            this.imgDashboardLogo.TabIndex = 2;
            this.imgDashboardLogo.TabStop = false;
            this.imgDashboardLogo.Click += new System.EventHandler(this.img_Dashboard_Click);
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(13, 13);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(185, 13);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnl_Revenue
            // 
            this.pnl_Revenue.Controls.Add(this.dateTimePickerEndDate);
            this.pnl_Revenue.Controls.Add(this.dateTimePickerStartDate);
            this.pnl_Revenue.Controls.Add(this.lbl_endDate);
            this.pnl_Revenue.Controls.Add(this.lbl_startDate);
            this.pnl_Revenue.Controls.Add(this.lbl_Revenue);
            this.pnl_Revenue.Controls.Add(this.listViewRevenue);
            this.pnl_Revenue.Location = new System.Drawing.Point(15, 30);
            this.pnl_Revenue.Name = "pnl_Revenue";
            this.pnl_Revenue.Size = new System.Drawing.Size(940, 470);
            this.pnl_Revenue.TabIndex = 3;
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.AutoSize = true;
            this.lbl_endDate.Location = new System.Drawing.Point(39, 126);
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(82, 13);
            this.lbl_endDate.TabIndex = 6;
            this.lbl_endDate.Text = "Select end date";
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.AutoSize = true;
            this.lbl_startDate.Location = new System.Drawing.Point(39, 62);
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(84, 13);
            this.lbl_startDate.TabIndex = 5;
            this.lbl_startDate.Text = "Select start date";
            // 
            // lbl_Revenue
            // 
            this.lbl_Revenue.AutoSize = true;
            this.lbl_Revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Revenue.Location = new System.Drawing.Point(32, 10);
            this.lbl_Revenue.Name = "lbl_Revenue";
            this.lbl_Revenue.Size = new System.Drawing.Size(109, 29);
            this.lbl_Revenue.TabIndex = 1;
            this.lbl_Revenue.Text = "Revenue";
            // 
            // listViewRevenue
            // 
            this.listViewRevenue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sales,
            this.Revenue,
            this.NumberOfCustomers});
            this.listViewRevenue.Location = new System.Drawing.Point(37, 238);
            this.listViewRevenue.Name = "listViewRevenue";
            this.listViewRevenue.Size = new System.Drawing.Size(380, 195);
            this.listViewRevenue.TabIndex = 0;
            this.listViewRevenue.UseCompatibleStateImageBehavior = false;
            this.listViewRevenue.View = System.Windows.Forms.View.Details;
            // 
            // pnl_DrinkSupply
            // 
            this.pnl_DrinkSupply.Controls.Add(this.lblDrankVoorraad);
            this.pnl_DrinkSupply.Controls.Add(this.listViewDrankVoorraad);
            this.pnl_DrinkSupply.Location = new System.Drawing.Point(15, 30);
            this.pnl_DrinkSupply.Name = "pnl_DrinkSupply";
            this.pnl_DrinkSupply.Size = new System.Drawing.Size(940, 470);
            this.pnl_DrinkSupply.TabIndex = 8;
            // 
            // lblDrankVoorraad
            // 
            this.lblDrankVoorraad.AutoSize = true;
            this.lblDrankVoorraad.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrankVoorraad.Location = new System.Drawing.Point(10, 10);
            this.lblDrankVoorraad.Name = "lblDrankVoorraad";
            this.lblDrankVoorraad.Size = new System.Drawing.Size(145, 29);
            this.lblDrankVoorraad.TabIndex = 3;
            this.lblDrankVoorraad.Text = "Drink supply";
            // 
            // listViewDrankVoorraad
            // 
            this.listViewDrankVoorraad.BackColor = System.Drawing.Color.Yellow;
            this.listViewDrankVoorraad.ForeColor = System.Drawing.Color.Yellow;
            this.listViewDrankVoorraad.Location = new System.Drawing.Point(16, 42);
            this.listViewDrankVoorraad.Name = "listViewDrankVoorraad";
            this.listViewDrankVoorraad.Size = new System.Drawing.Size(121, 97);
            this.listViewDrankVoorraad.TabIndex = 0;
            this.listViewDrankVoorraad.UseCompatibleStateImageBehavior = false;
            this.listViewDrankVoorraad.View = System.Windows.Forms.View.Details;
            // 
            // imgStudentsLogo
            // 
            this.imgStudentsLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgStudentsLogo.Image")));
            this.imgStudentsLogo.InitialImage = null;
            this.imgStudentsLogo.Location = new System.Drawing.Point(805, 0);
            this.imgStudentsLogo.Name = "imgStudentsLogo";
            this.imgStudentsLogo.Size = new System.Drawing.Size(130, 123);
            this.imgStudentsLogo.TabIndex = 0;
            this.imgStudentsLogo.TabStop = false;
            // 
            // pnl_Students
            // 
            this.pnl_Students.Controls.Add(this.listViewStudents);
            this.pnl_Students.Controls.Add(this.imgStudentsLogo);
            this.pnl_Students.Controls.Add(this.lbl_Students);
            this.pnl_Students.Location = new System.Drawing.Point(15, 30);
            this.pnl_Students.Name = "pnl_Students";
            this.pnl_Students.Size = new System.Drawing.Size(940, 470);
            this.pnl_Students.TabIndex = 4;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName,
            this.studentDOB});
            this.listViewStudents.Location = new System.Drawing.Point(16, 42);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(766, 307);
            this.listViewStudents.TabIndex = 5;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // studentID
            // 
            this.studentID.Text = "ID";
            // 
            // studentName
            // 
            this.studentName.Text = "Name";
            // 
            // studentDOB
            // 
            this.studentDOB.Text = "Date of Birth";
            // 
            // lbl_Students
            // 
            this.lbl_Students.AutoSize = true;
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Students.Location = new System.Drawing.Point(10, 10);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(107, 29);
            this.lbl_Students.TabIndex = 3;
            this.lbl_Students.Text = "Students";
            // 
            // listViewRooms
            // 
            this.listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            KamerNummer,
            this.AantalBedden,
            this.Docentenkamer});
            this.listViewRooms.Location = new System.Drawing.Point(16, 42);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(766, 307);
            this.listViewRooms.TabIndex = 5;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            this.listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // AantalBedden
            // 
            this.AantalBedden.Text = "AantalBedden";
            this.AantalBedden.Width = 100;
            // 
            // Docentenkamer
            // 
            this.Docentenkamer.Text = "DocentenKamer";
            this.Docentenkamer.Width = 100;
            // 
            // pnl_Teachers
            // 
            this.pnl_Teachers.Controls.Add(this.listViewTeachers);
            this.pnl_Teachers.Controls.Add(this.imgTeachersLogo);
            this.pnl_Teachers.Controls.Add(this.lbl_Teachers);
            this.pnl_Teachers.Location = new System.Drawing.Point(15, 30);
            this.pnl_Teachers.Name = "pnl_Teachers";
            this.pnl_Teachers.Size = new System.Drawing.Size(940, 470);
            this.pnl_Teachers.TabIndex = 6;
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.teacherId,
            this.teacherSupervisor,
            this.teacherVak});
            this.listViewTeachers.Location = new System.Drawing.Point(16, 42);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(766, 307);
            this.listViewTeachers.TabIndex = 5;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            this.listViewTeachers.View = System.Windows.Forms.View.Details;
            // 
            // teacherId
            // 
            this.teacherId.Text = "ID";
            this.teacherId.Width = 54;
            // 
            // teacherSupervisor
            // 
            this.teacherSupervisor.Text = "Name";
            this.teacherSupervisor.Width = 132;
            // 
            // teacherVak
            // 
            this.teacherVak.Text = "Supervisor";
            this.teacherVak.Width = 134;
            // 
            // imgTeachersLogo
            // 
            this.imgTeachersLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgTeachersLogo.Image")));
            this.imgTeachersLogo.InitialImage = null;
            this.imgTeachersLogo.Location = new System.Drawing.Point(805, 0);
            this.imgTeachersLogo.Name = "imgTeachersLogo";
            this.imgTeachersLogo.Size = new System.Drawing.Size(130, 123);
            this.imgTeachersLogo.TabIndex = 0;
            this.imgTeachersLogo.TabStop = false;
            // 
            // lbl_Teachers
            // 
            this.lbl_Teachers.AutoSize = true;
            this.lbl_Teachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Teachers.Location = new System.Drawing.Point(10, 10);
            this.lbl_Teachers.Name = "lbl_Teachers";
            this.lbl_Teachers.Size = new System.Drawing.Size(113, 29);
            this.lbl_Teachers.TabIndex = 3;
            this.lbl_Teachers.Text = "Lecturers";
            // 
            // pnl_Rooms
            // 
            this.pnl_Rooms.Controls.Add(this.listViewRooms);
            this.pnl_Rooms.Controls.Add(this.pnl_Dashboard);
            this.pnl_Rooms.Controls.Add(this.imgRoomsLogo);
            this.pnl_Rooms.Controls.Add(this.lblRooms);
            this.pnl_Rooms.Location = new System.Drawing.Point(15, 30);
            this.pnl_Rooms.Name = "pnl_Rooms";
            this.pnl_Rooms.Size = new System.Drawing.Size(940, 470);
            this.pnl_Rooms.TabIndex = 7;
            // 
            // imgRoomsLogo
            // 
            this.imgRoomsLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgRoomsLogo.Image")));
            this.imgRoomsLogo.InitialImage = null;
            this.imgRoomsLogo.Location = new System.Drawing.Point(805, 0);
            this.imgRoomsLogo.Name = "imgRoomsLogo";
            this.imgRoomsLogo.Size = new System.Drawing.Size(130, 123);
            this.imgRoomsLogo.TabIndex = 0;
            this.imgRoomsLogo.TabStop = false;
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRooms.Location = new System.Drawing.Point(10, 10);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(78, 29);
            this.lblRooms.TabIndex = 1;
            this.lblRooms.Text = "Room";
            // 
            // Sales
            // 
            this.Sales.Text = "Sales";
            this.Sales.Width = 117;
            // 
            // Revenue
            // 
            this.Revenue.Text = "Revenue";
            this.Revenue.Width = 105;
            // 
            // NumberOfCustomers
            // 
            this.NumberOfCustomers.Text = "Number of customers";
            this.NumberOfCustomers.Width = 148;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(37, 78);
            this.dateTimePickerStartDate.MaxDate = new System.DateTime(2019, 5, 14, 0, 0, 0, 0);
            this.dateTimePickerStartDate.MinDate = new System.DateTime(2019, 5, 13, 0, 0, 0, 0);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 7;
            this.dateTimePickerStartDate.Value = new System.DateTime(2019, 5, 13, 0, 0, 0, 0);
            this.dateTimePickerStartDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(37, 146);
            this.dateTimePickerEndDate.MaxDate = new System.DateTime(2019, 5, 14, 0, 0, 0, 0);
            this.dateTimePickerEndDate.MinDate = new System.DateTime(2019, 5, 13, 0, 0, 0, 0);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 8;
            this.dateTimePickerEndDate.Value = new System.DateTime(2019, 5, 13, 0, 0, 0, 0);
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 505);
            this.Controls.Add(this.pnl_Revenue);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnl_Rooms);
            this.Controls.Add(this.pnl_Teachers);
            this.Controls.Add(this.pnl_Students);
            this.Controls.Add(this.pnl_DrinkSupply);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboardLogo)).EndInit();
            this.pnl_Revenue.ResumeLayout(false);
            this.pnl_Revenue.PerformLayout();
            this.pnl_DrinkSupply.ResumeLayout(false);
            this.pnl_DrinkSupply.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudentsLogo)).EndInit();
            this.pnl_Students.ResumeLayout(false);
            this.pnl_Students.PerformLayout();
            this.pnl_Teachers.ResumeLayout(false);
            this.pnl_Teachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTeachersLogo)).EndInit();
            this.pnl_Rooms.ResumeLayout(false);
            this.pnl_Rooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRoomsLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Dashboard;
        private System.Windows.Forms.Label lbl_Dashboard;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgStudentsLogo;
        private System.Windows.Forms.Panel pnl_Students;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentDOB;
        private System.Windows.Forms.Label lbl_Students;
        private System.Windows.Forms.Panel pnl_Teachers;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ColumnHeader teacherId;
        private System.Windows.Forms.ColumnHeader teacherSupervisor;
        private System.Windows.Forms.ColumnHeader teacherVak;
        private System.Windows.Forms.PictureBox imgTeachersLogo;
        private System.Windows.Forms.Label lbl_Teachers;
        private System.Windows.Forms.Panel pnl_Rooms;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ColumnHeader AantalBedden;
        private System.Windows.Forms.ColumnHeader Docentenkamer;
        private System.Windows.Forms.PictureBox imgRoomsLogo;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.Panel pnl_DrinkSupply;
        private System.Windows.Forms.PictureBox imgDashboardLogo;
        private System.Windows.Forms.ListView listViewDrankVoorraad;
        private System.Windows.Forms.Label lblDrankVoorraad;
        private System.Windows.Forms.ToolStripMenuItem barToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drinkSupplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashregisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Revenue;
        private System.Windows.Forms.Label lbl_Revenue;
        private System.Windows.Forms.ListView listViewRevenue;
        private System.Windows.Forms.Label lbl_endDate;
        private System.Windows.Forms.Label lbl_startDate;
        private System.Windows.Forms.ColumnHeader Sales;
        private System.Windows.Forms.ColumnHeader Revenue;
        private System.Windows.Forms.ColumnHeader NumberOfCustomers;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
    }
}

