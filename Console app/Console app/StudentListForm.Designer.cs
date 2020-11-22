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
            this.FullNamelbl = new System.Windows.Forms.Label();
            this.BirthdayDatelbl = new System.Windows.Forms.Label();
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.FilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridList)).BeginInit();
            this.SuspendLayout();
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            this.AddStudentButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddStudentButton.Location = new System.Drawing.Point(7, 495);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(140, 60);
            this.AddStudentButton.TabIndex = 0;
            this.AddStudentButton.Text = "Добавить студента";
            this.AddStudentButton.UseVisualStyleBackColor = false;
            this.AddStudentButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.Controls.Add(this.comboBox3);
            this.FilterGroupBox.Controls.Add(this.comboBox2);
            this.FilterGroupBox.Controls.Add(this.comboBox1);
            this.FilterGroupBox.Controls.Add(this.FullNamelbl);
            this.FilterGroupBox.Controls.Add(this.BirthdayDatelbl);
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
            // FullNamelbl
            // 
            this.FullNamelbl.AutoSize = true;
            this.FullNamelbl.Location = new System.Drawing.Point(118, 36);
            this.FullNamelbl.Name = "FullNamelbl";
            this.FullNamelbl.Size = new System.Drawing.Size(57, 23);
            this.FullNamelbl.TabIndex = 1;
            this.FullNamelbl.Text = "ФИО";
            // 
            // BirthdayDatelbl
            // 
            this.BirthdayDatelbl.AutoSize = true;
            this.BirthdayDatelbl.Location = new System.Drawing.Point(437, 36);
            this.BirthdayDatelbl.Name = "BirthdayDatelbl";
            this.BirthdayDatelbl.Size = new System.Drawing.Size(141, 23);
            this.BirthdayDatelbl.TabIndex = 1;
            this.BirthdayDatelbl.Text = "Дата рождения";
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
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(574, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 31);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Год";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(322, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(120, 31);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "День";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(448, 63);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(120, 31);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.Text = "Месяц";
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
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
        private System.Windows.Forms.Label FullNamelbl;
        private System.Windows.Forms.Label BirthdayDatelbl;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}