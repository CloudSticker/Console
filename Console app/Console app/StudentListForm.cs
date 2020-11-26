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
        public int RowNum;
        Stack<string> newdata = new Stack<string>();
        public StudentListForm()
        {
            WorkingFlow Datas = new WorkingFlow();
            InitializeComponent();
            AddContextMenu();
            Datas.Filling();
            
            YearComboBox.DataSource = Datas.Years;
            MounthComboBox.DataSource = Datas.monthList;

        }

        private void DeleteStudent(int ID)
        {

        }

        internal List<string[]> data = new List<string[]>();

        private void Fill_List()
        {
            data = new List<string[]>();
            DataGridList.Rows.Clear();
            string path = @"StudentList.txt";
            

            
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
        private void Fill_List(int ind)
        {
            DataGridList.Rows.Clear();
            string path = @"StudentList.txt";
            data = new List<string[]>();

            if (File.Exists(path))
            {
                string[] LineElements = new string[7];
                string[] l = File.ReadAllLines(path);
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    for (int j = 0; j < l.Length; j++)
                    {
                        LineElements = l[j].Split(' ');
                        if (LineElements[0] == ind.ToString())
                            continue;
                            sw.Write($"{l[j]}\r\n");
                    }
                }

                foreach (string[] s in data)
                {
                    DataGridList.Rows.Add(s);
                }
                DataGridList.Rows.Clear();
                Fill_List();
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
        ToolStripMenuItem m = new ToolStripMenuItem();
        ToolStripMenuItem m1 = new ToolStripMenuItem();
        private void AddContextMenu()
        {
            m.Text = "Edit";
            m.Click += new EventHandler(toolChangeItem2_Click);

            m1.Text = "Delete";
            m1.Click += new EventHandler(toolDeleteItem_Click);
            
            ContextMenuStrip strip = new ContextMenuStrip();
            foreach (DataGridViewColumn column in DataGridList.Columns)
            {

                column.ContextMenuStrip = strip;
                column.ContextMenuStrip.Items.Add(m);
                column.ContextMenuStrip.Items.Add(m1);
            }
        }

        private DataGridViewCellEventArgs mouseLocation;

        // Change the cell's color.
        private void toolDeleteItem_Click(object sender, EventArgs args)
        {
            /*
            if (this.DataGridList.SelectedRows.Count > 0)
                foreach (DataGridViewRow drv in DataGridList.SelectedRows)
                {
                    
                    DataGridList.Rows.Remove(drv);
                    
                }*/
            Fill_List(RowNum);
        }
        private void toolChangeItem2_Click(object sender, EventArgs args)
        {
            if (RowNum >= 0)
            {
                EditStudentForm StartNewForm = new EditStudentForm();
                StartNewForm.Show();
                string path = @"StudentList.txt";
                string[] l = File.ReadAllLines(path);
                string[] LineElements;
                for (int i = 0; i < l.Length; i++)
                {
                    LineElements = l[i].Split(' ');
                    if (LineElements[0] == RowNum.ToString())
                    {
                        //FullNameCheckBox.Text = RowNum.ToString();
                        //BirthdayDateCheckBox.Text = LineElements[1];
                        for (int j = 6; j >= 0; j--)
                        {
                            newdata.Push(LineElements[j]);
                            //BirthdayDateCheckBox.Text = newdata.Peek();
                        }
                        break;
                    }
                }
                StartNewForm.datatransfer(newdata);
                this.Visible = false;
            }

        }

        // Deal with hovering over a cell.
        private void dataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs location)
        {
            mouseLocation = location;
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
                    if (IsFullNameActive && IsBirthdayDateActive)
                    {
                        if (SearchFunc(FullNameINPUT, str[0], str[1], str[2], 0) && SearchFunc(LineElements[2], DayComboBox.Text, Convert.ToString(MounthComboBox.SelectedIndex + 1), YearComboBox.Text, 1))
                        {
                            data.Add(LineElements);
                        }



                    }else if (IsBirthdayDateActive)
                    {
                        if (SearchFunc(LineElements[2], DayComboBox.Text, Convert.ToString(MounthComboBox.SelectedIndex + 1), YearComboBox.Text, 1))
                        {
                            data.Add(LineElements);
                        }
                    }else if (IsFullNameActive)
                    {
                        if (SearchFunc(FullNameINPUT, str[0], str[1], str[2], 0))
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
            List<string[]> data = new List<string[]>();
            Fill_List();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void DataGridList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((0 <= e.RowIndex) && ( e.RowIndex < data.Count))
            {
                string[] s = data[e.RowIndex];
                RowNum = Convert.ToInt32(s[0]);
            } else {
                RowNum = -1;
            }
            
        }
    }

}
