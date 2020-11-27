using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Console_app
{
    public partial class EditStudentForm : Form
    {
        internal bool IsSecondNameCorrect;
        internal bool IsFirstNameCorrect;
        internal bool IsThirdNameCorrect;
        internal bool IsDateSetted;
        internal bool IsInstitutionSetted;
        internal bool IsGroupSetted;
        internal bool IsGPASetted;
        internal bool IsYearOfStudySetted;
        string path = @"StudentList.txt";
        WorkingFlow Datas = new WorkingFlow();
        public EditStudentForm()
        {
            InitializeComponent();
            Datas.Filling();
            ButtonPanel.BackColor = Color.FromArgb(25, Color.Black);
            Edit_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, Color.Black);
            Cancel_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, Color.Black);
            get_IDInstitutionList.DataSource = Datas.UniversitiesList; 
            BirthDateInputYear.DataSource = Datas.Years;
            BirthDateInputMonth.DataSource = Datas.monthList;
        }

        private void SecondNameInput_TextChanged(object sender, EventArgs e)
        {

        }
        internal void datatransfer(Stack<string> thedata) //не нужно в жизни, но нужно по лабе ¯\_(ツ)_/¯ 
        {
            string[] whatwegot = new string[7];
            string weneedit;
            for (int i = 0; i < 7; i++)
            {
                weneedit = thedata.Pop();
                whatwegot[i] = weneedit;
            }
            ID_lbloutput.Text = whatwegot[0];
            string[] fullname = whatwegot[1].Split('_');
            FirstNameInput.Text = fullname[1];
            SecondNameInput.Text = fullname[0];
            ThirdNameInput.Text = fullname[2];
            string[] thedate = whatwegot[2].Split('.');
            BirthDateInputYear.SelectedItem = thedate[2];
            BirthDateInputMonth.SelectedIndex = Convert.ToInt32(thedate[1]) - 1;
            BirthDateInputDay.DataSource = Datas.CheckBirthDate(BirthDateInputMonth.SelectedIndex, BirthDateInputYear.Text);
            BirthDateInputDay.SelectedItem = Convert.ToString(Convert.ToInt32(thedate[0]));
            get_IDInstitutionList.SelectedItem = whatwegot[3];
            Get_GroupID.SelectedText = whatwegot[4];
            get_IDYearOfStudyList.SelectedItem = whatwegot[5];
            gpaInput.Text = whatwegot[6];
        }


        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentListForm StartNewForm = new StudentListForm();
            StartNewForm.Show();
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            string ID = ID_lbloutput.Text;
            string Month;
            string Day;
            if (BirthDateInputMonth.SelectedIndex < 9)
            {
                Month = '0' + Convert.ToString(BirthDateInputMonth.SelectedIndex + 1);
            }
            else
            {
                Month = Convert.ToString(BirthDateInputMonth.SelectedIndex + 1);
            }
            if (Convert.ToInt32(BirthDateInputDay.Text) < 10)
            {
                Day = '0' + BirthDateInputDay.Text;
            }
            else
            {
                Day = BirthDateInputDay.Text;
            }
            IsSecondNameCorrect = Datas.IsTextOfNamesINPutValid(SecondNameInput.Text);
            IsFirstNameCorrect = Datas.IsTextOfNamesINPutValid(FirstNameInput.Text);
            IsThirdNameCorrect = Datas.IsTextOfNamesINPutValid(ThirdNameInput.Text);
            IsDateSetted = (BirthDateInputDay.SelectedIndex > -1 && BirthDateInputMonth.SelectedIndex > -1 && BirthDateInputYear.SelectedIndex > -1);
            IsInstitutionSetted = get_IDInstitutionList.SelectedIndex > -1;
            IsYearOfStudySetted = get_IDYearOfStudyList.SelectedIndex > -1 && get_IDYearOfStudyList.SelectedIndex < 4;
            IsGroupSetted = Get_GroupID.Text != "";
            bool parse = double.TryParse(gpaInput.Text, out double valGPA) && valGPA == Math.Round(valGPA, 2);

            IsGPASetted = (parse && valGPA >= 0 && valGPA <= 100);
            if (IsSecondNameCorrect && IsFirstNameCorrect && IsThirdNameCorrect && IsDateSetted && IsInstitutionSetted && IsGroupSetted && IsGPASetted && IsYearOfStudySetted)
            {
                string stroke = ID + ' ' + SecondNameInput.Text + '_' + FirstNameInput.Text + '_' + ThirdNameInput.Text + ' ' + Day + '.' + Month + '.' + BirthDateInputYear.Text + ' ' + get_IDInstitutionList.Text + ' ' + Get_GroupID.Text + ' ' + (get_IDYearOfStudyList.SelectedIndex + 1) + ' ' + gpaInput.Text;
                string[] LineElements = new string[7];
                string[] l = File.ReadAllLines(path);
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    for (int j = 0; j < l.Length; j++)
                    {
                        LineElements = l[j].Split(' ');
                        if (LineElements[0] == ID_lbloutput.Text && j + 1 == l.Length)
                        {
                            sw.Write(stroke);
                        }
                        else if (LineElements[0] == ID_lbloutput.Text)
                        {
                            sw.Write($"{stroke}\n");
                        }
                        else if (j + 1 == l.Length)
                        {
                            sw.Write(l[j]);
                        }
                        else
                        {
                            sw.Write($"{l[j]}\n");
                        }      
                    }
                }
                this.Close();
                StudentListForm StartNewForm = new StudentListForm();
                StartNewForm.Show();
            }
            else
            {
                ErrorChecks();
            }


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