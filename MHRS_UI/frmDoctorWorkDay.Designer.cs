namespace MHRS_UI
{
    partial class frmDoctorWorkDay
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCreateExamination = new System.Windows.Forms.Button();
            this.lstAppointments = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnViewActualExamination = new System.Windows.Forms.Button();
            this.btnViewPreviousExamination = new System.Windows.Forms.Button();
            this.lblLogOut = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Centralized Doctor Appointment System";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(388, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 57);
            this.button1.TabIndex = 14;
            this.button1.Text = "Abort Examination";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreateExamination
            // 
            this.btnCreateExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateExamination.Location = new System.Drawing.Point(522, 366);
            this.btnCreateExamination.Name = "btnCreateExamination";
            this.btnCreateExamination.Size = new System.Drawing.Size(116, 57);
            this.btnCreateExamination.TabIndex = 13;
            this.btnCreateExamination.Text = "Create Examination";
            this.btnCreateExamination.UseVisualStyleBackColor = true;
            this.btnCreateExamination.Click += new System.EventHandler(this.btnCreateExamination_Click);
            // 
            // lstAppointments
            // 
            this.lstAppointments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1});
            this.lstAppointments.FullRowSelect = true;
            this.lstAppointments.GridLines = true;
            this.lstAppointments.Location = new System.Drawing.Point(41, 57);
            this.lstAppointments.MultiSelect = false;
            this.lstAppointments.Name = "lstAppointments";
            this.lstAppointments.Size = new System.Drawing.Size(597, 303);
            this.lstAppointments.TabIndex = 12;
            this.lstAppointments.UseCompatibleStateImageBehavior = false;
            this.lstAppointments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Appointment Time";
            this.columnHeader2.Width = 268;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Appointment Information";
            this.columnHeader1.Width = 300;
            // 
            // btnViewActualExamination
            // 
            this.btnViewActualExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnViewActualExamination.Location = new System.Drawing.Point(119, 366);
            this.btnViewActualExamination.Name = "btnViewActualExamination";
            this.btnViewActualExamination.Size = new System.Drawing.Size(118, 57);
            this.btnViewActualExamination.TabIndex = 17;
            this.btnViewActualExamination.Text = "View Actual Examination(s)";
            this.btnViewActualExamination.UseVisualStyleBackColor = true;
            this.btnViewActualExamination.Click += new System.EventHandler(this.btnViewActualExamination_Click);
            // 
            // btnViewPreviousExamination
            // 
            this.btnViewPreviousExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnViewPreviousExamination.Location = new System.Drawing.Point(253, 366);
            this.btnViewPreviousExamination.Name = "btnViewPreviousExamination";
            this.btnViewPreviousExamination.Size = new System.Drawing.Size(116, 57);
            this.btnViewPreviousExamination.TabIndex = 16;
            this.btnViewPreviousExamination.Text = "View Previous Examination(s)";
            this.btnViewPreviousExamination.UseVisualStyleBackColor = true;
            this.btnViewPreviousExamination.Click += new System.EventHandler(this.btnViewPreviousExamination_Click);
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Location = new System.Drawing.Point(26, 410);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(45, 13);
            this.lblLogOut.TabIndex = 27;
            this.lblLogOut.TabStop = true;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogOut_LinkClicked);
            // 
            // frmDoctorWorkDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.btnViewActualExamination);
            this.Controls.Add(this.btnViewPreviousExamination);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCreateExamination);
            this.Controls.Add(this.lstAppointments);
            this.Name = "frmDoctorWorkDay";
            this.Text = "frmDoctorWorkDay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCreateExamination;
        private System.Windows.Forms.ListView lstAppointments;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnViewActualExamination;
        private System.Windows.Forms.Button btnViewPreviousExamination;
        private System.Windows.Forms.LinkLabel lblLogOut;
    }
}