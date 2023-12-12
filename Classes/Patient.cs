using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuCosmetica.Classes;

namespace SuCosmetica.Forms
{
    public class Patient
    {
        
        ContactDetails contactDetails = new ContactDetails();
        MedicalRecords medicalRecords = new MedicalRecords();
       

        public Patient()
        {
           
        }
        public Patient(ContactDetails contactDetails, MedicalRecords medicalRecords)
        {
            this.contactDetails = contactDetails;
            this.medicalRecords = medicalRecords;
        }

        public ContactDetails ContactDetails
        {
            get { return this.contactDetails; }
            set { this.contactDetails = value; }
        }
        public MedicalRecords MedicalRecords
        {
            get { return this.medicalRecords; }
            set { this.medicalRecords = value; }
        }

    

        public string ToStrings()
        {
            string textOut = $"{contactDetails.Firstname ,-10} {contactDetails.Lastname ,-13} " +
                             $"{medicalRecords.Diagnosis,-25} {contactDetails.NextTurn ,20}";
            return textOut;
        }
    }
}
