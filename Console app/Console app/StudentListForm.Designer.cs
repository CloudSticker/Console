﻿
namespace Console_app
{
    partial class StudentListForm
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
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.BirthdayDateCheckBox = new System.Windows.Forms.CheckBox();
            this.FullNameCheckBox = new System.Windows.Forms.CheckBox();
            this.MounthComboBox = new System.Windows.Forms.ComboBox();
            this.DayComboBox = new System.Windows.Forms.ComboBox();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Institute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MidCertificateScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridList = new System.Windows.Forms.DataGridView();
            this.StudentListButton = new System.Windows.Forms.Button();
            this.FilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridList)).BeginInit();
            this.SuspendLayout();
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            this.AddStudentButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddStudentButton.Location = new System.Drawing.Point(7, 151);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(140, 60);
            this.AddStudentButton.TabIndex = 0;
            this.AddStudentButton.Text = "Добавить студента";
            this.AddStudentButton.UseVisualStyleBackColor = false;
            this.AddStudentButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.Controls.Add(this.BirthdayDateCheckBox);
            this.FilterGroupBox.Controls.Add(this.FullNameCheckBox);
            this.FilterGroupBox.Controls.Add(this.MounthComboBox);
            this.FilterGroupBox.Controls.Add(this.DayComboBox);
            this.FilterGroupBox.Controls.Add(this.YearComboBox);
            this.FilterGroupBox.Controls.Add(this.FullNameTextBox);
            this.FilterGroupBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilterGroupBox.Location = new System.Drawing.Point(172, 12);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Size = new System.Drawing.Size(700, 100);
            this.FilterGroupBox.TabIndex = 1;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "Фильтры";
            this.FilterGroupBox.Enter += new System.EventHandler(this.FilterGroupBox_Enter);
            // 
            // BirthdayDateCheckBox
            // 
            this.BirthdayDateCheckBox.AutoSize = true;
            this.BirthdayDateCheckBox.Location = new System.Drawing.Point(437, 32);
            this.BirthdayDateCheckBox.Name = "BirthdayDateCheckBox";
            this.BirthdayDateCheckBox.Size = new System.Drawing.Size(160, 27);
            this.BirthdayDateCheckBox.TabIndex = 2;
            this.BirthdayDateCheckBox.Text = "Дата рождения";
            this.BirthdayDateCheckBox.UseVisualStyleBackColor = true;
            this.BirthdayDateCheckBox.CheckedChanged += new System.EventHandler(this.BirthdayDateCheckBox_CheckedChanged);
            // 
            // FullNameCheckBox
            // 
            this.FullNameCheckBox.AutoSize = true;
            this.FullNameCheckBox.Location = new System.Drawing.Point(106, 32);
            this.FullNameCheckBox.Name = "FullNameCheckBox";
            this.FullNameCheckBox.Size = new System.Drawing.Size(76, 27);
            this.FullNameCheckBox.TabIndex = 2;
            this.FullNameCheckBox.Text = "ФИО";
            this.FullNameCheckBox.UseVisualStyleBackColor = true;
            this.FullNameCheckBox.CheckedChanged += new System.EventHandler(this.FullNameCheckBox_CheckedChanged);
            // 
            // MounthComboBox
            // 
            this.MounthComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MounthComboBox.FormattingEnabled = true;
            this.MounthComboBox.Location = new System.Drawing.Point(448, 63);
            this.MounthComboBox.Name = "MounthComboBox";
            this.MounthComboBox.Size = new System.Drawing.Size(120, 31);
            this.MounthComboBox.TabIndex = 1;
            this.MounthComboBox.Text = "Месяц";
            this.MounthComboBox.SelectedIndexChanged += new System.EventHandler(this.MounthComboBox_SelectedIndexChanged);
            this.MounthComboBox.Click += new System.EventHandler(this.MounthComboBox_Click);
            this.MounthComboBox.Leave += new System.EventHandler(this.MounthComboBox_Leave);
            // 
            // DayComboBox
            // 
            this.DayComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DayComboBox.FormattingEnabled = true;
            this.DayComboBox.Location = new System.Drawing.Point(322, 62);
            this.DayComboBox.Name = "DayComboBox";
            this.DayComboBox.Size = new System.Drawing.Size(120, 31);
            this.DayComboBox.TabIndex = 1;
            this.DayComboBox.Text = "День";
            this.DayComboBox.Click += new System.EventHandler(this.DayComboBox_Click);
            this.DayComboBox.Leave += new System.EventHandler(this.DayComboBox_Leave);
            // 
            // YearComboBox
            // 
            this.YearComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Location = new System.Drawing.Point(574, 63);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(120, 31);
            this.YearComboBox.TabIndex = 1;
            this.YearComboBox.Text = "Год";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(26, 62);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(250, 32);
            this.FullNameTextBox.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.Location = new System.Drawing.Point(7, 19);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(140, 60);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "ID";
            this.StudentID.MinimumWidth = 10;
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentID.Width = 40;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "ФИО";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FullName.Width = 300;
            // 
            // BirthDayDate
            // 
            this.BirthDayDate.HeaderText = "Дата рождения";
            this.BirthDayDate.Name = "BirthDayDate";
            this.BirthDayDate.ReadOnly = true;
            this.BirthDayDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BirthDayDate.Width = 80;
            // 
            // Institute
            // 
            this.Institute.HeaderText = "Институт";
            this.Institute.Name = "Institute";
            this.Institute.ReadOnly = true;
            this.Institute.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Institute.Width = 300;
            // 
            // Group
            // 
            this.Group.HeaderText = "Группа";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Group.Width = 150;
            // 
            // Cource
            // 
            this.Cource.HeaderText = "Курс";
            this.Cource.Name = "Cource";
            this.Cource.ReadOnly = true;
            this.Cource.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cource.Width = 150;
            // 
            // MidCertificateScore
            // 
            this.MidCertificateScore.HeaderText = "Ср.Балл";
            this.MidCertificateScore.Name = "MidCertificateScore";
            this.MidCertificateScore.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MidCertificateScore.Width = 150;
            // 
            // DataGridList
            // 
            this.DataGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FullName,
            this.BirthDayDate,
            this.Institute,
            this.Group,
            this.Cource,
            this.MidCertificateScore});
            this.DataGridList.Location = new System.Drawing.Point(172, 126);
            this.DataGridList.Name = "DataGridList";
            this.DataGridList.Size = new System.Drawing.Size(700, 429);
            this.DataGridList.TabIndex = 4;
            this.DataGridList.Text = "dataGridView1";
            // 
            // StudentListButton
            // 
            this.StudentListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            this.StudentListButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StudentListButton.Location = new System.Drawing.Point(7, 85);
            this.StudentListButton.Name = "StudentListButton";
            this.StudentListButton.Size = new System.Drawing.Size(140, 60);
            this.StudentListButton.TabIndex = 6;
            this.StudentListButton.Text = "Список студентов";
            this.StudentListButton.UseVisualStyleBackColor = false;
            this.StudentListButton.Click += new System.EventHandler(this.StudentListButton_Click);
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.StudentListButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DataGridList);
            this.Controls.Add(this.FilterGroupBox);
            this.Controls.Add(this.AddStudentButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this.FilterGroupBox.ResumeLayout(false);
            this.FilterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.GroupBox FilterGroupBox;
        private System.Windows.Forms.DataGridView DataGridList;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Institute;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cource;
        private System.Windows.Forms.DataGridViewTextBoxColumn MidCertificateScore;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox FullNameCheckBox;
        private System.Windows.Forms.CheckBox BirthdayDateCheckBox;
        private System.Windows.Forms.ComboBox DayComboBox;
        private System.Windows.Forms.ComboBox MounthComboBox;
        private System.Windows.Forms.Button StudentListButton;
    }
}