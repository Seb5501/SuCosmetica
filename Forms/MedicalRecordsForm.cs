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
    public partial class MedicalRecordsForm : Form
    {
        
        MedicalRecords currMedicalRecords;
        bool back = false;

        public MedicalRecordsForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        #region METHODS

        public void InitializeGUI()
        {
            diseasesNoRadioButton.Checked = true;
            diseasesTxtBox.Enabled = false;
            productsNoRadioButton.Checked = true;
            productsTxtBox1.Enabled = false;
            equipmentcheckedListBox.Items.Clear();
            for (int i = 0; i < equipmentcheckedListBox.Items.Count; i++)
            {
                equipmentcheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }
            foreach (var item in Enum.GetValues(typeof(Equipment))) // sets combo box with the items in the Enum
            {
                string equipments = item.ToString().Replace('_', ' '); // replace "_" with spaces
                equipmentcheckedListBox.Items.Add(equipments); // for every item in the enum "PriorityType" add it to the combo box
            }
        
            rquipmentNoRadioButton.Checked = true;
            equipmentcheckedListBox.Enabled = false;
            diseasesTxtBox.Text = String.Empty;
            treatmentTxtBox.Text = String.Empty;
            diagnosisTxtBox.Text = String.Empty;
            productsTxtBox1.Text = String.Empty;
        } //initializes all the GUI Components of the add client form

        public void UpdateGUI()
        {


            MedicalRecords medicalRecords = new MedicalRecords(diagnosisTxtBox.Text, treatmentTxtBox.Text, diseasesTxtBox.Text, productsTxtBox1.Text, GetEquipmentToString(), getEqui());

            currMedicalRecords = medicalRecords;



        } // Updates GUI

        public List<string> getEqui()
        {
            List<string> equi = new List<string>();
            foreach (var lang in equipmentcheckedListBox.CheckedItems)
            {
                equi.Add(lang.ToString());
            }
            return equi;
        }
        public string GetEquipmentToString()
        {
            string checkeditem = "";
            int j = 0;
            for (int i = 0; i < equipmentcheckedListBox.Items.Count; i++)
            {
                j++;
                if (equipmentcheckedListBox.GetItemChecked(i))
                {

                    if (j % 3 == 0)
                        checkeditem += GetEquipment(i) + "\n";
                    else
                        checkeditem += GetEquipment(i) + " | ";

                }
            }
            return checkeditem;
        } //Changes the equipments to string

        public string GetEquipment(int index)
        {
            switch (index)
            {
                case 0:
                    return Equipment.Espatula_Ultrasonica.ToString().Replace('_', ' ');
                case 1:
                    return Equipment.Punta_de_Diamante.ToString().Replace('_', ' ');
                case 2:
                    return Equipment.Radiofrequencia.ToString().Replace('_', ' ');
                case 3:
                    return Equipment.Electroporacion.ToString().Replace('_', ' ');
                case 4:
                    return Equipment.Alta_Frequencia.ToString().Replace('_', ' ');
                case 5:
                    return Equipment.Dermaplaning.ToString().Replace('_', ' ');
                case 6:
                    return Equipment.Dermapen.ToString().Replace('_', ' ');
                case 7:
                    return Equipment.Nanoder.ToString().Replace('_', ' ');
                default:
                    return Equipment.Espatula_Ultrasonica.ToString().Replace('_', ' ');
            }
        } //Gets the type of equipment
   

        public void GetEditPatient(Patient patient)
        {
            
            diagnosisTxtBox.Text = patient.MedicalRecords.Diagnosis;
            diseasesTxtBox.Text = patient.MedicalRecords.Diseases;
            treatmentTxtBox.Text = patient.MedicalRecords.Treatment;
            productsTxtBox1.Text = patient.MedicalRecords.Products;

            int index = 0;
            foreach (var equipm in patient.MedicalRecords.Equi)
            {
                index = equipmentcheckedListBox.Items.Cast<string>().ToList().IndexOf(equipm);
                if (index > -1)
                {
                    equipmentYesRadioButton.Checked = true;
                    equipmentcheckedListBox.SetItemCheckState(index, CheckState.Checked);
                }
            }

        } //updates gui with the selected patient

        #endregion

      
        #region BUTTONS


        #endregion


      
        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            back = true;
            UpdateGUI();
            this.Hide();
        }

        private void Nextbttn_Click(object sender, EventArgs e)
        {
            back = false;
            UpdateGUI();
            InitializeGUI();
            this.Hide();
        }

      

        private void diseaseYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            diseasesTxtBox.Enabled = true;
        }

        private void diseasesNoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            diseasesTxtBox.Enabled = false;
        }

        private void productsYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            productsTxtBox1.Enabled = true;
        }

        private void productsNoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            productsTxtBox1.Enabled = false;
        }

        private void equipmentYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            equipmentcheckedListBox.Enabled = true;
        }

        private void rquipmentNoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            equipmentcheckedListBox.Enabled = false;
        }

        public MedicalRecords CurrMedicalRecords
        {

            get { return this.currMedicalRecords; }
            set { this.currMedicalRecords = value; }
        }

        public bool Back
        {

            get { return this.back; }
            set { this.back = value; }
        }

        
    }
}
