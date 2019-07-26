namespace MHRS_UI
{
    partial class frmViewPrescription
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
            this.txtViewPrescription = new System.Windows.Forms.TextBox();
            this.btnViewPreviousPrescription = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.btnViewPrescription = new System.Windows.Forms.Button();
            this.lstPreviousPrescription = new System.Windows.Forms.ListBox();
            this.lblLogOut = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtViewPrescription
            // 
            this.txtViewPrescription.Location = new System.Drawing.Point(64, 127);
            this.txtViewPrescription.Multiline = true;
            this.txtViewPrescription.Name = "txtViewPrescription";
            this.txtViewPrescription.Size = new System.Drawing.Size(211, 238);
            this.txtViewPrescription.TabIndex = 17;
            // 
            // btnViewPreviousPrescription
            // 
            this.btnViewPreviousPrescription.Location = new System.Drawing.Point(295, 371);
            this.btnViewPreviousPrescription.Name = "btnViewPreviousPrescription";
            this.btnViewPreviousPrescription.Size = new System.Drawing.Size(207, 40);
            this.btnViewPreviousPrescription.TabIndex = 16;
            this.btnViewPreviousPrescription.Text = "View Previous Prescription(s)";
            this.btnViewPreviousPrescription.UseVisualStyleBackColor = true;
            this.btnViewPreviousPrescription.Click += new System.EventHandler(this.btnViewPreviousPrescription_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Centralized Doctor Appointment System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(110, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Patient ID:";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(194, 83);
            this.txtPatientID.Multiline = true;
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(220, 25);
            this.txtPatientID.TabIndex = 13;
            // 
            // btnViewPrescription
            // 
            this.btnViewPrescription.Location = new System.Drawing.Point(64, 371);
            this.btnViewPrescription.Name = "btnViewPrescription";
            this.btnViewPrescription.Size = new System.Drawing.Size(211, 40);
            this.btnViewPrescription.TabIndex = 12;
            this.btnViewPrescription.Text = "View Prescription";
            this.btnViewPrescription.UseVisualStyleBackColor = true;
            this.btnViewPrescription.Click += new System.EventHandler(this.btnViewPrescription_Click);
            // 
            // lstPreviousPrescription
            // 
            this.lstPreviousPrescription.FormattingEnabled = true;
            this.lstPreviousPrescription.Location = new System.Drawing.Point(295, 127);
            this.lstPreviousPrescription.Name = "lstPreviousPrescription";
            this.lstPreviousPrescription.Size = new System.Drawing.Size(207, 238);
            this.lstPreviousPrescription.TabIndex = 11;
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Location = new System.Drawing.Point(23, 425);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(45, 13);
            this.lblLogOut.TabIndex = 27;
            this.lblLogOut.TabStop = true;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogOut_LinkClicked);
            // 
            // frmViewPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 447);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.txtViewPrescription);
            this.Controls.Add(this.btnViewPreviousPrescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.btnViewPrescription);
            this.Controls.Add(this.lstPreviousPrescription);
            this.Name = "frmViewPrescription";
            this.Text = "frmViewPrescription";
            this.Load += new System.EventHandler(this.frmViewPrescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtViewPrescription;
        private System.Windows.Forms.Button btnViewPreviousPrescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Button btnViewPrescription;
        private System.Windows.Forms.ListBox lstPreviousPrescription;
        private System.Windows.Forms.LinkLabel lblLogOut;
    }
}