using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Console_app
{
    public partial class Form1 : Form
    {
        private Stack<String> mystack = new Stack<string> { };
        public Form1()
        {
            InitializeComponent();
            
            
            
            

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        internal void datatransfer(Stack<String> thedata)
        {
            for (int i = 0; i < 7; i++)
            {
                mystack.Push(thedata.Pop());
            }
            
            if (mystack.Peek() != null)
            {
                for (int i = 0; i < 7; i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = mystack.Pop();
                    listView1.Items.Add(lvi);
                }
            }
        }
        internal void datatransfer(Queue<String> thedata)
        {
            for (int i = 0; i < 7; i++)
            {
                mystack.Push(thedata.Dequeue());
            }

            if (mystack.Peek() != null)
            {
                for (int i = 0; i < 7; i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = mystack.Pop();
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentListForm StartNewForm = new StudentListForm();
            StartNewForm.Show();
        }
    }
}
