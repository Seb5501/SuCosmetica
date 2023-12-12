using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuCosmetica.Classes;
using SuCosmetica.Forms;
using System.IO;
using SuCosmetica.Classes;

namespace SuCosmetica
{

    

    public partial class MainMenuForm : Form
    {
        //Variables
        PatientManager patientManager = new PatientManager();
        ContactDetailsForm contactDetails = new ContactDetailsForm();
        MedicalRecordsForm medicalRecordsForm = new MedicalRecordsForm();
        Clients clients = new Clients();
        string fileName = Application.StartupPath + "\\Save.txt"; //Default file Name
        private Button currentButton;
        
        

        //Constructors

        public MainMenuForm()
        {
            InitializeComponent(); 
            patientManager.ReadDataToFile(fileName); // Tries to load a save file
            clientListBox.Items.AddRange(patientManager.PatientList.ToArray());// Adds all the patients saved in the save file to the client list
        }
        

        //Methods

        #region BUTTONS

        private void addButton_Click(object sender, EventArgs e)
        {
            contactDetails.InitializeGUI();
            contactDetails.Edit = false; // Sets the bool edit to false
            contactDetails.ShowDialog(); // Opens the client form 
            ShowClientForm(); //Calls the ShowClientForm Methods

        } //Opens AddClientForm 

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.Coral;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        } //Changes font and color of the clicked button

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        } //Changes font and color of the rest of the buttons

        private void buttonClients_Click(object sender, EventArgs e)
        {
           

        } // Shows Client List GUI 

      


        private void buttonAbout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender); //Activates About Box Button
            AboutBox aboutbox = new AboutBox();
            aboutbox.ShowDialog(); // Opens About Box Form
        } //Opens About box

        private void clientListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.clientListBox.SelectedIndex; // Set Index to the a selected Item

            Patient currPatient = patientManager.SaveEditing(index); //Sets the current patient to the selected one 

            lblTitle.Text = currPatient.ContactDetails.Firstname + " " + currPatient.ContactDetails.Lastname; // Changes the title label with the name of the selected patient
            clients.GetCurrPatient(currPatient);
            clients.ShowDialog();
            this.lblTitle.Text = "MENU";
        } // Changes the GUI for the selected Patient

        private void editButton_Click(object sender, EventArgs e)
        {
            int index = this.clientListBox.SelectedIndex; // Set Index to the a selected Item

            if (index < 0) // Show an error message if he user is not selecting a patient
            {
                MessageBox.Show("Primero Selecciona un Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                contactDetails.EditedPatient = patientManager.SaveEditing(index); //Sets the current patient to the selected one 
                contactDetails.GetEditPatient(contactDetails.EditedPatient);
                contactDetails.Edit = true; //sets edit bool to true
                contactDetails.ShowDialog(); //opens add client form      
                ShowClientForm();

            }
        } //Opens the add client form for editing 

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = this.clientListBox.SelectedIndex;// Set Index to the a selected Item
            if (index < 0)// if the user is not selecting an items, send an error
            {
                MessageBox.Show("Primero Selecciona un Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {  // if the user is selecting an item, removes it from the list.
                var confirmResult = MessageBox.Show("Estas Seguro de que quiere Borrar este Cliente?",
                                      "Confirmar Borrado!",
                                      MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    patientManager.DeletePatient(index);
                    clientListBox.Items.RemoveAt(index);
                    patientManager.WriteDataToFile(fileName);
                }
            }
        } //Deletes a selected Patient

        #endregion

        #region UpdateGUI

       

        public void ShowClientForm()
        {
            int index = this.clientListBox.SelectedIndex;
            // Set Index to the a selected Item
            if (contactDetails.CurrPatient != null)
            {
                if (!contactDetails.Edit) //if the user didnt edit
                {
                    clientListBox.Items.Add(patientManager.AddInfo(contactDetails.CurrPatient)); // adds the patient to the list 
                    patientManager.WriteDataToFile(fileName); // saves the client list
                }
                else // if the user did edit
                {
                    if (index >= 0)// if the user is not selecting an items, send an error
                    {
                        clientListBox.Items.RemoveAt(index); // removes the old client
                        clientListBox.Items.Insert(index, patientManager.InsertInfo(contactDetails.EditedPatient, index)); //inserts edited client to the old position
                        lblTitle.Text = contactDetails.EditedPatient.ContactDetails.Firstname + " " + contactDetails.EditedPatient.ContactDetails.Lastname; //updates the title
                        patientManager.WriteDataToFile(fileName); // saves the client list
                    }
                }
            }
                contactDetails.Hide(); // closes the form
                }




        #endregion

        
    }
}
