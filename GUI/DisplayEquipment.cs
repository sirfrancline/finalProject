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
    public partial class View_Equipment : Form
    {
        public View_Equipment()
        {
            InitializeComponent();
        }
        private Dictionary<string, Equimpment> _equipment;
        private string ID;

      
        private void searchEqBtn_Click(object sender, EventArgs e)
        {
            var exist = _equipment.ContainsKey(searchEqIDtxtbox.Text);
                if(exist)
            {
             //displayEqlbox = string.Format("{0}({1})", _equipment.Key, _equipment.Values);

               
            }
          else

          {

                            MessageBox.Show(" Equipment ID doesn't match any item");
            }

                


        }

        private void viewEqBtn_Click(object sender, EventArgs e)
        {
            foreach (var eq in _equipment)
            {


             //   displayAllEqlbox = eq.Key.;
            }
        }
    }
}
