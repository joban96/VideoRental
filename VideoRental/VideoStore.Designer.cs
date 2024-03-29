﻿namespace VideoRental
{
    partial class VideoStore
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.CustomerAddress = new System.Windows.Forms.TextBox();
            this.CustomerContact = new System.Windows.Forms.TextBox();
            this.CustomerInsert = new System.Windows.Forms.Button();
            this.CustomerUpdate = new System.Windows.Forms.Button();
            this.CustomerDelete = new System.Windows.Forms.Button();
            this.RentalVideoDelete = new System.Windows.Forms.Button();
            this.VideoReturn = new System.Windows.Forms.Button();
            this.VideoRental = new System.Windows.Forms.Button();
            this.RentalCustomerID = new System.Windows.Forms.TextBox();
            this.RentalVideoID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RentalVideoDate = new System.Windows.Forms.DateTimePicker();
            this.ReturnVideoDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.Ratting = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Copies = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Plot = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.VideoDelete = new System.Windows.Forms.Button();
            this.VideoUpdate = new System.Windows.Forms.Button();
            this.VideoInsert = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.CustomerData = new System.Windows.Forms.Button();
            this.VideoData = new System.Windows.Forms.Button();
            this.RentalData = new System.Windows.Forms.Button();
            this.btnTopCustomer = new System.Windows.Forms.Button();
            this.btnMovieCount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact No";
            // 
            // CustomerName
            // 
            this.CustomerName.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(164, 78);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(173, 37);
            this.CustomerName.TabIndex = 4;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAddress.Location = new System.Drawing.Point(164, 128);
            this.CustomerAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.Size = new System.Drawing.Size(173, 37);
            this.CustomerAddress.TabIndex = 5;
            // 
            // CustomerContact
            // 
            this.CustomerContact.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerContact.Location = new System.Drawing.Point(164, 177);
            this.CustomerContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerContact.Name = "CustomerContact";
            this.CustomerContact.Size = new System.Drawing.Size(173, 37);
            this.CustomerContact.TabIndex = 6;
            // 
            // CustomerInsert
            // 
            this.CustomerInsert.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerInsert.Location = new System.Drawing.Point(23, 239);
            this.CustomerInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerInsert.Name = "CustomerInsert";
            this.CustomerInsert.Size = new System.Drawing.Size(115, 46);
            this.CustomerInsert.TabIndex = 7;
            this.CustomerInsert.Text = "Insert";
            this.CustomerInsert.UseVisualStyleBackColor = true;
            this.CustomerInsert.Click += new System.EventHandler(this.CustomerInsert_Click);
            // 
            // CustomerUpdate
            // 
            this.CustomerUpdate.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerUpdate.Location = new System.Drawing.Point(145, 239);
            this.CustomerUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerUpdate.Name = "CustomerUpdate";
            this.CustomerUpdate.Size = new System.Drawing.Size(115, 46);
            this.CustomerUpdate.TabIndex = 8;
            this.CustomerUpdate.Text = "Update";
            this.CustomerUpdate.UseVisualStyleBackColor = true;
            this.CustomerUpdate.Click += new System.EventHandler(this.CustomerUpdate_Click);
            // 
            // CustomerDelete
            // 
            this.CustomerDelete.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDelete.Location = new System.Drawing.Point(268, 239);
            this.CustomerDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerDelete.Name = "CustomerDelete";
            this.CustomerDelete.Size = new System.Drawing.Size(115, 46);
            this.CustomerDelete.TabIndex = 9;
            this.CustomerDelete.Text = "Delete";
            this.CustomerDelete.UseVisualStyleBackColor = true;
            this.CustomerDelete.Click += new System.EventHandler(this.CustomerDelete_Click);
            // 
            // RentalVideoDelete
            // 
            this.RentalVideoDelete.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalVideoDelete.Location = new System.Drawing.Point(268, 623);
            this.RentalVideoDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RentalVideoDelete.Name = "RentalVideoDelete";
            this.RentalVideoDelete.Size = new System.Drawing.Size(115, 46);
            this.RentalVideoDelete.TabIndex = 19;
            this.RentalVideoDelete.Text = "Delete";
            this.RentalVideoDelete.UseVisualStyleBackColor = true;
            this.RentalVideoDelete.Click += new System.EventHandler(this.RentalVideoDelete_Click);
            // 
            // VideoReturn
            // 
            this.VideoReturn.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoReturn.Location = new System.Drawing.Point(145, 623);
            this.VideoReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VideoReturn.Name = "VideoReturn";
            this.VideoReturn.Size = new System.Drawing.Size(115, 46);
            this.VideoReturn.TabIndex = 18;
            this.VideoReturn.Text = "Return";
            this.VideoReturn.UseVisualStyleBackColor = true;
            this.VideoReturn.Click += new System.EventHandler(this.VideoReturn_Click);
            // 
            // VideoRental
            // 
            this.VideoRental.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoRental.Location = new System.Drawing.Point(23, 623);
            this.VideoRental.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VideoRental.Name = "VideoRental";
            this.VideoRental.Size = new System.Drawing.Size(115, 46);
            this.VideoRental.TabIndex = 17;
            this.VideoRental.Text = "Rent";
            this.VideoRental.UseVisualStyleBackColor = true;
            this.VideoRental.Click += new System.EventHandler(this.VideoRental_Click);
            // 
            // RentalCustomerID
            // 
            this.RentalCustomerID.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalCustomerID.Location = new System.Drawing.Point(171, 460);
            this.RentalCustomerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RentalCustomerID.Name = "RentalCustomerID";
            this.RentalCustomerID.Size = new System.Drawing.Size(173, 37);
            this.RentalCustomerID.TabIndex = 15;
            // 
            // RentalVideoID
            // 
            this.RentalVideoID.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalVideoID.Location = new System.Drawing.Point(171, 410);
            this.RentalVideoID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RentalVideoID.Name = "RentalVideoID";
            this.RentalVideoID.Size = new System.Drawing.Size(173, 37);
            this.RentalVideoID.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 510);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rental Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 460);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "CustomerID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 407);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 33);
            this.label7.TabIndex = 11;
            this.label7.Text = "VideoID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(104, 356);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 33);
            this.label8.TabIndex = 10;
            this.label8.Text = "Rental Record";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 569);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 33);
            this.label9.TabIndex = 20;
            this.label9.Text = "Return Date";
            // 
            // RentalVideoDate
            // 
            this.RentalVideoDate.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalVideoDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RentalVideoDate.Location = new System.Drawing.Point(171, 516);
            this.RentalVideoDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RentalVideoDate.Name = "RentalVideoDate";
            this.RentalVideoDate.Size = new System.Drawing.Size(173, 37);
            this.RentalVideoDate.TabIndex = 21;
            // 
            // ReturnVideoDate
            // 
            this.ReturnVideoDate.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnVideoDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnVideoDate.Location = new System.Drawing.Point(171, 569);
            this.ReturnVideoDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnVideoDate.Name = "ReturnVideoDate";
            this.ReturnVideoDate.Size = new System.Drawing.Size(173, 37);
            this.ReturnVideoDate.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(500, 356);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 33);
            this.label10.TabIndex = 23;
            this.label10.Text = "Video Record";
            // 
            // Ratting
            // 
            this.Ratting.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ratting.Location = new System.Drawing.Point(563, 448);
            this.Ratting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ratting.Name = "Ratting";
            this.Ratting.Size = new System.Drawing.Size(173, 37);
            this.Ratting.TabIndex = 27;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(563, 398);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(173, 37);
            this.Title.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(408, 448);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 33);
            this.label11.TabIndex = 25;
            this.label11.Text = "Ratting";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(408, 395);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 33);
            this.label12.TabIndex = 24;
            this.label12.Text = "Title";
            // 
            // Copies
            // 
            this.Copies.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copies.Location = new System.Drawing.Point(563, 544);
            this.Copies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Copies.Name = "Copies";
            this.Copies.Size = new System.Drawing.Size(173, 37);
            this.Copies.TabIndex = 31;
            this.Copies.TextChanged += new System.EventHandler(this.Copies_TextChanged);
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.Location = new System.Drawing.Point(563, 494);
            this.Year.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(173, 37);
            this.Year.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(408, 544);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 33);
            this.label13.TabIndex = 29;
            this.label13.Text = "Copies";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(408, 491);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 33);
            this.label14.TabIndex = 28;
            this.label14.Text = "Year";
            // 
            // Plot
            // 
            this.Plot.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plot.Location = new System.Drawing.Point(851, 448);
            this.Plot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Plot.Name = "Plot";
            this.Plot.Size = new System.Drawing.Size(173, 37);
            this.Plot.TabIndex = 35;
            // 
            // Cost
            // 
            this.Cost.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost.Location = new System.Drawing.Point(851, 398);
            this.Cost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(173, 37);
            this.Cost.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(753, 448);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 33);
            this.label15.TabIndex = 33;
            this.label15.Text = "Plot";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(753, 395);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 33);
            this.label16.TabIndex = 32;
            this.label16.Text = "Cost";
            // 
            // Genre
            // 
            this.Genre.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genre.Location = new System.Drawing.Point(851, 500);
            this.Genre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(173, 37);
            this.Genre.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(753, 500);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 33);
            this.label17.TabIndex = 36;
            this.label17.Text = "Genre";
            // 
            // VideoDelete
            // 
            this.VideoDelete.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoDelete.Location = new System.Drawing.Point(752, 599);
            this.VideoDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VideoDelete.Name = "VideoDelete";
            this.VideoDelete.Size = new System.Drawing.Size(115, 46);
            this.VideoDelete.TabIndex = 40;
            this.VideoDelete.Text = "Delete";
            this.VideoDelete.UseVisualStyleBackColor = true;
            this.VideoDelete.Click += new System.EventHandler(this.VideoDelete_Click);
            // 
            // VideoUpdate
            // 
            this.VideoUpdate.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoUpdate.Location = new System.Drawing.Point(629, 599);
            this.VideoUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VideoUpdate.Name = "VideoUpdate";
            this.VideoUpdate.Size = new System.Drawing.Size(115, 46);
            this.VideoUpdate.TabIndex = 39;
            this.VideoUpdate.Text = "Update";
            this.VideoUpdate.UseVisualStyleBackColor = true;
            this.VideoUpdate.Click += new System.EventHandler(this.VideoUpdate_Click);
            // 
            // VideoInsert
            // 
            this.VideoInsert.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoInsert.Location = new System.Drawing.Point(507, 599);
            this.VideoInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VideoInsert.Name = "VideoInsert";
            this.VideoInsert.Size = new System.Drawing.Size(115, 46);
            this.VideoInsert.TabIndex = 38;
            this.VideoInsert.Text = "Insert";
            this.VideoInsert.UseVisualStyleBackColor = true;
            this.VideoInsert.Click += new System.EventHandler(this.VideoInsert_Click);
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(415, 62);
            this.data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.Size = new System.Drawing.Size(1000, 282);
            this.data.TabIndex = 41;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            this.data.DoubleClick += new System.EventHandler(this.data_DoubleClick);
            // 
            // CustomerData
            // 
            this.CustomerData.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerData.Location = new System.Drawing.Point(413, 15);
            this.CustomerData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerData.Name = "CustomerData";
            this.CustomerData.Size = new System.Drawing.Size(155, 39);
            this.CustomerData.TabIndex = 42;
            this.CustomerData.Text = "Customer";
            this.CustomerData.UseVisualStyleBackColor = true;
            this.CustomerData.Click += new System.EventHandler(this.CustomerData_Click);
            // 
            // VideoData
            // 
            this.VideoData.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoData.Location = new System.Drawing.Point(576, 15);
            this.VideoData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VideoData.Name = "VideoData";
            this.VideoData.Size = new System.Drawing.Size(155, 39);
            this.VideoData.TabIndex = 43;
            this.VideoData.Text = "Video";
            this.VideoData.UseVisualStyleBackColor = true;
            this.VideoData.Click += new System.EventHandler(this.VideoData_Click);
            // 
            // RentalData
            // 
            this.RentalData.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalData.Location = new System.Drawing.Point(739, 15);
            this.RentalData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RentalData.Name = "RentalData";
            this.RentalData.Size = new System.Drawing.Size(155, 39);
            this.RentalData.TabIndex = 44;
            this.RentalData.Text = "Rental";
            this.RentalData.UseVisualStyleBackColor = true;
            this.RentalData.Click += new System.EventHandler(this.RentalData_Click);
            // 
            // btnTopCustomer
            // 
            this.btnTopCustomer.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopCustomer.Location = new System.Drawing.Point(896, 14);
            this.btnTopCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTopCustomer.Name = "btnTopCustomer";
            this.btnTopCustomer.Size = new System.Drawing.Size(251, 39);
            this.btnTopCustomer.TabIndex = 46;
            this.btnTopCustomer.Text = "Customer Ranking";
            this.btnTopCustomer.UseVisualStyleBackColor = true;
            this.btnTopCustomer.Click += new System.EventHandler(this.btnTopCustomer_Click);
            // 
            // btnMovieCount
            // 
            this.btnMovieCount.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieCount.Location = new System.Drawing.Point(1155, 14);
            this.btnMovieCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMovieCount.Name = "btnMovieCount";
            this.btnMovieCount.Size = new System.Drawing.Size(251, 39);
            this.btnMovieCount.TabIndex = 47;
            this.btnMovieCount.Text = "Video Ranking";
            this.btnMovieCount.UseVisualStyleBackColor = true;
            this.btnMovieCount.Click += new System.EventHandler(this.btnMovieCount_Click);
            // 
            // VideoStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1431, 694);
            this.Controls.Add(this.btnMovieCount);
            this.Controls.Add(this.btnTopCustomer);
            this.Controls.Add(this.RentalData);
            this.Controls.Add(this.VideoData);
            this.Controls.Add(this.CustomerData);
            this.Controls.Add(this.data);
            this.Controls.Add(this.VideoDelete);
            this.Controls.Add(this.VideoUpdate);
            this.Controls.Add(this.VideoInsert);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Plot);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Copies);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Ratting);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ReturnVideoDate);
            this.Controls.Add(this.RentalVideoDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RentalVideoDelete);
            this.Controls.Add(this.VideoReturn);
            this.Controls.Add(this.VideoRental);
            this.Controls.Add(this.RentalCustomerID);
            this.Controls.Add(this.RentalVideoID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CustomerDelete);
            this.Controls.Add(this.CustomerUpdate);
            this.Controls.Add(this.CustomerInsert);
            this.Controls.Add(this.CustomerContact);
            this.Controls.Add(this.CustomerAddress);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VideoStore";
            this.Text = "Video Rental System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox CustomerAddress;
        private System.Windows.Forms.TextBox CustomerContact;
        private System.Windows.Forms.Button CustomerInsert;
        private System.Windows.Forms.Button CustomerUpdate;
        private System.Windows.Forms.Button CustomerDelete;
        private System.Windows.Forms.Button RentalVideoDelete;
        private System.Windows.Forms.Button VideoReturn;
        private System.Windows.Forms.Button VideoRental;
        private System.Windows.Forms.TextBox RentalCustomerID;
        private System.Windows.Forms.TextBox RentalVideoID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker RentalVideoDate;
        private System.Windows.Forms.DateTimePicker ReturnVideoDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Ratting;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Copies;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Plot;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button VideoDelete;
        private System.Windows.Forms.Button VideoUpdate;
        private System.Windows.Forms.Button VideoInsert;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button CustomerData;
        private System.Windows.Forms.Button VideoData;
        private System.Windows.Forms.Button RentalData;
        private System.Windows.Forms.Button btnTopCustomer;
        private System.Windows.Forms.Button btnMovieCount;
    }
}

