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
            this.btn_UpdateE = new System.Windows.Forms.Button();
            this.btn_DeleteE = new System.Windows.Forms.Button();
            this.btn_AddE = new System.Windows.Forms.Button();
            this.btn_ViewE = new System.Windows.Forms.Button();
            this.textBox_EID = new System.Windows.Forms.TextBox();
            this.btn_searchEID = new System.Windows.Forms.Button();
            this.listBox_Equipment = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_UpdateE
            // 
            this.btn_UpdateE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateE.Location = new System.Drawing.Point(220, 188);
            this.btn_UpdateE.Name = "btn_UpdateE";
            this.btn_UpdateE.Size = new System.Drawing.Size(112, 23);
            this.btn_UpdateE.TabIndex = 31;
            this.btn_UpdateE.Text = "Update";
            this.btn_UpdateE.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteE
            // 
            this.btn_DeleteE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteE.Location = new System.Drawing.Point(220, 159);
            this.btn_DeleteE.Name = "btn_DeleteE";
            this.btn_DeleteE.Size = new System.Drawing.Size(112, 23);
            this.btn_DeleteE.TabIndex = 30;
            this.btn_DeleteE.Text = "Delete";
            this.btn_DeleteE.UseVisualStyleBackColor = true;
            // 
            // btn_AddE
            // 
            this.btn_AddE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddE.Location = new System.Drawing.Point(220, 130);
            this.btn_AddE.Name = "btn_AddE";
            this.btn_AddE.Size = new System.Drawing.Size(112, 23);
            this.btn_AddE.TabIndex = 29;
            this.btn_AddE.Text = "Add";
            this.btn_AddE.UseVisualStyleBackColor = true;
            // 
            // btn_ViewE
            // 
            this.btn_ViewE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewE.Location = new System.Drawing.Point(220, 87);
            this.btn_ViewE.Name = "btn_ViewE";
            this.btn_ViewE.Size = new System.Drawing.Size(112, 23);
            this.btn_ViewE.TabIndex = 28;
            this.btn_ViewE.Text = "View";
            this.btn_ViewE.UseVisualStyleBackColor = true;
            // 
            // textBox_EID
            // 
            this.textBox_EID.Location = new System.Drawing.Point(12, 47);
            this.textBox_EID.Name = "textBox_EID";
            this.textBox_EID.Size = new System.Drawing.Size(202, 20);
            this.textBox_EID.TabIndex = 27;
            // 
            // btn_searchEID
            // 
            this.btn_searchEID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchEID.Location = new System.Drawing.Point(220, 47);
            this.btn_searchEID.Name = "btn_searchEID";
            this.btn_searchEID.Size = new System.Drawing.Size(112, 23);
            this.btn_searchEID.TabIndex = 26;
            this.btn_searchEID.Text = "Search";
            this.btn_searchEID.UseVisualStyleBackColor = true;
            // 
            // listBox_Equipment
            // 
            this.listBox_Equipment.FormattingEnabled = true;
            this.listBox_Equipment.Location = new System.Drawing.Point(12, 75);
            this.listBox_Equipment.Name = "listBox_Equipment";
            this.listBox_Equipment.Size = new System.Drawing.Size(202, 134);
            this.listBox_Equipment.TabIndex = 25;
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
            this.ClientSize = new System.Drawing.Size(340, 261);
            this.Controls.Add(this.btn_UpdateE);
            this.Controls.Add(this.btn_DeleteE);
            this.Controls.Add(this.btn_AddE);
            this.Controls.Add(this.btn_ViewE);
            this.Controls.Add(this.textBox_EID);
            this.Controls.Add(this.btn_searchEID);
            this.Controls.Add(this.listBox_Equipment);
            this.Controls.Add(this.label1);
            this.Name = "ViewAddUpdateDeleteEquipment";
            this.Text = "ViewAddUpdateDeleteEquipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_UpdateE;
        private System.Windows.Forms.Button btn_DeleteE;
        private System.Windows.Forms.Button btn_AddE;
        private System.Windows.Forms.Button btn_ViewE;
        private System.Windows.Forms.TextBox textBox_EID;
        private System.Windows.Forms.Button btn_searchEID;
        private System.Windows.Forms.ListBox listBox_Equipment;
        private System.Windows.Forms.Label label1;
    }
}