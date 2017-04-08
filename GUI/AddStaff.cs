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
            var staffMember = new Staff
            {
                FirstName = firstNametxtbox.Text,
                Password = passTxtbox.Text,
                IdNumber = staffIDtxtbox.Text,
                Surname = surNameTxtbox.Text,
                Username = usernameTxt.Text,
            };

            var writer = new StaffWriter();
            writer.Add(staffMember);
            MessageBox.Show("Saved");
        }
    }
}
