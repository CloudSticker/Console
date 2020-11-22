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
        List<string> Months = new List<string>
        {
           //new DayS { Id=1, "Январь" },
        };
        public AddingUserData_Form()
        {
            InitializeComponent();
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
                debug.Text = SecondNameInput.Text + FirstNameInput.Text + ThirdNameInput.Text;
            }

        }

    }
}
