using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Console_app
{
    public partial class EditStudentForm : Form
    {
        public EditStudentForm(string input)
        {
            InitializeComponent();
            SecondNameInput.Text = "Кузнецов";
        }

        private void SecondNameInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
