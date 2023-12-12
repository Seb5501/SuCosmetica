
namespace SuCosmetica.Forms
{
    partial class ContactDetailsForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.equipmentYesRadioButton = new System.Windows.Forms.RadioButton();
            this.rquipmentNoRadioButton = new System.Windows.Forms.RadioButton();
            this.nextTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nextDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FirstTimedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BirthdaydateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cellphoneTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nextbttn = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(12, 438);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 35);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.nextTimePicker);
            this.groupBox3.Controls.Add(this.nextDatePicker);
            this.groupBox3.Controls.Add(this.FirstTimedateTimePicker);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 191);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Turnos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(143, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 28);
            this.panel1.TabIndex = 22;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(8, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(36, 18);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Si";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(63, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(42, 18);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.equipmentYesRadioButton);
            this.panel3.Controls.Add(this.rquipmentNoRadioButton);
            this.panel3.Location = new System.Drawing.Point(144, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(113, 28);
            this.panel3.TabIndex = 21;
            // 
            // equipmentYesRadioButton
            // 
            this.equipmentYesRadioButton.AutoSize = true;
            this.equipmentYesRadioButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentYesRadioButton.Location = new System.Drawing.Point(8, 5);
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
            this.rquipmentNoRadioButton.Location = new System.Drawing.Point(63, 5);
            this.rquipmentNoRadioButton.Name = "rquipmentNoRadioButton";
            this.rquipmentNoRadioButton.Size = new System.Drawing.Size(42, 18);
            this.rquipmentNoRadioButton.TabIndex = 7;
            this.rquipmentNoRadioButton.TabStop = true;
            this.rquipmentNoRadioButton.Text = "No";
            this.rquipmentNoRadioButton.UseVisualStyleBackColor = true;
            this.rquipmentNoRadioButton.CheckedChanged += new System.EventHandler(this.rquipmentNoRadioButton_CheckedChanged);
            // 
            // nextTimePicker
            // 
            this.nextTimePicker.Location = new System.Drawing.Point(187, 148);
            this.nextTimePicker.Name = "nextTimePicker";
            this.nextTimePicker.Size = new System.Drawing.Size(98, 20);
            this.nextTimePicker.TabIndex = 4;
            // 
            // nextDatePicker
            // 
            this.nextDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nextDatePicker.Location = new System.Drawing.Point(27, 148);
            this.nextDatePicker.Name = "nextDatePicker";
            this.nextDatePicker.Size = new System.Drawing.Size(154, 20);
            this.nextDatePicker.TabIndex = 3;
            // 
            // FirstTimedateTimePicker
            // 
            this.FirstTimedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FirstTimedateTimePicker.Location = new System.Drawing.Point(27, 70);
            this.FirstTimedateTimePicker.Name = "FirstTimedateTimePicker";
            this.FirstTimedateTimePicker.Size = new System.Drawing.Size(258, 20);
            this.FirstTimedateTimePicker.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "¿Proximo Turno?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "¿Primer Turno?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BirthdaydateTimePicker1);
            this.groupBox2.Controls.Add(this.lastNameTxtBox);
            this.groupBox2.Controls.Add(this.firstNameTxtBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.locationComboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cellphoneTxtBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 217);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Personales";
            // 
            // BirthdaydateTimePicker1
            // 
            this.BirthdaydateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdaydateTimePicker1.Location = new System.Drawing.Point(143, 101);
            this.BirthdaydateTimePicker1.Name = "BirthdaydateTimePicker1";
            this.BirthdaydateTimePicker1.Size = new System.Drawing.Size(142, 20);
            this.BirthdaydateTimePicker1.TabIndex = 10;
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameTxtBox.Location = new System.Drawing.Point(143, 62);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(142, 20);
            this.lastNameTxtBox.TabIndex = 9;
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTxtBox.Location = new System.Drawing.Point(143, 25);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(142, 20);
            this.firstNameTxtBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre: ";
            // 
            // locationComboBox
            // 
            this.locationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(143, 174);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(142, 21);
            this.locationComboBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "Localidad: ";
            // 
            // cellphoneTxtBox
            // 
            this.cellphoneTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cellphoneTxtBox.Location = new System.Drawing.Point(143, 135);
            this.cellphoneTxtBox.Name = "cellphoneTxtBox";
            this.cellphoneTxtBox.Size = new System.Drawing.Size(142, 20);
            this.cellphoneTxtBox.TabIndex = 3;
            this.cellphoneTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cellphoneTxtBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nacimiento:";
            // 
            // Nextbttn
            // 
            this.Nextbttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Nextbttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nextbttn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nextbttn.Location = new System.Drawing.Point(218, 438);
            this.Nextbttn.Name = "Nextbttn";
            this.Nextbttn.Size = new System.Drawing.Size(115, 35);
            this.Nextbttn.TabIndex = 12;
            this.Nextbttn.Text = "Siguiente";
            this.Nextbttn.UseVisualStyleBackColor = true;
            this.Nextbttn.Click += new System.EventHandler(this.Nextbttn_Click);
            // 
            // ContactDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 485);
            this.ControlBox = false;
            this.Controls.Add(this.Nextbttn);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "ContactDetailsForm";
            this.Text = "Datos Personales";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker nextTimePicker;
        private System.Windows.Forms.DateTimePicker nextDatePicker;
        private System.Windows.Forms.DateTimePicker FirstTimedateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cellphoneTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton equipmentYesRadioButton;
        private System.Windows.Forms.RadioButton rquipmentNoRadioButton;
        private System.Windows.Forms.Button Nextbttn;
        private System.Windows.Forms.DateTimePicker BirthdaydateTimePicker1;
    }
}