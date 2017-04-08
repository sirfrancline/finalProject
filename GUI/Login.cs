using finalProject.Operations;
using finalProject.Persistence.Readers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject.classes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var reader = new StaffReader();
            var canWeOpenNextForm = reader.Authorize(usernameTxtbox.Text, passTxtbox.Text);
            if (canWeOpenNextForm)
            {
                var rentalSystem = new theRentalSystem();
                rentalSystem.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("User/Password do not match...");
                passTxtbox.Text = string.Empty;
            }
        }

        private void passTxtbox_TextChanged(object sender, EventArgs e)
        {

        }    

        private void Login_Load(object sender, EventArgs e)
        {
           
        }
    }
}
