namespace MHRS_UI
{
    partial class frmPatientLogin
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
            this.lblNewPatientRegistration = new System.Windows.Forms.LinkLabel();
            this.btnPatientLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatientPassword = new System.Windows.Forms.TextBox();
            this.txtPatientUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNewPatientRegistration
            // 
            this.lblNewPatientRegistration.AutoSize = true;
            this.lblNewPatientRegistration.Location = new System.Drawing.Point(61, 227);
            this.lblNewPatientRegistration.Name = "lblNewPatientRegistration";
            this.lblNewPatientRegistration.Size = new System.Drawing.Size(124, 13);
            this.lblNewPatientRegistration.TabIndex = 20;
            this.lblNewPatientRegistration.TabStop = true;
            this.lblNewPatientRegistration.Text = "New Patient Registration";
            this.lblNewPatientRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNewPatientRegistration_LinkClicked);
            // 
            // btnPatientLogin
            // 
            this.btnPatientLogin.Location = new System.Drawing.Point(170, 180);
            this.btnPatientLogin.Name = "btnPatientLogin";
            this.btnPatientLogin.Size = new System.Drawing.Size(134, 34);
            this.btnPatientLogin.TabIndex = 19;
            this.btnPatientLogin.Text = "Login";
            this.btnPatientLogin.UseVisualStyleBackColor = true;
            this.btnPatientLogin.Click += new System.EventHandler(this.btnPatientLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password:";
            // 
            // txtPatientPassword
            // 
            this.txtPatientPassword.Location = new System.Drawing.Point(132, 132);
            this.txtPatientPassword.Name = "txtPatientPassword";
            this.txtPatientPassword.Size = new System.Drawing.Size(172, 20);
            this.txtPatientPassword.TabIndex = 17;
            // 
            // txtPatientUsername
            // 
            this.txtPatientUsername.Location = new System.Drawing.Point(132, 87);
            this.txtPatientUsername.Name = "txtPatientUsername";
            this.txtPatientUsername.Size = new System.Drawing.Size(172, 20);
            this.txtPatientUsername.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Centralized Doctor Appointment System";
            // 
            // frmPatientLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 310);
            this.Controls.Add(this.lblNewPatientRegistration);
            this.Controls.Add(this.btnPatientLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPatientPassword);
            this.Controls.Add(this.txtPatientUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmPatientLogin";
            this.Text = "frmPatientLogin";
            this.Load += new System.EventHandler(this.frmPatientLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblNewPatientRegistration;
        private System.Windows.Forms.Button btnPatientLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatientPassword;
        private System.Windows.Forms.TextBox txtPatientUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}