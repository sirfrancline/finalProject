namespace finalProject.GUI
{
    partial class View_Equipment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_EquipmentID = new System.Windows.Forms.TextBox();
            this.listBox_viewEquipment = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_EquipmentID
            // 
            this.textBox_EquipmentID.Location = new System.Drawing.Point(16, 43);
            this.textBox_EquipmentID.Name = "textBox_EquipmentID";
            this.textBox_EquipmentID.Size = new System.Drawing.Size(202, 20);
            this.textBox_EquipmentID.TabIndex = 55;
            // 
            // listBox_viewEquipment
            // 
            this.listBox_viewEquipment.FormattingEnabled = true;
            this.listBox_viewEquipment.Location = new System.Drawing.Point(16, 83);
            this.listBox_viewEquipment.Name = "listBox_viewEquipment";
            this.listBox_viewEquipment.Size = new System.Drawing.Size(213, 147);
            this.listBox_viewEquipment.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Search Equipment By ID";
            // 
            // View_Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 261);
            this.Controls.Add(this.textBox_EquipmentID);
            this.Controls.Add(this.listBox_viewEquipment);
            this.Controls.Add(this.label2);
            this.Name = "View_Equipment";
            this.Text = "View_Equipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_EquipmentID;
        private System.Windows.Forms.ListBox listBox_viewEquipment;
        private System.Windows.Forms.Label label2;
    }
}