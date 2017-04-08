namespace GUI
{
    partial class DisplayStaffMembers
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
            this.label1 = new System.Windows.Forms.Label();
            this.viewStaffBtn = new System.Windows.Forms.Button();
            this.displayStaffs = new System.Windows.Forms.ListBox();
            this.searchStaffBtn = new System.Windows.Forms.Button();
            this.searchStaffDtxtbox = new System.Windows.Forms.TextBox();
            this.displayStaff = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Display All Staff";
            // 
            // viewStaffBtn
            // 
            this.viewStaffBtn.Location = new System.Drawing.Point(502, 61);
            this.viewStaffBtn.Name = "viewStaffBtn";
            this.viewStaffBtn.Size = new System.Drawing.Size(104, 23);
            this.viewStaffBtn.TabIndex = 72;
            this.viewStaffBtn.Text = "VIEW";
            this.viewStaffBtn.UseVisualStyleBackColor = true;
            // 
            // displayStaffs
            // 
            this.displayStaffs.FormattingEnabled = true;
            this.displayStaffs.Location = new System.Drawing.Point(310, 101);
            this.displayStaffs.Name = "displayStaffs";
            this.displayStaffs.Size = new System.Drawing.Size(296, 199);
            this.displayStaffs.TabIndex = 71;
            // 
            // searchStaffBtn
            // 
            this.searchStaffBtn.Location = new System.Drawing.Point(229, 61);
            this.searchStaffBtn.Name = "searchStaffBtn";
            this.searchStaffBtn.Size = new System.Drawing.Size(75, 23);
            this.searchStaffBtn.TabIndex = 70;
            this.searchStaffBtn.Text = "SEARCH";
            this.searchStaffBtn.UseVisualStyleBackColor = true;
            // 
            // searchStaffDtxtbox
            // 
            this.searchStaffDtxtbox.Location = new System.Drawing.Point(15, 63);
            this.searchStaffDtxtbox.Name = "searchStaffDtxtbox";
            this.searchStaffDtxtbox.Size = new System.Drawing.Size(208, 20);
            this.searchStaffDtxtbox.TabIndex = 69;
            // 
            // displayStaff
            // 
            this.displayStaff.FormattingEnabled = true;
            this.displayStaff.Location = new System.Drawing.Point(15, 101);
            this.displayStaff.Name = "displayStaff";
            this.displayStaff.Size = new System.Drawing.Size(289, 69);
            this.displayStaff.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Search Staff By ID";
            // 
            // DisplayStaffMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewStaffBtn);
            this.Controls.Add(this.displayStaffs);
            this.Controls.Add(this.searchStaffBtn);
            this.Controls.Add(this.searchStaffDtxtbox);
            this.Controls.Add(this.displayStaff);
            this.Controls.Add(this.label2);
            this.Name = "DisplayStaffMembers";
            this.Text = "Display Staff Member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewStaffBtn;
        private System.Windows.Forms.ListBox displayStaffs;
        private System.Windows.Forms.Button searchStaffBtn;
        private System.Windows.Forms.TextBox searchStaffDtxtbox;
        private System.Windows.Forms.ListBox displayStaff;
        private System.Windows.Forms.Label label2;
    }
}

