
namespace JRZUJV_TóthBrigitta
{
    partial class UserControlPrescription
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPatient = new System.Windows.Forms.TextBox();
            this.textBoxMedication = new System.Windows.Forms.TextBox();
            this.listBoxPatient = new System.Windows.Forms.ListBox();
            this.listBoxMedication = new System.Windows.Forms.ListBox();
            this.listBoxPrescription = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPatient
            // 
            this.textBoxPatient.Location = new System.Drawing.Point(28, 46);
            this.textBoxPatient.Name = "textBoxPatient";
            this.textBoxPatient.Size = new System.Drawing.Size(122, 22);
            this.textBoxPatient.TabIndex = 0;
            this.textBoxPatient.TextChanged += new System.EventHandler(this.textBoxPatient_TextChanged);
            // 
            // textBoxMedication
            // 
            this.textBoxMedication.Location = new System.Drawing.Point(452, 46);
            this.textBoxMedication.Name = "textBoxMedication";
            this.textBoxMedication.Size = new System.Drawing.Size(146, 22);
            this.textBoxMedication.TabIndex = 1;
            this.textBoxMedication.TextChanged += new System.EventHandler(this.textBoxMedication_TextChanged);
            // 
            // listBoxPatient
            // 
            this.listBoxPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxPatient.FormattingEnabled = true;
            this.listBoxPatient.ItemHeight = 16;
            this.listBoxPatient.Location = new System.Drawing.Point(28, 87);
            this.listBoxPatient.Name = "listBoxPatient";
            this.listBoxPatient.Size = new System.Drawing.Size(139, 260);
            this.listBoxPatient.TabIndex = 2;
            this.listBoxPatient.SelectedIndexChanged += new System.EventHandler(this.listBoxPatient_SelectedIndexChanged);
            // 
            // listBoxMedication
            // 
            this.listBoxMedication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxMedication.FormattingEnabled = true;
            this.listBoxMedication.ItemHeight = 16;
            this.listBoxMedication.Location = new System.Drawing.Point(452, 87);
            this.listBoxMedication.Name = "listBoxMedication";
            this.listBoxMedication.Size = new System.Drawing.Size(146, 260);
            this.listBoxMedication.TabIndex = 3;
            // 
            // listBoxPrescription
            // 
            this.listBoxPrescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxPrescription.FormattingEnabled = true;
            this.listBoxPrescription.ItemHeight = 16;
            this.listBoxPrescription.Location = new System.Drawing.Point(173, 87);
            this.listBoxPrescription.Name = "listBoxPrescription";
            this.listBoxPrescription.Size = new System.Drawing.Size(139, 260);
            this.listBoxPrescription.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(344, 144);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "button1";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(344, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 40);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "button2";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(156, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(604, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // UserControlPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listBoxPrescription);
            this.Controls.Add(this.listBoxMedication);
            this.Controls.Add(this.listBoxPatient);
            this.Controls.Add(this.textBoxMedication);
            this.Controls.Add(this.textBoxPatient);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "UserControlPrescription";
            this.Size = new System.Drawing.Size(664, 375);
            this.Load += new System.EventHandler(this.UserControlPrescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPatient;
        private System.Windows.Forms.TextBox textBoxMedication;
        private System.Windows.Forms.ListBox listBoxPatient;
        private System.Windows.Forms.ListBox listBoxMedication;
        private System.Windows.Forms.ListBox listBoxPrescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
