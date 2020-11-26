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
            this.FirstNameErrLbl = new System.Windows.Forms.Label();
            this.SecondNameErrLbl = new System.Windows.Forms.Label();
            this.ThirdNameInput = new System.Windows.Forms.TextBox();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.SecondNameInput = new System.Windows.Forms.TextBox();
            this.BirthDayPanel = new System.Windows.Forms.Panel();
            this.DateErrLbl = new System.Windows.Forms.Label();
            this.BirthDateInputYear = new System.Windows.Forms.ComboBox();
            this.BirthDateInputMonth = new System.Windows.Forms.ComboBox();
            this.BirthDateInputDay = new System.Windows.Forms.ComboBox();
            this.BirthDayLabel = new System.Windows.Forms.Label();
            this.InstitutPanel = new System.Windows.Forms.Panel();
            this.Get_GroupID = new System.Windows.Forms.TextBox();
            this.gpaInput = new System.Windows.Forms.TextBox();
            this.get_IDInstitutionList = new System.Windows.Forms.ComboBox();
            this.get_IDYearOfStudyList = new System.Windows.Forms.ComboBox();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.ThirdNameErrLbl = new System.Windows.Forms.Label();
            this.FullNamePanel.SuspendLayout();
            this.BirthDayPanel.SuspendLayout();
            this.InstitutPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FullNamePanel
            // 
            this.FullNamePanel.Controls.Add(this.FirstNameErrLbl);
            this.FullNamePanel.Controls.Add(this.SecondNameErrLbl);
            this.FullNamePanel.Controls.Add(this.ThirdNameInput);
            this.FullNamePanel.Controls.Add(this.FirstNameInput);
            this.FullNamePanel.Controls.Add(this.SecondNameInput);
            resources.ApplyResources(this.FullNamePanel, "FullNamePanel");
            this.FullNamePanel.Name = "FullNamePanel";
            this.FullNamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // FirstNameErrLbl
            // 
            resources.ApplyResources(this.FirstNameErrLbl, "FirstNameErrLbl");
            this.FirstNameErrLbl.ForeColor = System.Drawing.Color.Red;
            this.FirstNameErrLbl.Name = "FirstNameErrLbl";
            // 
            // SecondNameErrLbl
            // 
            resources.ApplyResources(this.SecondNameErrLbl, "SecondNameErrLbl");
            this.SecondNameErrLbl.ForeColor = System.Drawing.Color.Red;
            this.SecondNameErrLbl.Name = "SecondNameErrLbl";
            // 
            // ThirdNameInput
            // 
            resources.ApplyResources(this.ThirdNameInput, "ThirdNameInput");
            this.ThirdNameInput.Name = "ThirdNameInput";
            this.ThirdNameInput.Click += new System.EventHandler(this.ThirdNameInput_Click);
            // 
            // FirstNameInput
            // 
            resources.ApplyResources(this.FirstNameInput, "FirstNameInput");
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Click += new System.EventHandler(this.FirstNameInput_Click);
            // 
            // SecondNameInput
            // 
            resources.ApplyResources(this.SecondNameInput, "SecondNameInput");
            this.SecondNameInput.Name = "SecondNameInput";
            this.SecondNameInput.Click += new System.EventHandler(this.SecondNameInput_Click);
            // 
            // BirthDayPanel
            // 
            resources.ApplyResources(this.BirthDayPanel, "BirthDayPanel");
            this.BirthDayPanel.Controls.Add(this.DateErrLbl);
            this.BirthDayPanel.Controls.Add(this.BirthDateInputYear);
            this.BirthDayPanel.Controls.Add(this.BirthDateInputMonth);
            this.BirthDayPanel.Controls.Add(this.BirthDateInputDay);
            this.BirthDayPanel.Controls.Add(this.BirthDayLabel);
            this.BirthDayPanel.Name = "BirthDayPanel";
            // 
            // DateErrLbl
            // 
            resources.ApplyResources(this.DateErrLbl, "DateErrLbl");
            this.DateErrLbl.ForeColor = System.Drawing.Color.Red;
            this.DateErrLbl.Name = "DateErrLbl";
            // 
            // BirthDateInputYear
            // 
            resources.ApplyResources(this.BirthDateInputYear, "BirthDateInputYear");
            this.BirthDateInputYear.FormattingEnabled = true;
            this.BirthDateInputYear.Items.AddRange(new object[] {
            resources.GetString("BirthDateInputYear.Items"),
            resources.GetString("BirthDateInputYear.Items1"),
            resources.GetString("BirthDateInputYear.Items2"),
            resources.GetString("BirthDateInputYear.Items3"),
            resources.GetString("BirthDateInputYear.Items4"),
            resources.GetString("BirthDateInputYear.Items5"),
            resources.GetString("BirthDateInputYear.Items6"),
            resources.GetString("BirthDateInputYear.Items7"),
            resources.GetString("BirthDateInputYear.Items8"),
            resources.GetString("BirthDateInputYear.Items9"),
            resources.GetString("BirthDateInputYear.Items10"),
            resources.GetString("BirthDateInputYear.Items11"),
            resources.GetString("BirthDateInputYear.Items12"),
            resources.GetString("BirthDateInputYear.Items13"),
            resources.GetString("BirthDateInputYear.Items14"),
            resources.GetString("BirthDateInputYear.Items15"),
            resources.GetString("BirthDateInputYear.Items16"),
            resources.GetString("BirthDateInputYear.Items17"),
            resources.GetString("BirthDateInputYear.Items18"),
            resources.GetString("BirthDateInputYear.Items19"),
            resources.GetString("BirthDateInputYear.Items20"),
            resources.GetString("BirthDateInputYear.Items21"),
            resources.GetString("BirthDateInputYear.Items22"),
            resources.GetString("BirthDateInputYear.Items23"),
            resources.GetString("BirthDateInputYear.Items24"),
            resources.GetString("BirthDateInputYear.Items25"),
            resources.GetString("BirthDateInputYear.Items26"),
            resources.GetString("BirthDateInputYear.Items27"),
            resources.GetString("BirthDateInputYear.Items28"),
            resources.GetString("BirthDateInputYear.Items29"),
            resources.GetString("BirthDateInputYear.Items30"),
            resources.GetString("BirthDateInputYear.Items31"),
            resources.GetString("BirthDateInputYear.Items32")});
            this.BirthDateInputYear.Name = "BirthDateInputYear";
            this.BirthDateInputYear.SelectedIndexChanged += new System.EventHandler(this.BirthDateInputYear_SelectedIndexChanged);
            // 
            // BirthDateInputMonth
            // 
            resources.ApplyResources(this.BirthDateInputMonth, "BirthDateInputMonth");
            this.BirthDateInputMonth.FormattingEnabled = true;
            this.BirthDateInputMonth.Name = "BirthDateInputMonth";
            this.BirthDateInputMonth.SelectedIndexChanged += new System.EventHandler(this.BirthDateInputMonth_SelectedIndexChanged);
            this.BirthDateInputMonth.Leave += new System.EventHandler(this.BirthDateInputMonth_Leave);
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
            this.InstitutPanel.Controls.Add(this.Get_GroupID);
            this.InstitutPanel.Controls.Add(this.gpaInput);
            this.InstitutPanel.Controls.Add(this.get_IDInstitutionList);
            this.InstitutPanel.Controls.Add(this.get_IDYearOfStudyList);
            this.InstitutPanel.Name = "InstitutPanel";
            this.InstitutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Get_GroupID
            // 
            resources.ApplyResources(this.Get_GroupID, "Get_GroupID");
            this.Get_GroupID.Name = "Get_GroupID";
            this.Get_GroupID.Click += new System.EventHandler(this.Get_GroupID_Click);
            // 
            // gpaInput
            // 
            resources.ApplyResources(this.gpaInput, "gpaInput");
            this.gpaInput.Name = "gpaInput";
            this.gpaInput.Click += new System.EventHandler(this.gpaInput_Click);
            // 
            // get_IDInstitutionList
            // 
            this.get_IDInstitutionList.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.get_IDInstitutionList, "get_IDInstitutionList");
            this.get_IDInstitutionList.FormattingEnabled = true;
            this.get_IDInstitutionList.Name = "get_IDInstitutionList";
            this.get_IDInstitutionList.Click += new System.EventHandler(this.get_IDInstitutionList_Click);
            // 
            // get_IDYearOfStudyList
            // 
            resources.ApplyResources(this.get_IDYearOfStudyList, "get_IDYearOfStudyList");
            this.get_IDYearOfStudyList.FormattingEnabled = true;
            this.get_IDYearOfStudyList.Items.AddRange(new object[] {
            resources.GetString("get_IDYearOfStudyList.Items"),
            resources.GetString("get_IDYearOfStudyList.Items1"),
            resources.GetString("get_IDYearOfStudyList.Items2"),
            resources.GetString("get_IDYearOfStudyList.Items3")});
            this.get_IDYearOfStudyList.Name = "get_IDYearOfStudyList";
            this.get_IDYearOfStudyList.Click += new System.EventHandler(this.get_IDYearOfStudyList_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            this.ButtonPanel.Controls.Add(this.panel1);
            this.ButtonPanel.Controls.Add(this.panel2);
            this.ButtonPanel.Controls.Add(this.Clear_Button);
            this.ButtonPanel.Controls.Add(this.Add_Button);
            this.ButtonPanel.Controls.Add(this.Cancel_Button);
            resources.ApplyResources(this.ButtonPanel, "ButtonPanel");
            this.ButtonPanel.Name = "ButtonPanel";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Name = "panel2";
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            this.Clear_Button.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Clear_Button, "Clear_Button");
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            this.Add_Button.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Add_Button, "Add_Button");
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            this.Cancel_Button.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Cancel_Button, "Cancel_Button");
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.UseVisualStyleBackColor = false;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // ThirdNameErrLbl
            // 
            resources.ApplyResources(this.ThirdNameErrLbl, "ThirdNameErrLbl");
            this.ThirdNameErrLbl.ForeColor = System.Drawing.Color.Red;
            this.ThirdNameErrLbl.Name = "ThirdNameErrLbl";
            // 
            // AddingUserData_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ThirdNameErrLbl);
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
            this.ButtonPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label BirthDayLabel;
        private System.Windows.Forms.ComboBox get_IDInstitutionList;
        private System.Windows.Forms.ComboBox get_IDYearOfStudyList;
        private System.Windows.Forms.TextBox gpaInput;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Get_GroupID;
        private System.Windows.Forms.ComboBox BirthDateInputDay;
        private System.Windows.Forms.Label FirstNameErrLbl;
        private System.Windows.Forms.Label SecondNameErrLbl;
        private System.Windows.Forms.Label ThirdNameErrLbl;
        private System.Windows.Forms.Label DateErrLbl;
    }
}

