namespace finalProject.GUI
{
    partial class ViewAddUpdateDeleteStaff
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
            this.updateStaffBtn = new System.Windows.Forms.Button();
            this.DeleteStaffBtn = new System.Windows.Forms.Button();
            this.addStaffBtn = new System.Windows.Forms.Button();
            this.staffIDtextbox = new System.Windows.Forms.TextBox();
            this.searchStaffBtn = new System.Windows.Forms.Button();
            this.StaffListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rePassTxtbox = new System.Windows.Forms.TextBox();
            this.rePass = new System.Windows.Forms.Label();
            this.staffIDtxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.surNameTxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNametxtbox = new System.Windows.Forms.TextBox();
            this.passTxtbox = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateStaffBtn
            // 
            this.updateStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStaffBtn.Location = new System.Drawing.Point(305, 393);
            this.updateStaffBtn.Name = "updateStaffBtn";
            this.updateStaffBtn.Size = new System.Drawing.Size(112, 23);
            this.updateStaffBtn.TabIndex = 23;
            this.updateStaffBtn.Text = "Save";
            this.updateStaffBtn.UseVisualStyleBackColor = true;
            this.updateStaffBtn.Click += new System.EventHandler(this.updateStaffBtn_Click);
            // 
            // DeleteStaffBtn
            // 
            this.DeleteStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteStaffBtn.Location = new System.Drawing.Point(173, 393);
            this.DeleteStaffBtn.Name = "DeleteStaffBtn";
            this.DeleteStaffBtn.Size = new System.Drawing.Size(112, 23);
            this.DeleteStaffBtn.TabIndex = 22;
            this.DeleteStaffBtn.Text = "Delete";
            this.DeleteStaffBtn.UseVisualStyleBackColor = true;
            // 
            // addStaffBtn
            // 
            this.addStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaffBtn.Location = new System.Drawing.Point(26, 393);
            this.addStaffBtn.Name = "addStaffBtn";
            this.addStaffBtn.Size = new System.Drawing.Size(112, 23);
            this.addStaffBtn.TabIndex = 21;
            this.addStaffBtn.Text = "Add";
            this.addStaffBtn.UseVisualStyleBackColor = true;
            // 
            // staffIDtextbox
            // 
            this.staffIDtextbox.Location = new System.Drawing.Point(45, 55);
            this.staffIDtextbox.Name = "staffIDtextbox";
            this.staffIDtextbox.Size = new System.Drawing.Size(167, 20);
            this.staffIDtextbox.TabIndex = 19;
            // 
            // searchStaffBtn
            // 
            this.searchStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStaffBtn.Location = new System.Drawing.Point(227, 52);
            this.searchStaffBtn.Name = "searchStaffBtn";
            this.searchStaffBtn.Size = new System.Drawing.Size(112, 23);
            this.searchStaffBtn.TabIndex = 18;
            this.searchStaffBtn.Text = "Search";
            this.searchStaffBtn.UseVisualStyleBackColor = true;
            // 
            // StaffListBox
            // 
            this.StaffListBox.FormattingEnabled = true;
            this.StaffListBox.Location = new System.Drawing.Point(45, 93);
            this.StaffListBox.Name = "StaffListBox";
            this.StaffListBox.Size = new System.Drawing.Size(372, 134);
            this.StaffListBox.TabIndex = 17;
            this.StaffListBox.SelectedValueChanged += new System.EventHandler(this.StaffListBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search Staff By ID";
            // 
            // rePassTxtbox
            // 
            this.rePassTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rePassTxtbox.Location = new System.Drawing.Point(305, 345);
            this.rePassTxtbox.Name = "rePassTxtbox";
            this.rePassTxtbox.Size = new System.Drawing.Size(100, 22);
            this.rePassTxtbox.TabIndex = 44;
            // 
            // rePass
            // 
            this.rePass.AutoSize = true;
            this.rePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rePass.Location = new System.Drawing.Point(230, 351);
            this.rePass.Name = "rePass";
            this.rePass.Size = new System.Drawing.Size(64, 16);
            this.rePass.TabIndex = 43;
            this.rePass.Text = "Confirm:";
            this.rePass.Click += new System.EventHandler(this.rePass_Click);
            // 
            // staffIDtxtbox
            // 
            this.staffIDtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffIDtxtbox.Location = new System.Drawing.Point(112, 302);
            this.staffIDtxtbox.Name = "staffIDtxtbox";
            this.staffIDtxtbox.Size = new System.Drawing.Size(100, 22);
            this.staffIDtxtbox.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "ID:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // surNameTxtbox
            // 
            this.surNameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surNameTxtbox.Location = new System.Drawing.Point(305, 257);
            this.surNameTxtbox.Name = "surNameTxtbox";
            this.surNameTxtbox.Size = new System.Drawing.Size(100, 22);
            this.surNameTxtbox.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Surname";
            // 
            // firstNametxtbox
            // 
            this.firstNametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNametxtbox.Location = new System.Drawing.Point(112, 257);
            this.firstNametxtbox.Name = "firstNametxtbox";
            this.firstNametxtbox.Size = new System.Drawing.Size(100, 22);
            this.firstNametxtbox.TabIndex = 38;
            // 
            // passTxtbox
            // 
            this.passTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxtbox.Location = new System.Drawing.Point(112, 345);
            this.passTxtbox.Name = "passTxtbox";
            this.passTxtbox.Size = new System.Drawing.Size(100, 22);
            this.passTxtbox.TabIndex = 37;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(305, 302);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(100, 22);
            this.usernameTxt.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(216, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Username";
            // 
            // ViewAddUpdateDeleteStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 512);
            this.Controls.Add(this.rePassTxtbox);
            this.Controls.Add(this.rePass);
            this.Controls.Add(this.staffIDtxtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.surNameTxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstNametxtbox);
            this.Controls.Add(this.passTxtbox);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.updateStaffBtn);
            this.Controls.Add(this.DeleteStaffBtn);
            this.Controls.Add(this.addStaffBtn);
            this.Controls.Add(this.staffIDtextbox);
            this.Controls.Add(this.searchStaffBtn);
            this.Controls.Add(this.StaffListBox);
            this.Controls.Add(this.label1);
            this.Name = "ViewAddUpdateDeleteStaff";
            this.Text = "View Add Update Delete Staff";
            this.Load += new System.EventHandler(this.ViewAddUpdateDeleteStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateStaffBtn;
        private System.Windows.Forms.Button DeleteStaffBtn;
        private System.Windows.Forms.Button addStaffBtn;
        private System.Windows.Forms.TextBox staffIDtextbox;
        private System.Windows.Forms.Button searchStaffBtn;
        private System.Windows.Forms.ListBox StaffListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rePassTxtbox;
        private System.Windows.Forms.Label rePass;
        private System.Windows.Forms.TextBox staffIDtxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox surNameTxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNametxtbox;
        private System.Windows.Forms.TextBox passTxtbox;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}