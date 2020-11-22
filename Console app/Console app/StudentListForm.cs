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
        public StudentListForm()
        {
            InitializeComponent();
            Fill_List();


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

        private void ComparisonCells() //Нахождение определённых студентов по функциям поиска
        {

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

        public static bool SearchFunc(string FullNameINPUT, string str0, string str1, string str2)
        {
            string s = str0 + ' ' + str1 + ' ' + str2;
            if (((FullNameINPUT + ' ') == s) || (str0 == FullNameINPUT) || (str1 == FullNameINPUT) || (str2 == FullNameINPUT))
            {
                return true;
            }
            else if (str0 + ' ' + str1 == FullNameINPUT)
            {
                return true;
            }
            else if (str0 + ' ' + str2 == FullNameINPUT)
            {
                return true;
            }
            else if (str1 + ' ' + str2 == FullNameINPUT)
            {
                return true;
            }
            return false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataGridList.Rows.Clear();
            string path = @"StudentList.txt";
            List<string[]> data = new List<string[]>();
            string FullNameINPUT = FullNameTextBox.Text;
            string BirthdayDateINPUT = BirthdayDateTextBox.Text;

            if (File.Exists(path))
            {
                int k = 0;
                string[] LineElements = new string[7];
                string[] l = File.ReadAllLines(path);
                for (int i = 0; i < l.Length; i++)
                {
                    
                        
                    LineElements = l[i].Split(' ');
                    string[] str = LineElements[1].Split('_');
                    int[] int1 = new int[2];
                    for (int j = 0; j < 3; j++)
                    {
                        int.TryParse(LineElements[2].Split('.')[j], out int1[j]);
                    }

                    string s = str[0] + ' ' + str[1] + ' ' + str[2] + ' ';
                    LineElements[1] = s;

                    if (SearchFunc(FullNameINPUT, str[0],  str[1], str[2]))
                    {
                        data.Add(new string[7]);
                        data[k] = LineElements;
                        k++;
                    }

                }
               
                foreach (string[] s in data)
                {
                    DataGridList.Rows.Add(s);
                }
            }
        
            
        }
    }
}
