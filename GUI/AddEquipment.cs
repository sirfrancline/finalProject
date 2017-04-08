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
    public partial class AddEquipment : Form
    {
        public AddEquipment()
        {
            InitializeComponent();
        }

        private void addEqTxtbox_Click(object sender, EventArgs e)
        {
            var colleEquipment = new Equimpment()
            {
                ID = eqIDtxtbox.Text,
                Type = eqTypeTxtbox.Text,
                Description = eqDescriptionTxtbox.Text,
                MaxRentalDays = Convert.ToInt32(maxRentalDayTxtbox.Text)



            };

            var eqWriter = new EquipmentWriter();
            eqWriter.Add(colleEquipment);
            MessageBox.Show("new equipment saved");
        }
    }
}
