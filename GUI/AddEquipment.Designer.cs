namespace finalProject.GUI
{
    partial class AddEquipment
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
            this.addEqTxtbox = new System.Windows.Forms.Button();
            this.maxRentalDayTxtbox = new System.Windows.Forms.TextBox();
            this.eqDescriptionTxtbox = new System.Windows.Forms.TextBox();
            this.eqTypeTxtbox = new System.Windows.Forms.TextBox();
            this.eqIDtxtbox = new System.Windows.Forms.TextBox();
            this.eqNameTxtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addEqTxtbox
            // 
            this.addEqTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEqTxtbox.Location = new System.Drawing.Point(172, 226);
            this.addEqTxtbox.Name = "addEqTxtbox";
            this.addEqTxtbox.Size = new System.Drawing.Size(100, 23);
            this.addEqTxtbox.TabIndex = 34;
            this.addEqTxtbox.Text = "Add";
            this.addEqTxtbox.UseVisualStyleBackColor = true;
            this.addEqTxtbox.Click += new System.EventHandler(this.addEqTxtbox_Click);
            // 
            // maxRentalDayTxtbox
            // 
            this.maxRentalDayTxtbox.Location = new System.Drawing.Point(172, 176);
            this.maxRentalDayTxtbox.Name = "maxRentalDayTxtbox";
            this.maxRentalDayTxtbox.ReadOnly = true;
            this.maxRentalDayTxtbox.Size = new System.Drawing.Size(100, 20);
            this.maxRentalDayTxtbox.TabIndex = 33;
            this.maxRentalDayTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // eqDescriptionTxtbox
            // 
            this.eqDescriptionTxtbox.Location = new System.Drawing.Point(172, 150);
            this.eqDescriptionTxtbox.Name = "eqDescriptionTxtbox";
            this.eqDescriptionTxtbox.Size = new System.Drawing.Size(100, 20);
            this.eqDescriptionTxtbox.TabIndex = 32;
            // 
            // eqTypeTxtbox
            // 
            this.eqTypeTxtbox.Location = new System.Drawing.Point(172, 110);
            this.eqTypeTxtbox.Name = "eqTypeTxtbox";
            this.eqTypeTxtbox.Size = new System.Drawing.Size(100, 20);
            this.eqTypeTxtbox.TabIndex = 31;
            // 
            // eqIDtxtbox
            // 
            this.eqIDtxtbox.Location = new System.Drawing.Point(172, 77);
            this.eqIDtxtbox.Name = "eqIDtxtbox";
            this.eqIDtxtbox.Size = new System.Drawing.Size(100, 20);
            this.eqIDtxtbox.TabIndex = 30;
            // 
            // eqNameTxtbox
            // 
            this.eqNameTxtbox.Location = new System.Drawing.Point(172, 31);
            this.eqNameTxtbox.Name = "eqNameTxtbox";
            this.eqNameTxtbox.Size = new System.Drawing.Size(100, 20);
            this.eqNameTxtbox.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Max Rental Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Equipment ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name";
            // 
            // AddEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.addEqTxtbox);
            this.Controls.Add(this.maxRentalDayTxtbox);
            this.Controls.Add(this.eqDescriptionTxtbox);
            this.Controls.Add(this.eqTypeTxtbox);
            this.Controls.Add(this.eqIDtxtbox);
            this.Controls.Add(this.eqNameTxtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEquipment";
            this.Text = "Add Equipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEqTxtbox;
        private System.Windows.Forms.TextBox maxRentalDayTxtbox;
        private System.Windows.Forms.TextBox eqDescriptionTxtbox;
        private System.Windows.Forms.TextBox eqTypeTxtbox;
        private System.Windows.Forms.TextBox eqIDtxtbox;
        private System.Windows.Forms.TextBox eqNameTxtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}