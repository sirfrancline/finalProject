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

namespace finalProject.GUI
{
    public partial class ViewAddUpdateDeleteStaff : Form
    {
        public ViewAddUpdateDeleteStaff()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rePass_Click(object sender, EventArgs e)
        {

        }

        private void updateStaffBtn_Click(object sender, EventArgs e)
        {

        }

        StaffReader _staffReader = new StaffReader();
        private Dictionary<string, Staff> _list;

        private void ViewAddUpdateDeleteStaff_Load(object sender, EventArgs e)
        {
            StaffListBox.Items.Clear();
            _list = _staffReader.GetAllStuffMembers();

            
            foreach (var item in _list)
            {
                StaffListBox.Items.Add($"{item.Value.IdNumber}, {item.Value.FirstName}, {item.Value.Surname}");
            }

        }

        private void StaffListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (StaffListBox.SelectedIndex != -1)
            {
                var selected = (string)StaffListBox.Items[StaffListBox.SelectedIndex];
                var id = selected.Split(',');
                var entry = _list[id[0]];
                usernameTxt.Text = entry.Username;
                surNameTxtbox.Text = entry.Surname;
                
            }
        }
    }
}
