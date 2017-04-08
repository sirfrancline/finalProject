namespace finalProject.GUI
{
    partial class AddStaff
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
            this.staffIDtxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addStaffBtn = new System.Windows.Forms.Button();
            this.surNameTxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNametxtbox = new System.Windows.Forms.TextBox();
            this.passTxtbox = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rePassTxtbox = new System.Windows.Forms.TextBox();
            this.rePass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // staffIDtxtbox
            // 
            this.staffIDtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffIDtxtbox.Location = new System.Drawing.Point(135, 21);
            this.staffIDtxtbox.Name = "staffIDtxtbox";
            this.staffIDtxtbox.Size = new System.Drawing.Size(100, 22);
            this.staffIDtxtbox.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Staff ID";
            // 
            // addStaffBtn
            // 
            this.addStaffBtn.Location = new System.Drawing.Point(135, 226);
            this.addStaffBtn.Name = "addStaffBtn";
            this.addStaffBtn.Size = new System.Drawing.Size(100, 23);
            this.addStaffBtn.TabIndex = 28;
            this.addStaffBtn.Text = "Add";
            this.addStaffBtn.UseVisualStyleBackColor = true;
            this.addStaffBtn.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // surNameTxtbox
            // 
            this.surNameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surNameTxtbox.Location = new System.Drawing.Point(135, 87);
            this.surNameTxtbox.Name = "surNameTxtbox";
            this.surNameTxtbox.Size = new System.Drawing.Size(100, 22);
            this.surNameTxtbox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Surname";
            // 
            // firstNametxtbox
            // 
            this.firstNametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNametxtbox.Location = new System.Drawing.Point(135, 54);
            this.firstNametxtbox.Name = "firstNametxtbox";
            this.firstNametxtbox.Size = new System.Drawing.Size(100, 22);
            this.firstNametxtbox.TabIndex = 25;
            // 
            // passTxtbox
            // 
            this.passTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxtbox.Location = new System.Drawing.Point(135, 151);
            this.passTxtbox.Name = "passTxtbox";
            this.passTxtbox.Size = new System.Drawing.Size(100, 22);
            this.passTxtbox.TabIndex = 24;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(135, 118);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(100, 22);
            this.usernameTxt.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Username";
            // 
            // rePassTxtbox
            // 
            this.rePassTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rePassTxtbox.Location = new System.Drawing.Point(135, 179);
            this.rePassTxtbox.Name = "rePassTxtbox";
            this.rePassTxtbox.Size = new System.Drawing.Size(100, 22);
            this.rePassTxtbox.TabIndex = 32;
            // 
            // rePass
            // 
            this.rePass.AutoSize = true;
            this.rePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rePass.Location = new System.Drawing.Point(-1, 179);
            this.rePass.Name = "rePass";
            this.rePass.Size = new System.Drawing.Size(130, 16);
            this.rePass.TabIndex = 31;
            this.rePass.Text = "Retype Password";
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rePassTxtbox);
            this.Controls.Add(this.rePass);
            this.Controls.Add(this.staffIDtxtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addStaffBtn);
            this.Controls.Add(this.surNameTxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstNametxtbox);
            this.Controls.Add(this.passTxtbox);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStaff";
            this.Text = "Add Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox staffIDtxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addStaffBtn;
        private System.Windows.Forms.TextBox surNameTxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNametxtbox;
        private System.Windows.Forms.TextBox passTxtbox;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rePassTxtbox;
        private System.Windows.Forms.Label rePass;
    }
}