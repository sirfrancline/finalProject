namespace finalProject.classes
{
    partial class View_Student
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
            this.textBox_searchID = new System.Windows.Forms.TextBox();
            this.listBox_viewStudent = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_searchID
            // 
            this.textBox_searchID.Location = new System.Drawing.Point(30, 52);
            this.textBox_searchID.Name = "textBox_searchID";
            this.textBox_searchID.Size = new System.Drawing.Size(202, 20);
            this.textBox_searchID.TabIndex = 52;
            // 
            // listBox_viewStudent
            // 
            this.listBox_viewStudent.FormattingEnabled = true;
            this.listBox_viewStudent.Location = new System.Drawing.Point(30, 89);
            this.listBox_viewStudent.Name = "listBox_viewStudent";
            this.listBox_viewStudent.Size = new System.Drawing.Size(202, 134);
            this.listBox_viewStudent.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Search Students By ID";
            // 
            // View_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox_searchID);
            this.Controls.Add(this.listBox_viewStudent);
            this.Controls.Add(this.label2);
            this.Name = "View_Student";
            this.Text = "View_Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_searchID;
        private System.Windows.Forms.ListBox listBox_viewStudent;
        private System.Windows.Forms.Label label2;
    }
}