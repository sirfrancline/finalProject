namespace finalProject.Operations
{
    partial class MainForm
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
            this.btn_Adminstrator = new System.Windows.Forms.Button();
            this.btn_Equipment = new System.Windows.Forms.Button();
            this.btn_Student = new System.Windows.Forms.Button();
            this.btn_Booking = new System.Windows.Forms.Button();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Adminstrator
            // 
            this.btn_Adminstrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adminstrator.Location = new System.Drawing.Point(93, 5);
            this.btn_Adminstrator.Name = "btn_Adminstrator";
            this.btn_Adminstrator.Size = new System.Drawing.Size(155, 58);
            this.btn_Adminstrator.TabIndex = 14;
            this.btn_Adminstrator.Text = "ADMINSTRATOR";
            this.btn_Adminstrator.UseVisualStyleBackColor = true;
            // 
            // btn_Equipment
            // 
            this.btn_Equipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Equipment.Location = new System.Drawing.Point(210, 160);
            this.btn_Equipment.Name = "btn_Equipment";
            this.btn_Equipment.Size = new System.Drawing.Size(155, 58);
            this.btn_Equipment.TabIndex = 13;
            this.btn_Equipment.Text = "EQUIPMENT";
            this.btn_Equipment.UseVisualStyleBackColor = true;
            // 
            // btn_Student
            // 
            this.btn_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student.Location = new System.Drawing.Point(192, 69);
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.Size = new System.Drawing.Size(155, 58);
            this.btn_Student.TabIndex = 12;
            this.btn_Student.Text = "STUDENT";
            this.btn_Student.UseVisualStyleBackColor = true;
            // 
            // btn_Booking
            // 
            this.btn_Booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Booking.Location = new System.Drawing.Point(12, 160);
            this.btn_Booking.Name = "btn_Booking";
            this.btn_Booking.Size = new System.Drawing.Size(155, 58);
            this.btn_Booking.TabIndex = 11;
            this.btn_Booking.Text = "BOOKING";
            this.btn_Booking.UseVisualStyleBackColor = true;
            // 
            // btn_Staff
            // 
            this.btn_Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff.Location = new System.Drawing.Point(12, 69);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(155, 58);
            this.btn_Staff.TabIndex = 10;
            this.btn_Staff.Text = "STAFF";
            this.btn_Staff.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 261);
            this.Controls.Add(this.btn_Adminstrator);
            this.Controls.Add(this.btn_Equipment);
            this.Controls.Add(this.btn_Student);
            this.Controls.Add(this.btn_Booking);
            this.Controls.Add(this.btn_Staff);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Adminstrator;
        private System.Windows.Forms.Button btn_Equipment;
        private System.Windows.Forms.Button btn_Student;
        private System.Windows.Forms.Button btn_Booking;
        private System.Windows.Forms.Button btn_Staff;
    }
}