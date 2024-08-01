namespace OOPAssignmentUI_1
{
    partial class housekeeper_welcome
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
            this.btn_CleaningSchedule = new System.Windows.Forms.Button();
            this.btn_RequestEquipment = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.btn_EditProfile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Housekeeping Manager";
            // 
            // btn_CleaningSchedule
            // 
            this.btn_CleaningSchedule.Location = new System.Drawing.Point(37, 90);
            this.btn_CleaningSchedule.Name = "btn_CleaningSchedule";
            this.btn_CleaningSchedule.Size = new System.Drawing.Size(212, 65);
            this.btn_CleaningSchedule.TabIndex = 1;
            this.btn_CleaningSchedule.Text = "Cleaning Schedule";
            this.btn_CleaningSchedule.UseVisualStyleBackColor = true;
            this.btn_CleaningSchedule.Click += new System.EventHandler(this.btn_CleaningSchedule_Click);
            // 
            // btn_RequestEquipment
            // 
            this.btn_RequestEquipment.Location = new System.Drawing.Point(37, 173);
            this.btn_RequestEquipment.Name = "btn_RequestEquipment";
            this.btn_RequestEquipment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_RequestEquipment.Size = new System.Drawing.Size(212, 65);
            this.btn_RequestEquipment.TabIndex = 1;
            this.btn_RequestEquipment.Text = "Request Supplies";
            this.btn_RequestEquipment.UseVisualStyleBackColor = true;
            this.btn_RequestEquipment.Click += new System.EventHandler(this.btn_RequestEquipment_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(37, 261);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(212, 65);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_RequestEquipment);
            this.panel1.Controls.Add(this.btn_CleaningSchedule);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(458, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 355);
            this.panel1.TabIndex = 2;
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.Location = new System.Drawing.Point(117, 176);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(213, 29);
            this.lbl_Welcome.TabIndex = 0;
            this.lbl_Welcome.Text = "Welcome, [USER]!";
            // 
            // btn_EditProfile
            // 
            this.btn_EditProfile.Location = new System.Drawing.Point(118, 223);
            this.btn_EditProfile.Name = "btn_EditProfile";
            this.btn_EditProfile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_EditProfile.Size = new System.Drawing.Size(212, 65);
            this.btn_EditProfile.TabIndex = 1;
            this.btn_EditProfile.Text = "Edit Profile";
            this.btn_EditProfile.UseVisualStyleBackColor = true;
            this.btn_EditProfile.Click += new System.EventHandler(this.btn_editProfile_Click);
            // 
            // housekeeper_welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_EditProfile);
            this.Controls.Add(this.lbl_Welcome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "housekeeper_welcome";
            this.Text = "housekeeper_welcome";
            this.Load += new System.EventHandler(this.housekeeper_welcome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CleaningSchedule;
        private System.Windows.Forms.Button btn_RequestEquipment;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Button btn_EditProfile;
    }
}