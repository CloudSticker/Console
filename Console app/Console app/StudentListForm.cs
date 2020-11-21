using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
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
            

            /*
            int n = 3;
            string str = "";
            for (int i = 0; i < n; i++)
            {
                data.Add(new string[7]);

                for (int j = 0; j < 7; j++)
                {
                    str = "[" + i.ToString() + ", " + j.ToString() + "]";
                    data[i][j] = str;


                }

            }
            */

            foreach (string[] s in data)
            {
                DataGridList.Rows.Add(s);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Application.Run(new AddingUserData_Form());
            AddingUserData_Form StartNewForm = new AddingUserData_Form();
            StartNewForm.Show();
            this.Visible = false;
            
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
