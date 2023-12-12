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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        public void GetCurrPatient (Patient patient)
        {
            this.Text = patient.ContactDetails.Firstname + " " + patient.ContactDetails.Lastname;
            Dateofbirthlbl.Text = patient.ContactDetails.Birthday.ToShortDateString();
            Agelbl.Text = GetAge(patient.ContactDetails.Birthday).ToString();
            Cellphonelbl.Text = patient.ContactDetails.Cellphone.ToString();
            Localitylbl.Text = patient.ContactDetails.Location.ToString();
            Firsttimelbl.Text = patient.ContactDetails.FirstTime.ToShortDateString();
            Nextturnlbl.Text = patient.ContactDetails.NextTurn.ToString();


            Diseaseslbl.Text = patient.MedicalRecords.Diseases;
            Productslbl.Text = patient.MedicalRecords.Products;
            Diagnosislbl.Text = patient.MedicalRecords.Diagnosis;
            Treatmentlbl.Text = patient.MedicalRecords.Treatment;
            string equipments = String.Empty;
            string[] the_array = patient.MedicalRecords.Equi.Select(i => i.ToString()).ToArray();
            
            Equipmentlbl.Text = GetEquipmentString(the_array.Length, the_array);



        }

        private void Okbttn_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        public int GetAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }


        public string GetEquipmentString(int index, string[] the_array)
        {
            switch (index)
            {
                case 0:
                    return "None";
                case 1:
                    return the_array[0];
                case 2:
                    return the_array[0] + " | " + the_array[1]  ;
                case 3:
                    return the_array[0] + " | " + the_array[1] + " | " + the_array[2] ;
                case 4:
                    return the_array[0] + " | " + the_array[1] + " | " + the_array[2] + "\n" + the_array[3];
                case 5:
                    return the_array[0] + " | " + the_array[1] + " | " + the_array[2] + "\n" + the_array[3]
                + " | " + the_array[4];
                case 6:
                    return the_array[0] + " | " + the_array[1] + " | " + the_array[2] + "\n" + the_array[3]
                + " | " + the_array[4] + " | " + the_array[5];
                case 7:
                    return the_array[0] + " | " + the_array[1] + " | " + the_array[2] + "\n" + the_array[3]
                + " | " + the_array[4] + " | " + the_array[5] + "\n" + the_array[6];
                case 8:
                    return the_array[0] + " | " + the_array[1] + " | " + the_array[2] + "\n" + the_array[3]
                + " | " + the_array[4] + " | " + the_array[5] + "\n" + the_array[6] + " | " + the_array[7];
                default:
                    return "None";
            }
        }

        private void Diseaseslbl_Click(object sender, EventArgs e)
        {

        }
    }
}
/*   
 *   
   public void UpdateMedicalRecordsGUI(Patient patient)
{
    if (String.IsNullOrEmpty(patient.MedicalRecords.Diseases))
        diseasesLabel.Text = "Pre-exsiting Diseases: No";
    else
        diseasesLabel.Text = "Pre-exsiting Diseases: " + patient.MedicalRecords.Diseases;
    if (String.IsNullOrEmpty(patient.MedicalRecords.Products))
        productsLabel.Text = "Prescribed Products: No";
    else
        productsLabel.Text = "Prescribed Products: " + patient.MedicalRecords.Products;
    if (String.IsNullOrEmpty(patient.MedicalRecords.Equipment))
        equipmentLabel.Text = "Equipment Needed: No";
    else
        equipmentLabel.Text = "Equipment Needed: " + patient.MedicalRecords.Equipment;
    diagnosisLabel.Text = "Diagnosis: " + patient.MedicalRecords.Diagnosis;
    treatmentLabel.Text = "Treatment: " + patient.MedicalRecords.Treatment;
} // Updates Medical Records GUI

public void UpdateContactDetailsGUI(Patient patient)
{
    firstNameLabel.Text = "First Name: " + patient.ContactDetails.Firstname;
    lastNameLabel.Text = "Last Name: " + patient.ContactDetails.Lastname;
    ageLlabel.Text = "Age: " + patient.ContactDetails.Age;
    cellphoneLabel.Text = "Cellphone: " + patient.ContactDetails.Cellphone;
    locationLabel.Text = "Location: " + patient.ContactDetails.Location.ToString().Replace('_', ' ');
    firstTurnLabel.Text = "First Consultation: " + patient.ContactDetails.FirstTime;
    nextTurnLabel1.Text = "Next Consultation: " + patient.ContactDetails.NextTurn;
} // Updates Contact Details GUI 

*/