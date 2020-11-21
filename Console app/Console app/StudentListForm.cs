using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            int n = 3;
            string str = "";

            List<string[]> data = new List<string[]>();
            for(int i = 0; i < n; i++)
            {
                data.Add(new string[7]);
 
                for (int j = 0; j < 7; j++)
                {
                    str = "[" + i.ToString() + ", " + j.ToString() + "]";
                    data[i][j] = str;


                }

            }

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
