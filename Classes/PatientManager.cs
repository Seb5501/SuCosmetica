using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuCosmetica.Classes;

namespace SuCosmetica.Forms
{
    public class PatientManager
    {
        List<Patient> patients = new List<Patient>();
        private List<string> infoStrings = new List<string>();
        int numClients = 0;


        // Gets Patient and Adds it in the List
        public string AddInfo(Patient patient)
        {
            patients.Add(patient);
            infoStrings.Add(patient.ToStrings());
            numClients++;
            return infoStrings[numClients - 1];
        }

        // Gets Patient and Insert it in the List
        public string InsertInfo(Patient patient, int index)
        {
            patients.RemoveAt(index);
            patients.Insert(index, patient);
            infoStrings.RemoveAt(index);
            infoStrings.Insert(index, patient.ToStrings());
            return infoStrings[index];
        }

 

        //FileManager is a class that handles saving and reading data 
        //to and from a text file. Send the PatientList from which
        //data is read and saved to the file filename
        public bool WriteDataToFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.SaveTaskListToFile(patients, fileName);
        }

        //Send the patients object declared in above to which 
        //data from the fileName is saved. As patients is an object
        //it will have the changes made in the FileManager when 
        //the method ReadTaskListFrFile returns
        public void ReadDataToFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            GetPatientList(fileManager.ReadTaskListFrFile(patients, fileName));

        }


        // When the user opens and loads a file, this method takes all the patients from it and adds them to infoString list
        // So then it can be easly add it to the List Box
        public void GetPatientList(List<Patient> PatientList)
        {
            if (PatientList != null)
            {
                foreach (Patient patient in PatientList)
                {
                    if (patients.Contains(patient))
                    {
                        infoStrings.Add(patient.ToStrings());
                        numClients++;
                    }
                }
            }         
        }

        // Gets the index and Returns the Patient
        public Patient SaveEditing(int index)
        {
            return patients[index];
        }

        // Deletes the Patient from the list
        public void DeletePatient(int index)
        {
            patients.RemoveAt(index);
            infoStrings.RemoveAt(index);
            numClients--;
        }


        public List<string> PatientList
        {
            get { return infoStrings; }
            set { infoStrings = value; }
        }
    }
}
