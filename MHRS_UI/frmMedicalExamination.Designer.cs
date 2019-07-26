namespace MHRS_UI
{
    partial class frmMedicalExamination
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
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCreatePrescription = new System.Windows.Forms.Button();
            this.cmbDiagnosis = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Centralized Doctor Appointment System";
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Location = new System.Drawing.Point(65, 335);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(110, 46);
            this.btnAnalysis.TabIndex = 15;
            this.btnAnalysis.Text = "Analysis";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 78);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(485, 224);
            this.textBox1.TabIndex = 14;
            // 
            // btnCreatePrescription
            // 
            this.btnCreatePrescription.Location = new System.Drawing.Point(417, 335);
            this.btnCreatePrescription.Name = "btnCreatePrescription";
            this.btnCreatePrescription.Size = new System.Drawing.Size(121, 46);
            this.btnCreatePrescription.TabIndex = 13;
            this.btnCreatePrescription.Text = "Create Prescription";
            this.btnCreatePrescription.UseVisualStyleBackColor = true;
            this.btnCreatePrescription.Click += new System.EventHandler(this.btnCreatePrescription_Click);
            // 
            // cmbDiagnosis
            // 
            this.cmbDiagnosis.FormattingEnabled = true;
            this.cmbDiagnosis.Items.AddRange(new object[] {
            "Alcohol abuse and alcoholism",
            "Allergies",
            "Alopecia areata",
            "Brain injury",
            "Bipolar disorder",
            "Cancer",
            "Charcot-Marie-Tooth disease",
            "Deafness and being hard of hearing",
            "Down syndrome",
            "Epilepsy",
            "Eczema",
            "Heart diseases",
            "HIV/AIDS",
            "Lupus",
            "Migraine",
            "Multiple sclerosis",
            "Obesity",
            "Sickle cell anemia",
            "Thyroid disease",
            "Ulcerative colitis",
            "Williams syndrome"});
            this.cmbDiagnosis.Location = new System.Drawing.Point(417, 308);
            this.cmbDiagnosis.Name = "cmbDiagnosis";
            this.cmbDiagnosis.Size = new System.Drawing.Size(121, 21);
            this.cmbDiagnosis.TabIndex = 17;
            this.cmbDiagnosis.Text = "           Diagnosis";
            this.cmbDiagnosis.UseWaitCursor = true;
            // 
            // frmMedicalExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.cmbDiagnosis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAnalysis);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCreatePrescription);
            this.Name = "frmMedicalExamination";
            this.Text = "frmMedicalExamination";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCreatePrescription;
        private System.Windows.Forms.ComboBox cmbDiagnosis;
    }
}