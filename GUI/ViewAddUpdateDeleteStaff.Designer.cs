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
            this.viewStaffBtn = new System.Windows.Forms.Button();
            this.staffIDtextbox = new System.Windows.Forms.TextBox();
            this.searchStaffBtn = new System.Windows.Forms.Button();
            this.StaffListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateStaffBtn
            // 
            this.updateStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStaffBtn.Location = new System.Drawing.Point(274, 188);
            this.updateStaffBtn.Name = "updateStaffBtn";
            this.updateStaffBtn.Size = new System.Drawing.Size(112, 23);
            this.updateStaffBtn.TabIndex = 23;
            this.updateStaffBtn.Text = "Update";
            this.updateStaffBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteStaffBtn
            // 
            this.DeleteStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteStaffBtn.Location = new System.Drawing.Point(274, 143);
            this.DeleteStaffBtn.Name = "DeleteStaffBtn";
            this.DeleteStaffBtn.Size = new System.Drawing.Size(112, 23);
            this.DeleteStaffBtn.TabIndex = 22;
            this.DeleteStaffBtn.Text = "Delete";
            this.DeleteStaffBtn.UseVisualStyleBackColor = true;
            // 
            // addStaffBtn
            // 
            this.addStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaffBtn.Location = new System.Drawing.Point(274, 104);
            this.addStaffBtn.Name = "addStaffBtn";
            this.addStaffBtn.Size = new System.Drawing.Size(112, 23);
            this.addStaffBtn.TabIndex = 21;
            this.addStaffBtn.Text = "Add";
            this.addStaffBtn.UseVisualStyleBackColor = true;
            // 
            // viewStaffBtn
            // 
            this.viewStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStaffBtn.Location = new System.Drawing.Point(274, 77);
            this.viewStaffBtn.Name = "viewStaffBtn";
            this.viewStaffBtn.Size = new System.Drawing.Size(112, 23);
            this.viewStaffBtn.TabIndex = 20;
            this.viewStaffBtn.Text = "View";
            this.viewStaffBtn.UseVisualStyleBackColor = true;
            // 
            // staffIDtextbox
            // 
            this.staffIDtextbox.Location = new System.Drawing.Point(5, 32);
            this.staffIDtextbox.Name = "staffIDtextbox";
            this.staffIDtextbox.Size = new System.Drawing.Size(167, 20);
            this.staffIDtextbox.TabIndex = 19;
            // 
            // searchStaffBtn
            // 
            this.searchStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStaffBtn.Location = new System.Drawing.Point(274, 32);
            this.searchStaffBtn.Name = "searchStaffBtn";
            this.searchStaffBtn.Size = new System.Drawing.Size(112, 23);
            this.searchStaffBtn.TabIndex = 18;
            this.searchStaffBtn.Text = "Search";
            this.searchStaffBtn.UseVisualStyleBackColor = true;
            // 
            // StaffListBox
            // 
            this.StaffListBox.FormattingEnabled = true;
            this.StaffListBox.Location = new System.Drawing.Point(5, 77);
            this.StaffListBox.Name = "StaffListBox";
            this.StaffListBox.Size = new System.Drawing.Size(252, 134);
            this.StaffListBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search Staff By ID";
            // 
            // ViewAddUpdateDeleteStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 261);
            this.Controls.Add(this.updateStaffBtn);
            this.Controls.Add(this.DeleteStaffBtn);
            this.Controls.Add(this.addStaffBtn);
            this.Controls.Add(this.viewStaffBtn);
            this.Controls.Add(this.staffIDtextbox);
            this.Controls.Add(this.searchStaffBtn);
            this.Controls.Add(this.StaffListBox);
            this.Controls.Add(this.label1);
            this.Name = "ViewAddUpdateDeleteStaff";
            this.Text = "View Add Update Delete Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateStaffBtn;
        private System.Windows.Forms.Button DeleteStaffBtn;
        private System.Windows.Forms.Button addStaffBtn;
        private System.Windows.Forms.Button viewStaffBtn;
        private System.Windows.Forms.TextBox staffIDtextbox;
        private System.Windows.Forms.Button searchStaffBtn;
        private System.Windows.Forms.ListBox StaffListBox;
        private System.Windows.Forms.Label label1;
    }
}