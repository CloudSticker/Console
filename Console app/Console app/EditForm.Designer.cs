namespace Console_app
{
    partial class EditStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudentForm));
            this.ThirdNameErrLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.get_IDYearOfStudyList = new System.Windows.Forms.ComboBox();
            this.DateErrLbl = new System.Windows.Forms.Label();
            this.BirthDateInputYear = new System.Windows.Forms.ComboBox();
            this.BirthDateInputMonth = new System.Windows.Forms.ComboBox();
            this.BirthDateInputDay = new System.Windows.Forms.ComboBox();
            this.gpaInput = new System.Windows.Forms.TextBox();
            this.get_IDInstitutionList = new System.Windows.Forms.ComboBox();
            this.BirthDayLabel = new System.Windows.Forms.Label();
            this.InstitutPanel = new System.Windows.Forms.Panel();
            this.ID_lbloutput = new System.Windows.Forms.Label();
            this.IDtext = new System.Windows.Forms.Label();
            this.Get_GroupID = new System.Windows.Forms.TextBox();
            this.BirthDayPanel = new System.Windows.Forms.Panel();
            this.debug = new System.Windows.Forms.Label();
            this.FirstNameErrLbl = new System.Windows.Forms.Label();
            this.SecondNameErrLbl = new System.Windows.Forms.Label();
            this.ThirdNameInput = new System.Windows.Forms.TextBox();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.SecondNameInput = new System.Windows.Forms.TextBox();
            this.FullNamePanel = new System.Windows.Forms.Panel();
            this.ButtonPanel.SuspendLayout();
            this.InstitutPanel.SuspendLayout();
            this.BirthDayPanel.SuspendLayout();
            this.FullNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThirdNameErrLbl
            // 
            resources.ApplyResources(this.ThirdNameErrLbl, "ThirdNameErrLbl");
            this.ThirdNameErrLbl.ForeColor = System.Drawing.Color.Red;
            this.ThirdNameErrLbl.Name = "ThirdNameErrLbl";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Name = "panel2";
            // 
            // Edit_Button
            // 
            this.Edit_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            this.Edit_Button.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Edit_Button, "Edit_Button");
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.UseVisualStyleBackColor = false;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            this.ButtonPanel.Controls.Add(this.panel2);
            this.ButtonPanel.Controls.Add(this.Edit_Button);
            this.ButtonPanel.Controls.Add(this.Cancel_Button);
            resources.ApplyResources(this.ButtonPanel, "ButtonPanel");
            this.ButtonPanel.Name = "ButtonPanel";
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
            this.get_IDInstitutionList.Click += new System.EventHandler(this.get_IDInstitutionList_Click);
            // 
            // BirthDayLabel
            // 
            resources.ApplyResources(this.BirthDayLabel, "BirthDayLabel");
            this.BirthDayLabel.Name = "BirthDayLabel";
            // 
            // InstitutPanel
            // 
            resources.ApplyResources(this.InstitutPanel, "InstitutPanel");
            this.InstitutPanel.Controls.Add(this.ID_lbloutput);
            this.InstitutPanel.Controls.Add(this.IDtext);
            this.InstitutPanel.Controls.Add(this.Get_GroupID);
            this.InstitutPanel.Controls.Add(this.gpaInput);
            this.InstitutPanel.Controls.Add(this.get_IDInstitutionList);
            this.InstitutPanel.Controls.Add(this.get_IDYearOfStudyList);
            this.InstitutPanel.Name = "InstitutPanel";
            // 
            // ID_lbloutput
            // 
            resources.ApplyResources(this.ID_lbloutput, "ID_lbloutput");
            this.ID_lbloutput.Name = "ID_lbloutput";
            // 
            // IDtext
            // 
            resources.ApplyResources(this.IDtext, "IDtext");
            this.IDtext.Name = "IDtext";
            // 
            // Get_GroupID
            // 
            resources.ApplyResources(this.Get_GroupID, "Get_GroupID");
            this.Get_GroupID.Name = "Get_GroupID";
            // 
            // BirthDayPanel
            // 
            resources.ApplyResources(this.BirthDayPanel, "BirthDayPanel");
            this.BirthDayPanel.Controls.Add(this.DateErrLbl);
            this.BirthDayPanel.Controls.Add(this.debug);
            this.BirthDayPanel.Controls.Add(this.BirthDateInputYear);
            this.BirthDayPanel.Controls.Add(this.BirthDateInputMonth);
            this.BirthDayPanel.Controls.Add(this.BirthDateInputDay);
            this.BirthDayPanel.Controls.Add(this.BirthDayLabel);
            this.BirthDayPanel.Name = "BirthDayPanel";
            // 
            // debug
            // 
            resources.ApplyResources(this.debug, "debug");
            this.debug.Name = "debug";
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
            this.SecondNameInput.TextChanged += new System.EventHandler(this.SecondNameInput_TextChanged);
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
            // 
            // EditStudentForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ControlBox = false;
            this.Controls.Add(this.ThirdNameErrLbl);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.InstitutPanel);
            this.Controls.Add(this.BirthDayPanel);
            this.Controls.Add(this.FullNamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "EditStudentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            this.InstitutPanel.ResumeLayout(false);
            this.InstitutPanel.PerformLayout();
            this.BirthDayPanel.ResumeLayout(false);
            this.BirthDayPanel.PerformLayout();
            this.FullNamePanel.ResumeLayout(false);
            this.FullNamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion


        private System.Windows.Forms.Label ThirdNameErrLbl;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Button Edit_Button;

        private System.Windows.Forms.Panel ButtonPanel;

        private System.Windows.Forms.Button Cancel_Button;

        private System.Windows.Forms.ComboBox get_IDYearOfStudyList;

        private System.Windows.Forms.Label DateErrLbl;

        private System.Windows.Forms.ComboBox BirthDateInputYear;

        private System.Windows.Forms.ComboBox BirthDateInputMonth;

        private System.Windows.Forms.ComboBox BirthDateInputDay;

        private System.Windows.Forms.TextBox gpaInput;

        private System.Windows.Forms.ComboBox get_IDInstitutionList;

        private System.Windows.Forms.Label BirthDayLabel;

        private System.Windows.Forms.Panel InstitutPanel;

        private System.Windows.Forms.TextBox Get_GroupID;

        private System.Windows.Forms.Panel BirthDayPanel;

        private System.Windows.Forms.Label FirstNameErrLbl;

        private System.Windows.Forms.Label SecondNameErrLbl;

        private System.Windows.Forms.TextBox ThirdNameInput;

        private System.Windows.Forms.TextBox FirstNameInput;

        private System.Windows.Forms.TextBox SecondNameInput;

        private System.Windows.Forms.Panel FullNamePanel;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.Label IDtext;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label ID_lbloutput;
    }
}