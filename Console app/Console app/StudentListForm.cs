using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console_app
{
    public partial class StudentListForm : Form
    {
        WorkingFlow Datas = new WorkingFlow();
        public bool IsFullNameActive;
        public bool IsBirthdayDateActive;

        
        public StudentListForm()
        {
            WorkingFlow Datas = new WorkingFlow();
            InitializeComponent();

            Datas.Filling();
            
            YearComboBox.DataSource = Datas.Years;
            MounthComboBox.DataSource = Datas.monthList;

        }

        private void Fill_List()
        {
            string path = @"StudentList.txt";
            List<string[]> data = new List<string[]>();

            
            if (File.Exists(path))
            {
                string[] LineElements = new string[7];
                string[] l = File.ReadAllLines(path);
                for(int i = 0; i < l.Length; i++)
                {
                    data.Add(new string[7]);
                    LineElements = l[i].Split(' ');
                    string[] str = LineElements[1].Split('_');
                    string s = str[0] + ' ' + str[1] + ' '+ str[2] + ' ';
                    LineElements[1] = s;

                    data[i] = LineElements;
 
                }
            }
            

            foreach (string[] s in data)
            {
                DataGridList.Rows.Add(s);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Application.Run(new AddingUserData_Form());
            AddingUserData_Form StartNewForm = new AddingUserData_Form();
            StartNewForm.Show();
            this.Visible = false;
            
        }

        private void FilterGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void FilterButton1_Click(object sender, EventArgs e)
        {
            
        }

        public static bool SearchFunc(string INPUT, string str0, string str1, string str2, int ind)
        {


            if (ind == 0)
            {
                string s = str0 + ' ' + str1 + ' ' + str2;
                if (((INPUT) == s) || (str0 == INPUT) || (str1 == INPUT) || (str2 == INPUT))
                {
                    return true;
                }
                else if (str0 + ' ' + str1 == INPUT)
                {
                    return true;
                }
                else if (str0 + ' ' + str2 == INPUT)
                {
                    return true;
                }
                else if (str1 + ' ' + str2 == INPUT)
                {
                    return true;
                }
                return false;
            }else if(ind == 1)
            {
                
                if (Convert.ToInt32(str0) < 10)
                {
                    str0 = '0' + str0;
                }
                if (Convert.ToInt32(str1) < 10)
                {
                    str1 = '0' + str1;
                }

                string s = str0 + "." + str1 + "." + str2;
                if (((INPUT == s) || (str0 == INPUT) || (str1 == INPUT) || (str2 == INPUT)))
                {
                    return true;
                }
                else if (str0 + '.' + str1 == INPUT)
                {
                    return true;
                }
                else if (str0 + '.' + str2 == INPUT)
                {
                    return true;
                }
                else if (str1 + '.' + str2 == INPUT)
                {
                    return true;
                }
                return false;
            }
            return false;
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataGridList.Rows.Clear();
            string path = @"StudentList.txt";
            List<string[]> data = new List<string[]>();
            string FullNameINPUT = FullNameTextBox.Text;

            if (File.Exists(path))
            {
                string[] LineElements = new string[7];
                string[] l = File.ReadAllLines(path);
                for (int i = 0; i < l.Length; i++)
                {

                    LineElements = l[i].Split(' ');
                    string[] str = LineElements[1].Split('_');
                 
                    string s = str[0] + ' ' + str[1] + ' ' + str[2] + ' ';
                    LineElements[1] = s;

                    if (IsFullNameActive)
                    {
                        if (SearchFunc(FullNameINPUT, str[0], str[1], str[2], 0))
                        {
                            data.Add(LineElements);
                        }
                            
                    } else if (IsBirthdayDateActive)
                    {
                        if (SearchFunc(LineElements[2], DayComboBox.Text, Convert.ToString(MounthComboBox.SelectedIndex + 1), YearComboBox.Text, 1))
                        {
                            data.Add(LineElements);
                        }
                    }else if (IsFullNameActive && IsBirthdayDateActive)
                    {
                        if (SearchFunc(FullNameINPUT, str[0], str[1], str[2], 0) && SearchFunc(LineElements[2], DayComboBox.Text, Convert.ToString(MounthComboBox.SelectedIndex + 1), YearComboBox.Text, 1));
                        {
                            data.Add(LineElements);
                        }



                    }
                }
                foreach (string[] s1 in data)
                {
                    DataGridList.Rows.Add(s1);
                }
            }
        }
               
        private void FullNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsFullNameActive = FullNameCheckBox.Checked;
        }

        private void BirthdayDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsBirthdayDateActive = BirthdayDateCheckBox.Checked;
        }

        private void DayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DayComboBox.DataSource = Datas.CheckBirthDate(MounthComboBox.SelectedIndex, YearComboBox.Text);
        }

        private void MounthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DayComboBox.DataSource = Datas.CheckBirthDate(MounthComboBox.SelectedIndex, YearComboBox.Text);
        }

        private void DayComboBox_Click(object sender, EventArgs e)
        {
            DayComboBox.DataSource = Datas.CheckBirthDate(MounthComboBox.SelectedIndex, YearComboBox.Text);
        }

        private void MounthComboBox_Click(object sender, EventArgs e)
        {
            DayComboBox.DataSource = Datas.CheckBirthDate(MounthComboBox.SelectedIndex, YearComboBox.Text);
        }

        private void MounthComboBox_Leave(object sender, EventArgs e)
        {
            DayComboBox.DataSource = Datas.CheckBirthDate(MounthComboBox.SelectedIndex, YearComboBox.Text);
        }

        private void DayComboBox_Leave(object sender, EventArgs e)
        { 
           // DayComboBox.DataSource = Datas.CheckBirthDate(MounthComboBox.SelectedIndex, YearComboBox.Text);
        }

        private void StudentListButton_Click(object sender, EventArgs e)
        {
            Fill_List();
        }
    }
}
