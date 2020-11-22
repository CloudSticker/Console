using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console_app
{

    public partial class AddingUserData_Form : Form
    {
        WorkingFlow Datas = new WorkingFlow();
        public AddingUserData_Form()
        {
            InitializeComponent();
            WorkingFlow Datas = new WorkingFlow();
            Datas.Filling();
            BirthDateInputYear.DataSource = Datas.Years;
            BirthDateInputMonth.DataSource = Datas.monthList;
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

        static bool IsTextOfNamesINPutValid(String enter)
        {
            bool CapitalCheck = true;
            bool IsActualWord = true;
            for (int i = 0; (i < enter.Length) && IsActualWord && CapitalCheck; i++)
            {
                IsActualWord = (enter[i] <= 'я' && enter[i] >= 'А');
                CapitalCheck = enter[0] == enter.ToUpper()[0];
            }

            return CapitalCheck && IsActualWord;
        }
        private void Add_Button_Click(object sender, EventArgs e)
        {
            bool IsSecondNameCorrect = IsTextOfNamesINPutValid(SecondNameInput.Text);
            bool IsFirstNameCorrect = IsTextOfNamesINPutValid(FirstNameInput.Text);
            bool IsThirdNameCorrect = IsTextOfNamesINPutValid(ThirdNameInput.Text);
            bool IsEverythingCorrect = IsSecondNameCorrect && IsFirstNameCorrect && IsThirdNameCorrect;
            if (IsEverythingCorrect)
            {
                //debug.Text = SecondNameInput.Text + FirstNameInput.Text + ThirdNameInput.Text;
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

        
    }
}
