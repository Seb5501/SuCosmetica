using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuCosmetica.Classes;

namespace SuCosmetica.Forms
{
    public class MedicalRecords
    {
        string diagnosis;
        string treatment;
        string diseases;
        string products;
        string equipment;
        List<string> equi = new List<string>();
       
        public MedicalRecords()
        {
            diagnosis = String.Empty;
            treatment = String.Empty;
            diseases = "No";
            products = "No";
            equipment = "No";      
            equi.Clear();
        }

        

        public MedicalRecords(string diagnosis, string treatment, string diseases, string products, string equipment, List<string> equi)
        {
            this.diagnosis = diagnosis;
            this.treatment = treatment;
            this.diseases = diseases;
            this.products = products;
            this.equipment = equipment;
            this.equi = equi;
        }
        public List<string> Equi
        {
            get { return equi; }
            set { equi = value; }
        }
        public string Equipment
        {
            get { return equipment; }
            set { equipment = value; }
        }
        public string Diagnosis
        {
            get { return diagnosis; }
            set { diagnosis = value; }
        }

        public string Treatment
        {
            get { return treatment; }
            set { treatment = value; }
        }

        public string Diseases
        {
            get { return diseases; }
            set { diseases = value; }
        }

        public string Products
        {
            get { return products; }
            set { products = value; }
        }

      
    }
}
