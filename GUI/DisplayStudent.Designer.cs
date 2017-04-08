namespace finalProject.classes
{
    partial class displayStudentForm
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
            this.viewStudBtn = new System.Windows.Forms.Button();
            this.displayEquipments = new System.Windows.Forms.ListBox();
            this.searchStudBtn = new System.Windows.Forms.Button();
            this.searchEqIDtxtbox = new System.Windows.Forms.TextBox();
            this.displayStudent = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Display All Students";
            // 
            // viewStudBtn
            // 
            this.viewStudBtn.Location = new System.Drawing.Point(514, 68);
            this.viewStudBtn.Name = "viewStudBtn";
            this.viewStudBtn.Size = new System.Drawing.Size(104, 23);
            this.viewStudBtn.TabIndex = 65;
            this.viewStudBtn.Text = "VIEW";
            this.viewStudBtn.UseVisualStyleBackColor = true;
            // 
            // displayEquipments
            // 
            this.displayEquipments.FormattingEnabled = true;
            this.displayEquipments.Location = new System.Drawing.Point(322, 108);
            this.displayEquipments.Name = "displayEquipments";
            this.displayEquipments.Size = new System.Drawing.Size(296, 199);
            this.displayEquipments.TabIndex = 64;
            // 
            // searchStudBtn
            // 
            this.searchStudBtn.Location = new System.Drawing.Point(241, 68);
            this.searchStudBtn.Name = "searchStudBtn";
            this.searchStudBtn.Size = new System.Drawing.Size(75, 23);
            this.searchStudBtn.TabIndex = 63;
            this.searchStudBtn.Text = "SEARCH";
            this.searchStudBtn.UseVisualStyleBackColor = true;
            // 
            // searchEqIDtxtbox
            // 
            this.searchEqIDtxtbox.Location = new System.Drawing.Point(27, 70);
            this.searchEqIDtxtbox.Name = "searchEqIDtxtbox";
            this.searchEqIDtxtbox.Size = new System.Drawing.Size(208, 20);
            this.searchEqIDtxtbox.TabIndex = 62;
            // 
            // displayStudent
            // 
            this.displayStudent.FormattingEnabled = true;
            this.displayStudent.Location = new System.Drawing.Point(27, 108);
            this.displayStudent.Name = "displayStudent";
            this.displayStudent.Size = new System.Drawing.Size(289, 69);
            this.displayStudent.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Search Student By ID";
            // 
            // displayStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewStudBtn);
            this.Controls.Add(this.displayEquipments);
            this.Controls.Add(this.searchStudBtn);
            this.Controls.Add(this.searchEqIDtxtbox);
            this.Controls.Add(this.displayStudent);
            this.Controls.Add(this.label2);
            this.Name = "displayStudentForm";
            this.Text = "Display Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewStudBtn;
        private System.Windows.Forms.ListBox displayEquipments;
        private System.Windows.Forms.Button searchStudBtn;
        private System.Windows.Forms.TextBox searchEqIDtxtbox;
        private System.Windows.Forms.ListBox displayStudent;
        private System.Windows.Forms.Label label2;
    }
}