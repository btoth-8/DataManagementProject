
namespace JRZUJV_TóthBrigitta
{
    partial class Form1
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
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnPrescription = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIdőpont = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPatient
            // 
            this.btnPatient.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.Location = new System.Drawing.Point(9, 65);
            this.btnPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(75, 36);
            this.btnPatient.TabIndex = 0;
            this.btnPatient.Text = "Patient";
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnPrescription
            // 
            this.btnPrescription.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrescription.Location = new System.Drawing.Point(9, 106);
            this.btnPrescription.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.Size = new System.Drawing.Size(75, 36);
            this.btnPrescription.TabIndex = 1;
            this.btnPrescription.Text = "Prescription";
            this.btnPrescription.UseVisualStyleBackColor = true;
            this.btnPrescription.Click += new System.EventHandler(this.btnPrescription_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointment.Location = new System.Drawing.Point(9, 146);
            this.btnAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(75, 36);
            this.btnAppointment.TabIndex = 2;
            this.btnAppointment.Text = "Procedures";
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(88, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 346);
            this.panel1.TabIndex = 3;
            // 
            // btnIdőpont
            // 
            this.btnIdőpont.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdőpont.Location = new System.Drawing.Point(9, 187);
            this.btnIdőpont.Margin = new System.Windows.Forms.Padding(2);
            this.btnIdőpont.Name = "btnIdőpont";
            this.btnIdőpont.Size = new System.Drawing.Size(75, 36);
            this.btnIdőpont.TabIndex = 4;
            this.btnIdőpont.Text = "Doctor";
            this.btnIdőpont.UseVisualStyleBackColor = true;
            this.btnIdőpont.Click += new System.EventHandler(this.btnIdőpont_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(9, 24);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 36);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Kezdőoldal";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(9, 228);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 36);
            this.btnEnd.TabIndex = 6;
            this.btnEnd.Text = "Kilépés";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnIdőpont);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAppointment);
            this.Controls.Add(this.btnPrescription);
            this.Controls.Add(this.btnPatient);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnPrescription;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIdőpont;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnEnd;
    }
}

