namespace finalProject.classes
{
    partial class checkEqAvailability
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
            this.checkBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statuslbox = new System.Windows.Forms.ListBox();
            this.eqIDtxtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(165, 40);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(94, 23);
            this.checkBtn.TabIndex = 11;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.btn_viewStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search Equipment By ID";
            // 
            // statuslbox
            // 
            this.statuslbox.FormattingEnabled = true;
            this.statuslbox.Location = new System.Drawing.Point(12, 66);
            this.statuslbox.Name = "statuslbox";
            this.statuslbox.Size = new System.Drawing.Size(247, 43);
            this.statuslbox.TabIndex = 15;
            // 
            // eqIDtxtbox
            // 
            this.eqIDtxtbox.Location = new System.Drawing.Point(12, 40);
            this.eqIDtxtbox.Name = "eqIDtxtbox";
            this.eqIDtxtbox.Size = new System.Drawing.Size(147, 20);
            this.eqIDtxtbox.TabIndex = 13;
            // 
            // checkEqAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 127);
            this.Controls.Add(this.statuslbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eqIDtxtbox);
            this.Controls.Add(this.checkBtn);
            this.Name = "checkEqAvailability";
            this.Text = "Check Equipment Availability";
            this.Load += new System.EventHandler(this.equipment_Status_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox statuslbox;
        private System.Windows.Forms.TextBox eqIDtxtbox;
    }
}