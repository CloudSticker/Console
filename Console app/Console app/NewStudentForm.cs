﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Console_app
{

    public partial class AddingUserData_Form : Form
    {
        internal bool IsSecondNameCorrect;
        internal bool IsFirstNameCorrect;
        internal bool IsThirdNameCorrect;
        internal bool IsDateSetted;
        internal bool IsInstitutionSetted;
        internal bool IsGroupSetted;
        internal bool IsGPASetted;
        internal bool IsYearOfStudySetted;
        WorkingFlow Datas = new WorkingFlow();
        public AddingUserData_Form()
        {
            InitializeComponent();
            WorkingFlow Datas = new WorkingFlow();
            Datas.Filling();
            BirthDateInputYear.DataSource = Datas.Years;
            BirthDateInputMonth.DataSource = Datas.monthList;
            ButtonPanel.BackColor = Color.FromArgb(25, Color.Black);
            Cancel_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, Color.Black);
            Add_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, Color.Black);
            Clear_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, Color.Black);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // AddingUserData_Form.Location = FormStartPosition.CenterScreen;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentListForm StartNewForm = new StudentListForm();
            StartNewForm.Show();

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            string ID = Convert.ToString(Datas.CheckForID());
            string Month;
            string Day;
            if (BirthDateInputMonth.SelectedIndex < 9)
            {
                Month = '0' + Convert.ToString(BirthDateInputMonth.SelectedIndex + 1);
            } else
            {
                Month = Convert.ToString(BirthDateInputMonth.SelectedIndex + 1);
            }
            if (Convert.ToInt32(BirthDateInputDay.Text) < 10)
            {
                Day = '0' + BirthDateInputDay.Text;
            } else
            {
                Day = BirthDateInputDay.Text;
            }
            IsSecondNameCorrect = Datas.IsTextOfNamesINPutValid(SecondNameInput.Text);
            IsFirstNameCorrect = Datas.IsTextOfNamesINPutValid(FirstNameInput.Text);
            IsThirdNameCorrect = Datas.IsTextOfNamesINPutValid(ThirdNameInput.Text);
            IsDateSetted = (BirthDateInputDay.SelectedIndex > -1 && BirthDateInputMonth.SelectedIndex > -1 && BirthDateInputYear.SelectedIndex > -1);
            IsInstitutionSetted = get_IDInstitutionList.SelectedIndex > -1;
            IsGroupSetted = Get_GroupID.Text != "";
            IsYearOfStudySetted = get_IDYearOfStudyList.SelectedIndex > -1 && get_IDYearOfStudyList.SelectedIndex < 4;
            bool parse = double.TryParse(gpaInput.Text, out double valGPA) && valGPA == Math.Round(valGPA,2);
            
            IsGPASetted = (parse && valGPA >= 0 && valGPA <= 100 );
            if (IsSecondNameCorrect && IsFirstNameCorrect && IsThirdNameCorrect && IsDateSetted && IsInstitutionSetted && IsGroupSetted && IsGPASetted && IsYearOfStudySetted)
            {
                string stroke = ID + ' ' + SecondNameInput.Text + '_' + FirstNameInput.Text + '_' + ThirdNameInput.Text + ' ' + Day + '.' + Month + '.' + BirthDateInputYear.Text + ' ' + get_IDInstitutionList.Text + ' ' + Get_GroupID.Text + ' ' + (get_IDYearOfStudyList.SelectedIndex + 1) + ' ' + gpaInput.Text;
                Datas.ADDinFile(stroke);
                clearingfirlds();
                UnVisErrors();
            } else 
            {
                ErrorChecks();
            }
        }

        private void BirthDateInputMonth_Leave(object sender, EventArgs e)
        {
            BirthDateInputDay.DataSource = Datas.CheckBirthDate(BirthDateInputMonth.SelectedIndex, BirthDateInputYear.Text);
        }
        /*public void CheckBirthDate()
        {
            WorkingFlow Datas = new WorkingFlow();
            int ind = BirthDateInputMonth.SelectedIndex;
            if ((Convert.ToInt32(BirthDateInputYear.Text) - 1964) % 4 == 0)
            {
                if (ind == 0 || ind == 2 || ind == 4 || ind == 6 || ind == 7 || ind == 9 || ind == 11) //Проверка на месяц (31)
                {
                    BirthDateInputDay.DataSource = Datas.DaysList31;
                } else if (ind == 1)
                {
                    BirthDateInputDay.DataSource = Datas.DaysList29;
                }
            } else
            {
                if (ind == 0 || ind == 2 || ind == 4 || ind == 6 || ind == 7 || ind == 9 || ind == 11) //Проверка на месяц (31)
                {
                    BirthDateInputDay.DataSource = Datas.DaysList31;
                }
                else if (ind == 1)
                {
                    BirthDateInputDay.DataSource = Datas.DaysList28;
                }
            }
        }*/

        private void BirthDateInputYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            BirthDateInputDay.DataSource = Datas.CheckBirthDate(BirthDateInputMonth.SelectedIndex, BirthDateInputYear.Text);
        }

        private void BirthDateInputMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            BirthDateInputDay.DataSource = Datas.CheckBirthDate(BirthDateInputMonth.SelectedIndex, BirthDateInputYear.Text);
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            clearingfirlds();
            UnVisErrors();
        }
        private void clearingfirlds()
        {
            SecondNameInput.Clear();
            FirstNameInput.Clear();
            ThirdNameInput.Clear();
            Get_GroupID.Clear();
            gpaInput.Clear();
            BirthDateInputDay.SelectedIndex = 0;
            BirthDateInputMonth.SelectedIndex = 0;
            BirthDateInputYear.SelectedIndex = 0;
            get_IDInstitutionList.SelectedIndex = -1;
            get_IDYearOfStudyList.SelectedIndex = -1;
        }
        private void UnVisErrors()
        {
            FirstNameErrLbl.Visible = false;
            SecondNameErrLbl.Visible = false;
            ThirdNameErrLbl.Visible = false;
            DateErrLbl.Visible = false;
                get_IDYearOfStudyList.BackColor = Color.White;
                get_IDInstitutionList.BackColor = Color.White;
                Get_GroupID.BackColor = Color.White;
                gpaInput.BackColor = Color.White;
        }
        private void ErrorChecks()
        {
            FirstNameErrLbl.Visible = !IsFirstNameCorrect;
            SecondNameErrLbl.Visible = !IsSecondNameCorrect;
            ThirdNameErrLbl.Visible = !IsThirdNameCorrect;
            DateErrLbl.Visible = !IsDateSetted;
            if (!IsYearOfStudySetted)
                get_IDYearOfStudyList.BackColor = Color.LightCoral;
            if (!IsInstitutionSetted)
                get_IDInstitutionList.BackColor = Color.LightCoral;
            if (!IsGroupSetted)
                Get_GroupID.BackColor = Color.LightCoral;
            if (!IsGPASetted)
                gpaInput.BackColor = Color.LightCoral;

        }

        private void get_IDInstitutionList_Click(object sender, EventArgs e)
        {
            get_IDInstitutionList.DataSource = Datas.UniversitiesList;
            get_IDInstitutionList.BackColor = Color.White;
        }

        private void Get_GroupID_Click(object sender, EventArgs e)
        {
            Get_GroupID.BackColor = Color.White;
        }

        private void get_IDYearOfStudyList_Click(object sender, EventArgs e)
        {
            get_IDYearOfStudyList.BackColor = Color.White;
        }

        private void gpaInput_Click(object sender, EventArgs e)
        {
            gpaInput.BackColor = Color.White;
        }

        private void ThirdNameInput_Click(object sender, EventArgs e)
        {
            ThirdNameErrLbl.Visible = false;
        }

        private void SecondNameInput_Click(object sender, EventArgs e)
        {
            SecondNameErrLbl.Visible = false;
        }

        private void FirstNameInput_Click(object sender, EventArgs e)
        {
            FirstNameErrLbl.Visible = false;
        }
    }
}
