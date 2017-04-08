namespace finalProject.GUI
{
    partial class View_Equipment
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
            this.searchEqIDtxtbox = new System.Windows.Forms.TextBox();
            this.displayEqlbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchEqBtn = new System.Windows.Forms.Button();
            this.viewEqBtn = new System.Windows.Forms.Button();
            this.displayAllEqlbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchEqIDtxtbox
            // 
            this.searchEqIDtxtbox.Location = new System.Drawing.Point(12, 76);
            this.searchEqIDtxtbox.Name = "searchEqIDtxtbox";
            this.searchEqIDtxtbox.Size = new System.Drawing.Size(208, 20);
            this.searchEqIDtxtbox.TabIndex = 55;
            // 
            // displayEqlbox
            // 
            this.displayEqlbox.FormattingEnabled = true;
            this.displayEqlbox.Location = new System.Drawing.Point(12, 114);
            this.displayEqlbox.Name = "displayEqlbox";
            this.displayEqlbox.Size = new System.Drawing.Size(289, 69);
            this.displayEqlbox.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Search Equipment By ID";
            // 
            // searchEqBtn
            // 
            this.searchEqBtn.Location = new System.Drawing.Point(226, 74);
            this.searchEqBtn.Name = "searchEqBtn";
            this.searchEqBtn.Size = new System.Drawing.Size(75, 23);
            this.searchEqBtn.TabIndex = 56;
            this.searchEqBtn.Text = "SEARCH";
            this.searchEqBtn.UseVisualStyleBackColor = true;
            this.searchEqBtn.Click += new System.EventHandler(this.searchEqBtn_Click);
            // 
            // viewEqBtn
            // 
            this.viewEqBtn.Location = new System.Drawing.Point(499, 74);
            this.viewEqBtn.Name = "viewEqBtn";
            this.viewEqBtn.Size = new System.Drawing.Size(104, 23);
            this.viewEqBtn.TabIndex = 58;
            this.viewEqBtn.Text = "VIEW";
            this.viewEqBtn.UseVisualStyleBackColor = true;
            this.viewEqBtn.Click += new System.EventHandler(this.viewEqBtn_Click);
            // 
            // displayAllEqlbox
            // 
            this.displayAllEqlbox.FormattingEnabled = true;
            this.displayAllEqlbox.Location = new System.Drawing.Point(307, 114);
            this.displayAllEqlbox.Name = "displayAllEqlbox";
            this.displayAllEqlbox.Size = new System.Drawing.Size(296, 199);
            this.displayAllEqlbox.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Dispay All Equipment";
            // 
            // View_Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewEqBtn);
            this.Controls.Add(this.displayAllEqlbox);
            this.Controls.Add(this.searchEqBtn);
            this.Controls.Add(this.searchEqIDtxtbox);
            this.Controls.Add(this.displayEqlbox);
            this.Controls.Add(this.label2);
            this.Name = "View_Equipment";
            this.Text = "Display Equipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchEqIDtxtbox;
        private System.Windows.Forms.ListBox displayEqlbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchEqBtn;
        private System.Windows.Forms.Button viewEqBtn;
        private System.Windows.Forms.ListBox displayAllEqlbox;
        private System.Windows.Forms.Label label1;
    }
}