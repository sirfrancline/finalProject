using finalProject.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject.Operations
{
    public partial class theRentalSystem : Form
    {
        public theRentalSystem()
        {
            InitializeComponent();
        }

        private void theRentalSystem_Load(object sender, EventArgs e)
        {

        }

        private void theRentalSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);  //close application
        }
        ViewAddUpdateDeleteStaff _staffForm = new ViewAddUpdateDeleteStaff();
        private void staffBtn_Click(object sender, EventArgs e)
        {
            _staffForm.ShowDialog();
            
        }
    }
}
