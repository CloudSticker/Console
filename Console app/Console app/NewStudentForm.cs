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
    }
}
