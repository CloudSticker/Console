namespace Console_app
{
    partial class AddingUserData_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingUserData_Form));
            this.FullNamePanel = new System.Windows.Forms.Panel();
            this.ThirdNameInput = new System.Windows.Forms.TextBox();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.SecondNameInput = new System.Windows.Forms.TextBox();
            this.BirthDayPanel = new System.Windows.Forms.Panel();
            this.BirthDateInputYear = new System.Windows.Forms.ComboBox();
            this.BirthDateInputMonth = new System.Windows.Forms.ComboBox();
            this.BirthDateInputDay = new System.Windows.Forms.ComboBox();
            this.BirthDayLabel = new System.Windows.Forms.Label();
            this.InstitutPanel = new System.Windows.Forms.Panel();
            this.gpaInput = new System.Windows.Forms.TextBox();
            this.get_IDInstitutionList = new System.Windows.Forms.ComboBox();
            this.get_IDYearOfStudyList = new System.Windows.Forms.ComboBox();
            this.get_IDgroupList = new System.Windows.Forms.ComboBox();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.FullNamePanel.SuspendLayout();
            this.BirthDayPanel.SuspendLayout();
            this.InstitutPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FullNamePanel
            // 
            this.FullNamePanel.Controls.Add(this.ThirdNameInput);
            this.FullNamePanel.Controls.Add(this.FirstNameInput);
            this.FullNamePanel.Controls.Add(this.SecondNameInput);
            resources.ApplyResources(this.FullNamePanel, "FullNamePanel");
            this.FullNamePanel.Name = "FullNamePanel";
            this.FullNamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // ThirdNameInput
            // 
            resources.ApplyResources(this.ThirdNameInput, "ThirdNameInput");
            this.ThirdNameInput.Name = "ThirdNameInput";
            // 
            // FirstNameInput
            // 
            resources.ApplyResources(this.FirstNameInput, "FirstNameInput");
            this.FirstNameInput.Name = "FirstNameInput";
            // 
            // SecondNameInput
            // 
            resources.ApplyResources(this.SecondNameInput, "SecondNameInput");
            this.SecondNameInput.Name = "SecondNameInput";
            // 
            // BirthDayPanel
            // 
            resources.ApplyResources(this.BirthDayPanel, "BirthDayPanel");
            this.BirthDayPanel.Controls.Add(this.BirthDateInputYear);
            this.BirthDayPanel.Controls.Add(this.BirthDateInputMonth);
            this.BirthDayPanel.Controls.Add(this.BirthDateInputDay);
            this.BirthDayPanel.Controls.Add(this.BirthDayLabel);
            this.BirthDayPanel.Name = "BirthDayPanel";
            // 
            // BirthDateInputYear
            // 
            resources.ApplyResources(this.BirthDateInputYear, "BirthDateInputYear");
            this.BirthDateInputYear.FormattingEnabled = true;
            this.BirthDateInputYear.Name = "BirthDateInputYear";
            // 
            // BirthDateInputMonth
            // 
            resources.ApplyResources(this.BirthDateInputMonth, "BirthDateInputMonth");
            this.BirthDateInputMonth.FormattingEnabled = true;
            this.BirthDateInputMonth.Name = "BirthDateInputMonth";
            // 
            // BirthDateInputDay
            // 
            resources.ApplyResources(this.BirthDateInputDay, "BirthDateInputDay");
            this.BirthDateInputDay.FormattingEnabled = true;
            this.BirthDateInputDay.Name = "BirthDateInputDay";
            // 
            // BirthDayLabel
            // 
            resources.ApplyResources(this.BirthDayLabel, "BirthDayLabel");
            this.BirthDayLabel.Name = "BirthDayLabel";
            // 
            // InstitutPanel
            // 
            resources.ApplyResources(this.InstitutPanel, "InstitutPanel");
            this.InstitutPanel.Controls.Add(this.gpaInput);
            this.InstitutPanel.Controls.Add(this.get_IDInstitutionList);
            this.InstitutPanel.Controls.Add(this.get_IDYearOfStudyList);
            this.InstitutPanel.Controls.Add(this.get_IDgroupList);
            this.InstitutPanel.Name = "InstitutPanel";
            this.InstitutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // gpaInput
            // 
            resources.ApplyResources(this.gpaInput, "gpaInput");
            this.gpaInput.Name = "gpaInput";
            // 
            // get_IDInstitutionList
            // 
            resources.ApplyResources(this.get_IDInstitutionList, "get_IDInstitutionList");
            this.get_IDInstitutionList.FormattingEnabled = true;
            this.get_IDInstitutionList.Name = "get_IDInstitutionList";
            // 
            // get_IDYearOfStudyList
            // 
            resources.ApplyResources(this.get_IDYearOfStudyList, "get_IDYearOfStudyList");
            this.get_IDYearOfStudyList.FormattingEnabled = true;
            this.get_IDYearOfStudyList.Name = "get_IDYearOfStudyList";
            // 
            // get_IDgroupList
            // 
            resources.ApplyResources(this.get_IDgroupList, "get_IDgroupList");
            this.get_IDgroupList.FormattingEnabled = true;
            this.get_IDgroupList.Name = "get_IDgroupList";
            this.get_IDgroupList.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.Clear_Button);
            this.ButtonPanel.Controls.Add(this.Add_Button);
            this.ButtonPanel.Controls.Add(this.Cancel_Button);
            resources.ApplyResources(this.ButtonPanel, "ButtonPanel");
            this.ButtonPanel.Name = "ButtonPanel";
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            resources.ApplyResources(this.Clear_Button, "Clear_Button");
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.UseVisualStyleBackColor = false;
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            resources.ApplyResources(this.Add_Button, "Add_Button");
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.UseVisualStyleBackColor = false;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            resources.ApplyResources(this.Cancel_Button, "Cancel_Button");
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.UseVisualStyleBackColor = false;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // AddingUserData_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.InstitutPanel);
            this.Controls.Add(this.BirthDayPanel);
            this.Controls.Add(this.FullNamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddingUserData_Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FullNamePanel.ResumeLayout(false);
            this.FullNamePanel.PerformLayout();
            this.BirthDayPanel.ResumeLayout(false);
            this.BirthDayPanel.PerformLayout();
            this.InstitutPanel.ResumeLayout(false);
            this.InstitutPanel.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Panel FullNamePanel;
        private System.Windows.Forms.TextBox SecondNameInput;
        private System.Windows.Forms.TextBox ThirdNameInput;
        private System.Windows.Forms.TextBox FirstNameInput;
        private System.Windows.Forms.Panel BirthDayPanel;
        private System.Windows.Forms.Panel InstitutPanel;
        private System.Windows.Forms.ComboBox BirthDateInputYear;
        private System.Windows.Forms.ComboBox BirthDateInputMonth;
        private System.Windows.Forms.ComboBox BirthDateInputDay;
        private System.Windows.Forms.Label BirthDayLabel;
        private System.Windows.Forms.ComboBox get_IDInstitutionList;
        private System.Windows.Forms.ComboBox get_IDYearOfStudyList;
        private System.Windows.Forms.ComboBox get_IDgroupList;
        private System.Windows.Forms.TextBox gpaInput;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Cancel_Button;
    }
}

