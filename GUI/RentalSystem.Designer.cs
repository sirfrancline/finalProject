namespace finalProject.Operations
{
    partial class theRentalSystem
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
            this.equipmentBtn = new System.Windows.Forms.Button();
            this.studentBtn = new System.Windows.Forms.Button();
            this.bookingBtn = new System.Windows.Forms.Button();
            this.staffBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // equipmentBtn
            // 
            this.equipmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentBtn.Location = new System.Drawing.Point(210, 160);
            this.equipmentBtn.Name = "equipmentBtn";
            this.equipmentBtn.Size = new System.Drawing.Size(155, 58);
            this.equipmentBtn.TabIndex = 13;
            this.equipmentBtn.Text = "EQUIPMENT";
            this.equipmentBtn.UseVisualStyleBackColor = true;
            // 
            // studentBtn
            // 
            this.studentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentBtn.Location = new System.Drawing.Point(192, 69);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(155, 58);
            this.studentBtn.TabIndex = 12;
            this.studentBtn.Text = "STUDENT";
            this.studentBtn.UseVisualStyleBackColor = true;
            // 
            // bookingBtn
            // 
            this.bookingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingBtn.Location = new System.Drawing.Point(12, 160);
            this.bookingBtn.Name = "bookingBtn";
            this.bookingBtn.Size = new System.Drawing.Size(155, 58);
            this.bookingBtn.TabIndex = 11;
            this.bookingBtn.Text = "BOOKING";
            this.bookingBtn.UseVisualStyleBackColor = true;
            // 
            // staffBtn
            // 
            this.staffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBtn.Location = new System.Drawing.Point(12, 69);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(155, 58);
            this.staffBtn.TabIndex = 10;
            this.staffBtn.Text = "STAFF";
            this.staffBtn.UseVisualStyleBackColor = true;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // theRentalSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 261);
            this.Controls.Add(this.equipmentBtn);
            this.Controls.Add(this.studentBtn);
            this.Controls.Add(this.bookingBtn);
            this.Controls.Add(this.staffBtn);
            this.Name = "theRentalSystem";
            this.Text = "The Rental System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.theRentalSystem_FormClosed);
            this.Load += new System.EventHandler(this.theRentalSystem_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button equipmentBtn;
        private System.Windows.Forms.Button studentBtn;
        private System.Windows.Forms.Button bookingBtn;
        private System.Windows.Forms.Button staffBtn;
    }
}