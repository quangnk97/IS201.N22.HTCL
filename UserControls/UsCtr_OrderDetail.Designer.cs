﻿namespace IS201_N22_HTCL.UserControls
{
    partial class UsCtr_OrderDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbRent = new System.Windows.Forms.Label();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.lbDeposit = new System.Windows.Forms.Label();
            this.tbRentdate = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbDuedate = new Guna.UI2.WinForms.Guna2TextBox();
            this.gvOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Disc_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.lbNotifi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.tbID.BorderRadius = 10;
            this.tbID.BorderThickness = 2;
            this.tbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbID.DefaultText = "";
            this.tbID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbID.Enabled = false;
            this.tbID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbID.Location = new System.Drawing.Point(1037, 46);
            this.tbID.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbID.Name = "tbID";
            this.tbID.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tbID.PasswordChar = '\0';
            this.tbID.PlaceholderText = "";
            this.tbID.SelectedText = "";
            this.tbID.ShadowDecoration.BorderRadius = 200;
            this.tbID.Size = new System.Drawing.Size(191, 50);
            this.tbID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1031, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1285, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer ID Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1031, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Name";
            // 
            // tbUserID
            // 
            this.tbUserID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.tbUserID.BorderRadius = 10;
            this.tbUserID.BorderThickness = 2;
            this.tbUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserID.DefaultText = "";
            this.tbUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserID.Enabled = false;
            this.tbUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserID.Location = new System.Drawing.Point(1292, 46);
            this.tbUserID.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tbUserID.PasswordChar = '\0';
            this.tbUserID.PlaceholderText = "";
            this.tbUserID.SelectedText = "";
            this.tbUserID.Size = new System.Drawing.Size(320, 50);
            this.tbUserID.TabIndex = 1;
            // 
            // tbUserName
            // 
            this.tbUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.tbUserName.BorderRadius = 10;
            this.tbUserName.BorderThickness = 2;
            this.tbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.DefaultText = "";
            this.tbUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.Enabled = false;
            this.tbUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserName.Location = new System.Drawing.Point(1037, 156);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tbUserName.PasswordChar = '\0';
            this.tbUserName.PlaceholderText = "";
            this.tbUserName.SelectedText = "";
            this.tbUserName.Size = new System.Drawing.Size(575, 50);
            this.tbUserName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(1037, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Rent Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1356, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Due Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label6.Location = new System.Drawing.Point(1037, 414);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Rent Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.label7.Location = new System.Drawing.Point(1037, 458);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(298, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "Deposit (30.000VND/Disc):";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbRent
            // 
            this.lbRent.AutoSize = true;
            this.lbRent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbRent.Location = new System.Drawing.Point(1404, 414);
            this.lbRent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRent.Name = "lbRent";
            this.lbRent.Size = new System.Drawing.Size(169, 32);
            this.lbRent.TabIndex = 2;
            this.lbRent.Text = "xx.xxx.xxx VND";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BorderRadius = 15;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(1145, 564);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(359, 60);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm Order";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbDeposit
            // 
            this.lbDeposit.AutoSize = true;
            this.lbDeposit.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.lbDeposit.Location = new System.Drawing.Point(1403, 453);
            this.lbDeposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDeposit.Name = "lbDeposit";
            this.lbDeposit.Size = new System.Drawing.Size(210, 38);
            this.lbDeposit.TabIndex = 2;
            this.lbDeposit.Text = "xx.xxx.xxx VND";
            // 
            // tbRentdate
            // 
            this.tbRentdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.tbRentdate.BorderRadius = 10;
            this.tbRentdate.BorderThickness = 2;
            this.tbRentdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRentdate.DefaultText = "";
            this.tbRentdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbRentdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbRentdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRentdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRentdate.Enabled = false;
            this.tbRentdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRentdate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRentdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRentdate.Location = new System.Drawing.Point(1044, 295);
            this.tbRentdate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbRentdate.Name = "tbRentdate";
            this.tbRentdate.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tbRentdate.PasswordChar = '\0';
            this.tbRentdate.PlaceholderText = "";
            this.tbRentdate.SelectedText = "";
            this.tbRentdate.ShadowDecoration.BorderRadius = 200;
            this.tbRentdate.Size = new System.Drawing.Size(256, 50);
            this.tbRentdate.TabIndex = 1;
            // 
            // tbDuedate
            // 
            this.tbDuedate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.tbDuedate.BorderRadius = 10;
            this.tbDuedate.BorderThickness = 2;
            this.tbDuedate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDuedate.DefaultText = "";
            this.tbDuedate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDuedate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDuedate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDuedate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDuedate.Enabled = false;
            this.tbDuedate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDuedate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDuedate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDuedate.Location = new System.Drawing.Point(1356, 295);
            this.tbDuedate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbDuedate.Name = "tbDuedate";
            this.tbDuedate.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tbDuedate.PasswordChar = '\0';
            this.tbDuedate.PlaceholderText = "";
            this.tbDuedate.SelectedText = "";
            this.tbDuedate.ShadowDecoration.BorderRadius = 200;
            this.tbDuedate.Size = new System.Drawing.Size(256, 50);
            this.tbDuedate.TabIndex = 1;
            // 
            // gvOrder
            // 
            this.gvOrder.AllowUserToAddRows = false;
            this.gvOrder.AllowUserToDeleteRows = false;
            this.gvOrder.AllowUserToResizeColumns = false;
            this.gvOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.gvOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvOrder.ColumnHeadersHeight = 50;
            this.gvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Disc_Name,
            this.Amount,
            this.Price_day});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.gvOrder.Location = new System.Drawing.Point(52, 11);
            this.gvOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvOrder.MultiSelect = false;
            this.gvOrder.Name = "gvOrder";
            this.gvOrder.ReadOnly = true;
            this.gvOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvOrder.RowHeadersVisible = false;
            this.gvOrder.RowHeadersWidth = 51;
            this.gvOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.gvOrder.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvOrder.RowTemplate.DividerHeight = 1;
            this.gvOrder.RowTemplate.Height = 70;
            this.gvOrder.Size = new System.Drawing.Size(929, 630);
            this.gvOrder.TabIndex = 22;
            this.gvOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvOrder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvOrder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.gvOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.gvOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvOrder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvOrder.ThemeStyle.HeaderStyle.Height = 50;
            this.gvOrder.ThemeStyle.ReadOnly = true;
            this.gvOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvOrder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvOrder.ThemeStyle.RowsStyle.Height = 70;
            this.gvOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Disc_Name
            // 
            this.Disc_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Disc_Name.DataPropertyName = "DISC_NAME";
            this.Disc_Name.FillWeight = 191.0627F;
            this.Disc_Name.HeaderText = "Disc Name";
            this.Disc_Name.MinimumWidth = 6;
            this.Disc_Name.Name = "Disc_Name";
            this.Disc_Name.ReadOnly = true;
            this.Disc_Name.Width = 300;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Amount.DataPropertyName = "RENT_AMOUNT";
            this.Amount.FillWeight = 8.529577F;
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 125;
            // 
            // Price_day
            // 
            this.Price_day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price_day.DataPropertyName = "DISC_PRICE";
            this.Price_day.FillWeight = 8.529577F;
            this.Price_day.HeaderText = "Price per Day";
            this.Price_day.MinimumWidth = 6;
            this.Price_day.Name = "Price_day";
            this.Price_day.ReadOnly = true;
            this.Price_day.Width = 150;
            // 
            // message
            // 
            this.message.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.message.Caption = null;
            this.message.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.message.Parent = null;
            this.message.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.message.Text = null;
            // 
            // lbNotifi
            // 
            this.lbNotifi.BackColor = System.Drawing.Color.Transparent;
            this.lbNotifi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNotifi.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbNotifi.Location = new System.Drawing.Point(1251, 530);
            this.lbNotifi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbNotifi.Name = "lbNotifi";
            this.lbNotifi.Size = new System.Drawing.Size(3, 2);
            this.lbNotifi.TabIndex = 23;
            this.lbNotifi.Text = null;
            // 
            // UsCtr_OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbNotifi);
            this.Controls.Add(this.gvOrder);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbDeposit);
            this.Controls.Add(this.lbRent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbDuedate);
            this.Controls.Add(this.tbRentdate);
            this.Controls.Add(this.tbID);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UsCtr_OrderDetail";
            this.Size = new System.Drawing.Size(1667, 682);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbUserID;
        private Guna.UI2.WinForms.Guna2TextBox tbUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbRent;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private System.Windows.Forms.Label lbDeposit;
        private Guna.UI2.WinForms.Guna2TextBox tbRentdate;
        private Guna.UI2.WinForms.Guna2TextBox tbDuedate;
        private Guna.UI2.WinForms.Guna2DataGridView gvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disc_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_day;
        private Guna.UI2.WinForms.Guna2MessageDialog message;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbNotifi;
    }
}
