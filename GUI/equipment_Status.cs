﻿using finalProject.Persistence.Readers;
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
    public partial class equipment_Status : Form
    {

        EquipmentReader _reader = new EquipmentReader();



        public equipment_Status()
        {
            InitializeComponent();
        }

        private void btn_viewStatus_Click(object sender, EventArgs e)
        {

        }

        private void equipment_Status_Load(object sender, EventArgs e)
        {
            var items = _reader.GetAllEquipment();

            listBox1.Items.Clear();
            foreach (var item in items)
            {
                listBox1.Items.Add($"{item.Value.ID}, {item.Value.Type},{item.Value.Description}  ");
            }
        }
    }
}
