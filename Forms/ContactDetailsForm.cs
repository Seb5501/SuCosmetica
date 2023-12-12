using SuCosmetica.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SuCosmetica.Forms
{
    public partial class ContactDetailsForm : Form
    {
        Patient currPatient;
        MedicalRecordsForm medicalRecordsForm = new MedicalRecordsForm();
        bool edit = false;
        Patient editedpatient;

        public ContactDetailsForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        #region METHODS

        public void InitializeGUI()
        {
            locationComboBox.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(Locality))) // sets combo box with the items in the Enum
            {
                string locations = item.ToString().Replace('_', ' '); // replace "_" with spaces
                locationComboBox.Items.Add(locations); // for every item in the enum "PriorityType" add it to the combo box
            }
            rquipmentNoRadioButton.Checked = true;
            firstNameTxtBox.Text = String.Empty;
            lastNameTxtBox.Text = String.Empty;
            BirthdaydateTimePicker1.Value = DateTime.Now;
            cellphoneTxtBox.Text = "0";
            locationComboBox.SelectedItem = Locality.Ezeiza;
            FirstTimedateTimePicker.Value = DateTime.Now;
            nextDatePicker.Value = DateTime.Now;
            nextTimePicker.Format = DateTimePickerFormat.Time;
            nextTimePicker.ShowUpDown = true;
            radioButton2.Checked = true;
        } //initializes all the GUI Components of the add client form

        public void UpdateGUI()
        {
            DateTime nextTurn = nextDatePicker.Value.Date + nextTimePicker.Value.TimeOfDay;
            ContactDetails contactDetails = new ContactDetails(BirthdaydateTimePicker1.Value, firstNameTxtBox.Text, lastNameTxtBox.Text, TryToParse(cellphoneTxtBox.Text), GetPriority(locationComboBox.SelectedIndex), FirstTimedateTimePicker.Value, nextTurn);
            Patient patient = new Patient(contactDetails, medicalRecordsForm.CurrMedicalRecords);
            if (edit)
            {
                editedpatient = patient;   
            }
            else
            {
                currPatient = patient;
            }

        } // Updates GUI
        public Locality GetPriority(int index)
        {
            switch (index)
            {
                case 0:
                    return Locality.Spegazzini;
                case 1:
                    return Locality.Tristian_Suarez;
                case 2:
                    return Locality.Ezeiza;
                case 3:
                    return Locality.El_Jaguel;
                case 4:
                    return Locality.Monte_Grande;
                case 5:
                    return Locality.Luis_Guillon;
                case 6:
                    return Locality.Llavallol;
                case 7:
                    return Locality.Turdera;
                case 8:
                    return Locality.Temperley;
                case 9:
                    return Locality.Lomas_de_Zamora;
                case 10:
                    return Locality.Banfield;
                case 11:
                    return Locality.Adrogue;
                default:
                    return Locality.Ezeiza;
            }
        } //Gets the type of priority

        public long TryToParse(string value)
        {
            bool success = Int64.TryParse(value, out long number);
            if (success)
            {
                return number;
            }
            else
            {
                MessageBox.Show("Wrong Format");
                return 0;
            }
        } // changes string to long

        public void GetEditPatient(Patient patient)
        {
            firstNameTxtBox.Text = patient.ContactDetails.Firstname;
            lastNameTxtBox.Text = patient.ContactDetails.Lastname;
            BirthdaydateTimePicker1.Value = patient.ContactDetails.Birthday;
            cellphoneTxtBox.Text = patient.ContactDetails.Cellphone.ToString();
            locationComboBox.SelectedIndex = (int)patient.ContactDetails.Location;
            FirstTimedateTimePicker.Value = patient.ContactDetails.FirstTime;
            nextDatePicker.Value = patient.ContactDetails.NextTurn.Date;
            nextTimePicker.Value = patient.ContactDetails.NextTurn;
        } //updates gui with the selected patient

        #endregion

        #region BUTTONS

        

        private void equipmentYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FirstTimedateTimePicker.Enabled = true;
        }

        private void rquipmentNoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FirstTimedateTimePicker.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nextDatePicker.Enabled = true;
            nextTimePicker.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nextDatePicker.Enabled = false;
            nextTimePicker.Enabled = false;
        }

        private void Nextbttn_Click(object sender, EventArgs e)
        {
           
            if (edit)
            {             
                medicalRecordsForm.GetEditPatient(editedpatient);
                currPatient = editedpatient;
                medicalRecordsForm.ShowDialog();
                if (!medicalRecordsForm.Back)
                {
                    UpdateGUI();
                    medicalRecordsForm.InitializeGUI();
                    this.Close();
                }
                UpdateGUI();
            }
            else
            {
                medicalRecordsForm.InitializeGUI();
                medicalRecordsForm.ShowDialog(); // Opens the client form 
                if (!medicalRecordsForm.Back)
                {
                    UpdateGUI();
                    medicalRecordsForm.InitializeGUI();
                    this.Close();
                }
                UpdateGUI();

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            currPatient = null;
            this.Hide();
        }

        #endregion

        public Patient CurrPatient
        {

            get { return this.currPatient; }
            set { this.currPatient = value; }
        }

        public bool Edit
        {

            get { return this.edit; }
            set { this.edit = value; }
        }
        public Patient EditedPatient
        {

            get { return this.editedpatient; }
            set { this.editedpatient = value; }
        }

        private void cellphoneTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
