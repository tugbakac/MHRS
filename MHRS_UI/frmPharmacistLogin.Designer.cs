namespace MHRS_UI
{
    partial class frmPharmacistLogin
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnPharmasistLogin = new System.Windows.Forms.Button();
            this.txtPharmasistPassword = new System.Windows.Forms.TextBox();
            this.txtPharmasistUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Centralized Pharmacist Appointment System";
            // 
            // btnPharmasistLogin
            // 
            this.btnPharmasistLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPharmasistLogin.Location = new System.Drawing.Point(293, 169);
            this.btnPharmasistLogin.Name = "btnPharmasistLogin";
            this.btnPharmasistLogin.Size = new System.Drawing.Size(97, 37);
            this.btnPharmasistLogin.TabIndex = 15;
            this.btnPharmasistLogin.Text = "Login";
            this.btnPharmasistLogin.UseVisualStyleBackColor = true;
            this.btnPharmasistLogin.Click += new System.EventHandler(this.btnPharmasistLogin_Click);
            // 
            // txtPharmasistPassword
            // 
            this.txtPharmasistPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPharmasistPassword.Location = new System.Drawing.Point(172, 126);
            this.txtPharmasistPassword.Name = "txtPharmasistPassword";
            this.txtPharmasistPassword.Size = new System.Drawing.Size(218, 26);
            this.txtPharmasistPassword.TabIndex = 14;
            // 
            // txtPharmasistUsername
            // 
            this.txtPharmasistUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPharmasistUsername.Location = new System.Drawing.Point(172, 69);
            this.txtPharmasistUsername.Name = "txtPharmasistUsername";
            this.txtPharmasistUsername.Size = new System.Drawing.Size(218, 26);
            this.txtPharmasistUsername.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username:";
            // 
            // frmPharmacistLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 308);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPharmasistLogin);
            this.Controls.Add(this.txtPharmasistPassword);
            this.Controls.Add(this.txtPharmasistUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPharmacistLogin";
            this.Text = "frmPharmacistLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPharmasistLogin;
        private System.Windows.Forms.TextBox txtPharmasistPassword;
        private System.Windows.Forms.TextBox txtPharmasistUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}