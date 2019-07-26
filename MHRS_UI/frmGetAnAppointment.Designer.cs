namespace MHRS_UI
{
    partial class frmGetAnAppointment
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
            this.lblLogOut = new System.Windows.Forms.LinkLabel();
            this.lblMyPreviousAppointments = new System.Windows.Forms.LinkLabel();
            this.btnGetThisAppointment = new System.Windows.Forms.Button();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.cmbPoliclinics = new System.Windows.Forms.ComboBox();
            this.cmbHospitals = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn16 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Location = new System.Drawing.Point(58, 439);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(45, 13);
            this.lblLogOut.TabIndex = 25;
            this.lblLogOut.TabStop = true;
            this.lblLogOut.Text = "Log Out";
            // 
            // lblMyPreviousAppointments
            // 
            this.lblMyPreviousAppointments.AutoSize = true;
            this.lblMyPreviousAppointments.Location = new System.Drawing.Point(366, 43);
            this.lblMyPreviousAppointments.Name = "lblMyPreviousAppointments";
            this.lblMyPreviousAppointments.Size = new System.Drawing.Size(138, 13);
            this.lblMyPreviousAppointments.TabIndex = 24;
            this.lblMyPreviousAppointments.TabStop = true;
            this.lblMyPreviousAppointments.Text = "My Previous Appointment(s)";
            this.lblMyPreviousAppointments.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMyPreviousAppointments_LinkClicked);
            // 
            // btnGetThisAppointment
            // 
            this.btnGetThisAppointment.Location = new System.Drawing.Point(364, 428);
            this.btnGetThisAppointment.Name = "btnGetThisAppointment";
            this.btnGetThisAppointment.Size = new System.Drawing.Size(134, 34);
            this.btnGetThisAppointment.TabIndex = 23;
            this.btnGetThisAppointment.Text = "Get This Appointment";
            this.btnGetThisAppointment.UseVisualStyleBackColor = true;
            this.btnGetThisAppointment.Click += new System.EventHandler(this.btnGetThisAppointment_Click);
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Location = new System.Drawing.Point(140, 188);
            this.dtpAppointmentDate.MinDate = new System.DateTime(2019, 5, 6, 0, 0, 0, 0);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(358, 20);
            this.dtpAppointmentDate.TabIndex = 21;
            // 
            // cmbPoliclinics
            // 
            this.cmbPoliclinics.FormattingEnabled = true;
            this.cmbPoliclinics.Location = new System.Drawing.Point(140, 113);
            this.cmbPoliclinics.Name = "cmbPoliclinics";
            this.cmbPoliclinics.Size = new System.Drawing.Size(358, 21);
            this.cmbPoliclinics.TabIndex = 20;
            // 
            // cmbHospitals
            // 
            this.cmbHospitals.FormattingEnabled = true;
            this.cmbHospitals.Location = new System.Drawing.Point(140, 73);
            this.cmbHospitals.Name = "cmbHospitals";
            this.cmbHospitals.Size = new System.Drawing.Size(358, 21);
            this.cmbHospitals.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Policlinic:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hospital:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Centralized Doctor Appointment System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Doctor Name :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(358, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Time :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn16);
            this.panel2.Controls.Add(this.btn12);
            this.panel2.Controls.Add(this.btn15);
            this.panel2.Controls.Add(this.btn11);
            this.panel2.Controls.Add(this.btn13);
            this.panel2.Controls.Add(this.btn14);
            this.panel2.Controls.Add(this.btn10);
            this.panel2.Controls.Add(this.btn9);
            this.panel2.Controls.Add(this.btn8);
            this.panel2.Controls.Add(this.btn7);
            this.panel2.Controls.Add(this.btn6);
            this.panel2.Controls.Add(this.btn5);
            this.panel2.Controls.Add(this.btn4);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Location = new System.Drawing.Point(140, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 140);
            this.panel2.TabIndex = 29;
            // 
            // btn16
            // 
            this.btn16.Location = new System.Drawing.Point(256, 99);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(75, 23);
            this.btn16.TabIndex = 0;
            this.btn16.Text = "16:30";
            this.btn16.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(256, 70);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(75, 23);
            this.btn12.TabIndex = 0;
            this.btn12.Text = "14:30";
            this.btn12.UseVisualStyleBackColor = true;
            // 
            // btn15
            // 
            this.btn15.Location = new System.Drawing.Point(175, 99);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(75, 23);
            this.btn15.TabIndex = 0;
            this.btn15.Text = "16:00";
            this.btn15.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(175, 70);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(75, 23);
            this.btn11.TabIndex = 0;
            this.btn11.Text = "14:00";
            this.btn11.UseVisualStyleBackColor = true;
            // 
            // btn13
            // 
            this.btn13.Location = new System.Drawing.Point(13, 99);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(75, 23);
            this.btn13.TabIndex = 0;
            this.btn13.Text = "15:00";
            this.btn13.UseVisualStyleBackColor = true;
            // 
            // btn14
            // 
            this.btn14.Location = new System.Drawing.Point(94, 99);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(75, 23);
            this.btn14.TabIndex = 0;
            this.btn14.Text = "15:30";
            this.btn14.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(94, 70);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(75, 23);
            this.btn10.TabIndex = 0;
            this.btn10.Text = "13:30";
            this.btn10.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(13, 70);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 23);
            this.btn9.TabIndex = 0;
            this.btn9.Text = "13:00";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(256, 41);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 23);
            this.btn8.TabIndex = 0;
            this.btn8.Text = "12:30";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(175, 41);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 23);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "12:00";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(94, 41);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 23);
            this.btn6.TabIndex = 0;
            this.btn6.Text = "11:30";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(13, 41);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 23);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "11:00";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(256, 12);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "10:30";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(175, 12);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "10:00";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(94, 12);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "09:30";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 12);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "09:00";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(140, 225);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(358, 21);
            this.comboBox2.TabIndex = 30;
            // 
            // frmGetAnAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 488);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.lblMyPreviousAppointments);
            this.Controls.Add(this.btnGetThisAppointment);
            this.Controls.Add(this.dtpAppointmentDate);
            this.Controls.Add(this.cmbPoliclinics);
            this.Controls.Add(this.cmbHospitals);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGetAnAppointment";
            this.Text = "frmGetAnAppointment";
            this.Load += new System.EventHandler(this.frmGetAnAppointment_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblLogOut;
        private System.Windows.Forms.LinkLabel lblMyPreviousAppointments;
        private System.Windows.Forms.Button btnGetThisAppointment;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.ComboBox cmbPoliclinics;
        private System.Windows.Forms.ComboBox cmbHospitals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn16;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}