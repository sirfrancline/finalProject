using finalProject.Persistence.Writers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject.GUI
{
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            var stuffMember = new Staff
            {
                FirstName = textBox_Fn.Text,
                Password = textBox_Pass.Text,
                IdNumber = textBox_ID.Text,
                Surname = textBox_sN.Text,
                Username = textBox_UserN.Text,
            };

            var writer = new StaffWriter();
            writer.Add(stuffMember);
            MessageBox.Show("Saved");
        }
    }
}
