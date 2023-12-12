
namespace SuCosmetica.Forms
{
    partial class MedicalRecordsForm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productsYesRadioButton = new System.Windows.Forms.RadioButton();
            this.productsNoRadioButton = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.equipmentYesRadioButton = new System.Windows.Forms.RadioButton();
            this.rquipmentNoRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.diseaseYesRadioButton = new System.Windows.Forms.RadioButton();
            this.diseasesNoRadioButton = new System.Windows.Forms.RadioButton();
            this.equipmentcheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.diseasesTxtBox = new System.Windows.Forms.TextBox();
            this.productsTxtBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.diagnosisTxtBox = new System.Windows.Forms.TextBox();
            this.treatmentTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.Nextbttn = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(this.equipmentcheckedListBox);
            this.groupBox4.Controls.Add(this.diseasesTxtBox);
            this.groupBox4.Controls.Add(this.productsTxtBox1);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.diagnosisTxtBox);
            this.groupBox4.Controls.Add(this.treatmentTxtBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(424, 332);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Registros Médicos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.productsYesRadioButton);
            this.panel2.Controls.Add(this.productsNoRadioButton);
            this.panel2.Location = new System.Drawing.Point(160, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 28);
            this.panel2.TabIndex = 20;
            // 
            // productsYesRadioButton
            // 
            this.productsYesRadioButton.AutoSize = true;
            this.productsYesRadioButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsYesRadioButton.Location = new System.Drawing.Point(3, 5);
            this.productsYesRadioButton.Name = "productsYesRadioButton";
            this.productsYesRadioButton.Size = new System.Drawing.Size(36, 18);
            this.productsYesRadioButton.TabIndex = 6;
            this.productsYesRadioButton.TabStop = true;
            this.productsYesRadioButton.Text = "Si";
            this.productsYesRadioButton.UseVisualStyleBackColor = true;
            this.productsYesRadioButton.CheckedChanged += new System.EventHandler(this.productsYesRadioButton_CheckedChanged);
            // 
            // productsNoRadioButton
            // 
            this.productsNoRadioButton.AutoSize = true;
            this.productsNoRadioButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsNoRadioButton.Location = new System.Drawing.Point(55, 5);
            this.productsNoRadioButton.Name = "productsNoRadioButton";
            this.productsNoRadioButton.Size = new System.Drawing.Size(42, 18);
            this.productsNoRadioButton.TabIndex = 7;
            this.productsNoRadioButton.TabStop = true;
            this.productsNoRadioButton.Text = "No";
            this.productsNoRadioButton.UseVisualStyleBackColor = true;
            this.productsNoRadioButton.CheckedChanged += new System.EventHandler(this.productsNoRadioButton_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.equipmentYesRadioButton);
            this.panel3.Controls.Add(this.rquipmentNoRadioButton);
            this.panel3.Location = new System.Drawing.Point(160, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(101, 28);
            this.panel3.TabIndex = 20;
            // 
            // equipmentYesRadioButton
            // 
            this.equipmentYesRadioButton.AutoSize = true;
            this.equipmentYesRadioButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentYesRadioButton.Location = new System.Drawing.Point(3, 5);
            this.equipmentYesRadioButton.Name = "equipmentYesRadioButton";
            this.equipmentYesRadioButton.Size = new System.Drawing.Size(36, 18);
            this.equipmentYesRadioButton.TabIndex = 6;
            this.equipmentYesRadioButton.TabStop = true;
            this.equipmentYesRadioButton.Text = "Si";
            this.equipmentYesRadioButton.UseVisualStyleBackColor = true;
            this.equipmentYesRadioButton.CheckedChanged += new System.EventHandler(this.equipmentYesRadioButton_CheckedChanged);
            // 
            // rquipmentNoRadioButton
            // 
            this.rquipmentNoRadioButton.AutoSize = true;
            this.rquipmentNoRadioButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rquipmentNoRadioButton.Location = new System.Drawing.Point(55, 5);
            this.rquipmentNoRadioButton.Name = "rquipmentNoRadioButton";
            this.rquipmentNoRadioButton.Size = new System.Drawing.Size(42, 18);
            this.rquipmentNoRadioButton.TabIndex = 7;
            this.rquipmentNoRadioButton.TabStop = true;
            this.rquipmentNoRadioButton.Text = "No";
            this.rquipmentNoRadioButton.UseVisualStyleBackColor = true;
            this.rquipmentNoRadioButton.CheckedChanged += new System.EventHandler(this.rquipmentNoRadioButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.diseaseYesRadioButton);
            this.panel1.Controls.Add(this.diseasesNoRadioButton);
            this.panel1.Location = new System.Drawing.Point(160, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 28);
            this.panel1.TabIndex = 19;
            // 
            // diseaseYesRadioButton
            // 
            this.diseaseYesRadioButton.AutoSize = true;
            this.diseaseYesRadioButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diseaseYesRadioButton.Location = new System.Drawing.Point(3, 5);
            this.diseaseYesRadioButton.Name = "diseaseYesRadioButton";
            this.diseaseYesRadioButton.Size = new System.Drawing.Size(36, 18);
            this.diseaseYesRadioButton.TabIndex = 6;
            this.diseaseYesRadioButton.TabStop = true;
            this.diseaseYesRadioButton.Text = "Si";
            this.diseaseYesRadioButton.UseVisualStyleBackColor = true;
            this.diseaseYesRadioButton.CheckedChanged += new System.EventHandler(this.diseaseYesRadioButton_CheckedChanged);
            // 
            // diseasesNoRadioButton
            // 
            this.diseasesNoRadioButton.AutoSize = true;
            this.diseasesNoRadioButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diseasesNoRadioButton.Location = new System.Drawing.Point(55, 5);
            this.diseasesNoRadioButton.Name = "diseasesNoRadioButton";
            this.diseasesNoRadioButton.Size = new System.Drawing.Size(42, 18);
            this.diseasesNoRadioButton.TabIndex = 7;
            this.diseasesNoRadioButton.TabStop = true;
            this.diseasesNoRadioButton.Text = "No";
            this.diseasesNoRadioButton.UseVisualStyleBackColor = true;
            this.diseasesNoRadioButton.CheckedChanged += new System.EventHandler(this.diseasesNoRadioButton_CheckedChanged);
            // 
            // equipmentcheckedListBox
            // 
            this.equipmentcheckedListBox.FormattingEnabled = true;
            this.equipmentcheckedListBox.Location = new System.Drawing.Point(267, 116);
            this.equipmentcheckedListBox.Name = "equipmentcheckedListBox";
            this.equipmentcheckedListBox.Size = new System.Drawing.Size(151, 124);
            this.equipmentcheckedListBox.TabIndex = 18;
            // 
            // diseasesTxtBox
            // 
            this.diseasesTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diseasesTxtBox.Location = new System.Drawing.Point(267, 38);
            this.diseasesTxtBox.Name = "diseasesTxtBox";
            this.diseasesTxtBox.Size = new System.Drawing.Size(151, 20);
            this.diseasesTxtBox.TabIndex = 17;
            // 
            // productsTxtBox1
            // 
            this.productsTxtBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productsTxtBox1.Location = new System.Drawing.Point(267, 73);
            this.productsTxtBox1.Name = "productsTxtBox1";
            this.productsTxtBox1.Size = new System.Drawing.Size(151, 20);
            this.productsTxtBox1.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 14);
            this.label12.TabIndex = 12;
            this.label12.Text = "Aparatologia:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 14);
            this.label11.TabIndex = 8;
            this.label11.Text = "Productos Prescriptos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 14);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tratamiento:";
            // 
            // diagnosisTxtBox
            // 
            this.diagnosisTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diagnosisTxtBox.Location = new System.Drawing.Point(103, 299);
            this.diagnosisTxtBox.Name = "diagnosisTxtBox";
            this.diagnosisTxtBox.Size = new System.Drawing.Size(315, 20);
            this.diagnosisTxtBox.TabIndex = 3;
            // 
            // treatmentTxtBox
            // 
            this.treatmentTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treatmentTxtBox.Location = new System.Drawing.Point(103, 255);
            this.treatmentTxtBox.Name = "treatmentTxtBox";
            this.treatmentTxtBox.Size = new System.Drawing.Size(315, 20);
            this.treatmentTxtBox.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 14);
            this.label9.TabIndex = 1;
            this.label9.Text = "Diagnostico:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "Enfermedades:";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(59, 355);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 35);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Anterior";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // Nextbttn
            // 
            this.Nextbttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Nextbttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nextbttn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nextbttn.Location = new System.Drawing.Point(265, 355);
            this.Nextbttn.Name = "Nextbttn";
            this.Nextbttn.Size = new System.Drawing.Size(115, 35);
            this.Nextbttn.TabIndex = 13;
            this.Nextbttn.Text = "Siguiente";
            this.Nextbttn.UseVisualStyleBackColor = true;
            this.Nextbttn.Click += new System.EventHandler(this.Nextbttn_Click);
            // 
            // MedicalRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 402);
            this.ControlBox = false;
            this.Controls.Add(this.Nextbttn);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox4);
            this.Name = "MedicalRecordsForm";
            this.Text = "Registros Médicos";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton productsYesRadioButton;
        private System.Windows.Forms.RadioButton productsNoRadioButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton equipmentYesRadioButton;
        private System.Windows.Forms.RadioButton rquipmentNoRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton diseaseYesRadioButton;
        private System.Windows.Forms.RadioButton diseasesNoRadioButton;
        private System.Windows.Forms.CheckedListBox equipmentcheckedListBox;
        private System.Windows.Forms.TextBox diseasesTxtBox;
        private System.Windows.Forms.TextBox productsTxtBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox diagnosisTxtBox;
        private System.Windows.Forms.TextBox treatmentTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button Nextbttn;
    }
}