namespace finalProject.GUI
{
    partial class ViewAddUpdateDeleteEquipment
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
            this.updateEqBtn = new System.Windows.Forms.Button();
            this.deleteEqBtn = new System.Windows.Forms.Button();
            this.addEqBtn = new System.Windows.Forms.Button();
            this.viewEqBtn = new System.Windows.Forms.Button();
            this.searchEqIDtxtbox = new System.Windows.Forms.TextBox();
            this.searchEqBtn = new System.Windows.Forms.Button();
            this.displayEquipment = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateEqBtn
            // 
            this.updateEqBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEqBtn.Location = new System.Drawing.Point(317, 199);
            this.updateEqBtn.Name = "updateEqBtn";
            this.updateEqBtn.Size = new System.Drawing.Size(88, 23);
            this.updateEqBtn.TabIndex = 31;
            this.updateEqBtn.Text = "Update";
            this.updateEqBtn.UseVisualStyleBackColor = true;
            // 
            // deleteEqBtn
            // 
            this.deleteEqBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEqBtn.Location = new System.Drawing.Point(317, 155);
            this.deleteEqBtn.Name = "deleteEqBtn";
            this.deleteEqBtn.Size = new System.Drawing.Size(88, 23);
            this.deleteEqBtn.TabIndex = 30;
            this.deleteEqBtn.Text = "Delete";
            this.deleteEqBtn.UseVisualStyleBackColor = true;
            // 
            // addEqBtn
            // 
            this.addEqBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEqBtn.Location = new System.Drawing.Point(317, 113);
            this.addEqBtn.Name = "addEqBtn";
            this.addEqBtn.Size = new System.Drawing.Size(88, 23);
            this.addEqBtn.TabIndex = 29;
            this.addEqBtn.Text = "Add";
            this.addEqBtn.UseVisualStyleBackColor = true;
            // 
            // viewEqBtn
            // 
            this.viewEqBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewEqBtn.Location = new System.Drawing.Point(317, 75);
            this.viewEqBtn.Name = "viewEqBtn";
            this.viewEqBtn.Size = new System.Drawing.Size(88, 23);
            this.viewEqBtn.TabIndex = 28;
            this.viewEqBtn.Text = "View";
            this.viewEqBtn.UseVisualStyleBackColor = true;
            // 
            // searchEqIDtxtbox
            // 
            this.searchEqIDtxtbox.Location = new System.Drawing.Point(12, 32);
            this.searchEqIDtxtbox.Name = "searchEqIDtxtbox";
            this.searchEqIDtxtbox.Size = new System.Drawing.Size(194, 20);
            this.searchEqIDtxtbox.TabIndex = 27;
            // 
            // searchEqBtn
            // 
            this.searchEqBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEqBtn.Location = new System.Drawing.Point(220, 32);
            this.searchEqBtn.Name = "searchEqBtn";
            this.searchEqBtn.Size = new System.Drawing.Size(67, 23);
            this.searchEqBtn.TabIndex = 26;
            this.searchEqBtn.Text = "Search";
            this.searchEqBtn.UseVisualStyleBackColor = true;
            // 
            // displayEquipment
            // 
            this.displayEquipment.FormattingEnabled = true;
            this.displayEquipment.Location = new System.Drawing.Point(12, 75);
            this.displayEquipment.Name = "displayEquipment";
            this.displayEquipment.Size = new System.Drawing.Size(275, 147);
            this.displayEquipment.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Search Equipment By ID";
            // 
            // ViewAddUpdateDeleteEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 261);
            this.Controls.Add(this.updateEqBtn);
            this.Controls.Add(this.deleteEqBtn);
            this.Controls.Add(this.addEqBtn);
            this.Controls.Add(this.viewEqBtn);
            this.Controls.Add(this.searchEqIDtxtbox);
            this.Controls.Add(this.searchEqBtn);
            this.Controls.Add(this.displayEquipment);
            this.Controls.Add(this.label1);
            this.Name = "ViewAddUpdateDeleteEquipment";
            this.Text = "View Add Update Delete Equipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateEqBtn;
        private System.Windows.Forms.Button deleteEqBtn;
        private System.Windows.Forms.Button addEqBtn;
        private System.Windows.Forms.Button viewEqBtn;
        private System.Windows.Forms.TextBox searchEqIDtxtbox;
        private System.Windows.Forms.Button searchEqBtn;
        private System.Windows.Forms.ListBox displayEquipment;
        private System.Windows.Forms.Label label1;
    }
}