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
            this.Btn_UpdateS = new System.Windows.Forms.Button();
            this.Btn_DeleteS = new System.Windows.Forms.Button();
            this.Btn_AddS = new System.Windows.Forms.Button();
            this.Btn_View = new System.Windows.Forms.Button();
            this.textBox_StaffID = new System.Windows.Forms.TextBox();
            this.Btn_SearchID = new System.Windows.Forms.Button();
            this.listBox_Staff = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_UpdateS
            // 
            this.Btn_UpdateS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpdateS.Location = new System.Drawing.Point(213, 188);
            this.Btn_UpdateS.Name = "Btn_UpdateS";
            this.Btn_UpdateS.Size = new System.Drawing.Size(112, 23);
            this.Btn_UpdateS.TabIndex = 23;
            this.Btn_UpdateS.Text = "Update";
            this.Btn_UpdateS.UseVisualStyleBackColor = true;
            // 
            // Btn_DeleteS
            // 
            this.Btn_DeleteS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteS.Location = new System.Drawing.Point(213, 144);
            this.Btn_DeleteS.Name = "Btn_DeleteS";
            this.Btn_DeleteS.Size = new System.Drawing.Size(112, 23);
            this.Btn_DeleteS.TabIndex = 22;
            this.Btn_DeleteS.Text = "Delete";
            this.Btn_DeleteS.UseVisualStyleBackColor = true;
            // 
            // Btn_AddS
            // 
            this.Btn_AddS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddS.Location = new System.Drawing.Point(213, 104);
            this.Btn_AddS.Name = "Btn_AddS";
            this.Btn_AddS.Size = new System.Drawing.Size(112, 23);
            this.Btn_AddS.TabIndex = 21;
            this.Btn_AddS.Text = "Add";
            this.Btn_AddS.UseVisualStyleBackColor = true;
            // 
            // Btn_View
            // 
            this.Btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_View.Location = new System.Drawing.Point(213, 75);
            this.Btn_View.Name = "Btn_View";
            this.Btn_View.Size = new System.Drawing.Size(112, 23);
            this.Btn_View.TabIndex = 20;
            this.Btn_View.Text = "View";
            this.Btn_View.UseVisualStyleBackColor = true;
            // 
            // textBox_StaffID
            // 
            this.textBox_StaffID.Location = new System.Drawing.Point(5, 32);
            this.textBox_StaffID.Name = "textBox_StaffID";
            this.textBox_StaffID.Size = new System.Drawing.Size(185, 20);
            this.textBox_StaffID.TabIndex = 19;
            // 
            // Btn_SearchID
            // 
            this.Btn_SearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SearchID.Location = new System.Drawing.Point(213, 32);
            this.Btn_SearchID.Name = "Btn_SearchID";
            this.Btn_SearchID.Size = new System.Drawing.Size(112, 23);
            this.Btn_SearchID.TabIndex = 18;
            this.Btn_SearchID.Text = "Search";
            this.Btn_SearchID.UseVisualStyleBackColor = true;
            // 
            // listBox_Staff
            // 
            this.listBox_Staff.FormattingEnabled = true;
            this.listBox_Staff.Location = new System.Drawing.Point(5, 77);
            this.listBox_Staff.Name = "listBox_Staff";
            this.listBox_Staff.Size = new System.Drawing.Size(185, 134);
            this.listBox_Staff.TabIndex = 17;
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
            this.ClientSize = new System.Drawing.Size(327, 261);
            this.Controls.Add(this.Btn_UpdateS);
            this.Controls.Add(this.Btn_DeleteS);
            this.Controls.Add(this.Btn_AddS);
            this.Controls.Add(this.Btn_View);
            this.Controls.Add(this.textBox_StaffID);
            this.Controls.Add(this.Btn_SearchID);
            this.Controls.Add(this.listBox_Staff);
            this.Controls.Add(this.label1);
            this.Name = "ViewAddUpdateDeleteStaff";
            this.Text = "ViewAddUpdateDeleteStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_UpdateS;
        private System.Windows.Forms.Button Btn_DeleteS;
        private System.Windows.Forms.Button Btn_AddS;
        private System.Windows.Forms.Button Btn_View;
        private System.Windows.Forms.TextBox textBox_StaffID;
        private System.Windows.Forms.Button Btn_SearchID;
        private System.Windows.Forms.ListBox listBox_Staff;
        private System.Windows.Forms.Label label1;
    }
}