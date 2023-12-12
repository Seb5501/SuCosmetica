using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SuCosmetica.Classes;

namespace SuCosmetica.Forms
{
    
    class FileManager
    {
        //Write this token as the first line in the textfile as a stample 
        //to mark that the file is saved by this application 
        private const string fileVersionToken = "PatientMedRec_21";

        //The file version helps to make old files compatible
        private const double fileVersionNr = 1.0;
        public List<Patient> ReadTaskListFrFile(List<Patient> PatientList, string fileName)
        {
           
            StreamReader reader = null;
            try
            {
                if (PatientList != null)
                    PatientList.Clear();
                else
                    PatientList = new List<Patient>();

                reader = new StreamReader(fileName);

                //Ensure that is the correct file 
                string versionTest = reader.ReadLine();
                //Ensure that it has the correct version
                double version = double.Parse(reader.ReadLine());

                if ((versionTest == fileVersionToken) && (version == fileVersionNr))
                {
                    //read the number of tasks to read
                    int count = int.Parse(reader.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Patient patient = new Patient();
                        patient.ContactDetails.Firstname = reader.ReadLine();
                        patient.ContactDetails.Lastname = reader.ReadLine();

                        int year = 0, month = 0, day = 0;
                        int hour = 0, minute = 0, second = 0;

                        year = int.Parse(reader.ReadLine());
                        month = int.Parse(reader.ReadLine());
                        day = int.Parse(reader.ReadLine());


                        patient.ContactDetails.Birthday = new DateTime(year, month, day);
                        patient.ContactDetails.Cellphone = int.Parse(reader.ReadLine());
                        patient.ContactDetails.Location = (Locality)Enum.Parse(typeof(Locality), reader.ReadLine());
                        patient.MedicalRecords.Diagnosis = reader.ReadLine();
                        patient.MedicalRecords.Diseases = reader.ReadLine();
                        patient.MedicalRecords.Products = reader.ReadLine();
                        patient.MedicalRecords.Treatment = reader.ReadLine();

                        year = int.Parse(reader.ReadLine());
                        month = int.Parse(reader.ReadLine());
                        day = int.Parse(reader.ReadLine());
                        

                        patient.ContactDetails.FirstTime = new DateTime(year, month, day);

                        year = int.Parse(reader.ReadLine());
                        month = int.Parse(reader.ReadLine());
                        day = int.Parse(reader.ReadLine());
                        hour = int.Parse(reader.ReadLine());
                        minute = int.Parse(reader.ReadLine());
                        second = int.Parse(reader.ReadLine());

                        patient.ContactDetails.NextTurn = new DateTime(year, month, day, hour, minute, second);
                        if (reader.ReadLine() == "Ultrasonic skin spatula")
                        {
                            patient.MedicalRecords.Equi.Add("Ultrasonic skin spatula");
                        }
                        if (reader.ReadLine() == "Diamond tip")
                        {
                            patient.MedicalRecords.Equi.Add("Diamond tip");
                        }
                        if (reader.ReadLine() == "Radiofrequency")
                        {
                            patient.MedicalRecords.Equi.Add("Radiofrequency");
                        }
                        if (reader.ReadLine() == "Electroporator")
                        {
                            patient.MedicalRecords.Equi.Add("Electroporator");
                        }
                        if (reader.ReadLine() == "High frequency")
                        {
                            patient.MedicalRecords.Equi.Add("High frequency");
                        }
                        if (reader.ReadLine() == "Dermaplaning")
                        {
                            patient.MedicalRecords.Equi.Add("Dermaplaning");
                        }
                        if (reader.ReadLine() == "Dermapen")
                        {
                            patient.MedicalRecords.Equi.Add("Dermapen");
                        }
                        if (reader.ReadLine() == "Nanopen")
                        {
                            patient.MedicalRecords.Equi.Add("Nanopen");
                        }
                        PatientList.Add(patient);
                    }
                }
                else
                    return null;
            }
            catch
            {
                //if any error occurs in above try-block, the execution will
                //jump to this block (avoiding program crash) 
                return null;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return PatientList;
        }
        public bool SaveTaskListToFile(List<Patient> patientList, string fileName)
        {
            bool ok = true;
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(fileName);
                writer.WriteLine(fileVersionToken);
                writer.WriteLine(fileVersionNr);
                writer.WriteLine(patientList.Count);

                for (int i = 0; i < patientList.Count; i++)
                {
                    writer.WriteLine(patientList[i].ContactDetails.Firstname);
                    writer.WriteLine(patientList[i].ContactDetails.Lastname);
                    writer.WriteLine(patientList[i].ContactDetails.Birthday.Year);
                    writer.WriteLine(patientList[i].ContactDetails.Birthday.Month);
                    writer.WriteLine(patientList[i].ContactDetails.Birthday.Day);
                    writer.WriteLine(patientList[i].ContactDetails.Cellphone.ToString());
                    writer.WriteLine(patientList[i].ContactDetails.Location.ToString());
                    writer.WriteLine(patientList[i].MedicalRecords.Diagnosis);
                    writer.WriteLine(patientList[i].MedicalRecords.Diseases);
                    writer.WriteLine(patientList[i].MedicalRecords.Products);
                    writer.WriteLine(patientList[i].MedicalRecords.Treatment);
                    writer.WriteLine(patientList[i].ContactDetails.FirstTime.Year);
                    writer.WriteLine(patientList[i].ContactDetails.FirstTime.Month);
                    writer.WriteLine(patientList[i].ContactDetails.FirstTime.Day);
                    writer.WriteLine(patientList[i].ContactDetails.NextTurn.Year);
                    writer.WriteLine(patientList[i].ContactDetails.NextTurn.Month);
                    writer.WriteLine(patientList[i].ContactDetails.NextTurn.Day);
                    writer.WriteLine(patientList[i].ContactDetails.NextTurn.Hour);
                    writer.WriteLine(patientList[i].ContactDetails.NextTurn.Minute);
                    writer.WriteLine(patientList[i].ContactDetails.NextTurn.Second);

                    if(patientList[i].MedicalRecords.Equi.Contains("Ultrasonic skin spatula"))
                    {
                        writer.WriteLine("Ultrasonic skin spatula");
                    }
                    else
                    {
                        writer.WriteLine("");
                    }

                    if (patientList[i].MedicalRecords.Equi.Contains("Diamond tip"))
                    {
                        writer.WriteLine("Diamond tip");
                    }
                    else
                    {
                        writer.WriteLine("");
                    }

                    if (patientList[i].MedicalRecords.Equi.Contains("Radiofrequency"))
                    {
                        writer.WriteLine("Radiofrequency");
                    }
                    else
                    {
                        writer.WriteLine("");
                    }

                    if (patientList[i].MedicalRecords.Equi.Contains("Electroporator"))
                    {
                        writer.WriteLine("Electroporator");
                    }
                    else
                    {
                        writer.WriteLine("");
                    }

                    if (patientList[i].MedicalRecords.Equi.Contains("High frequency"))
                    {
                        writer.WriteLine("High frequency");
                    }
                    else
                    {
                        writer.WriteLine("");
                    }

                    if (patientList[i].MedicalRecords.Equi.Contains("Dermaplaning"))
                    {
                        writer.WriteLine("Dermaplaning");
                    }
                    else
                    {
                        writer.WriteLine("");
                    }

                    if (patientList[i].MedicalRecords.Equi.Contains("Dermapen"))
                    {
                        writer.WriteLine("Dermapen");
                    }
                    else
                    {
                        writer.WriteLine("");
                    }

                    if (patientList[i].MedicalRecords.Equi.Contains("Nanopen"))
                    {
                        writer.WriteLine("Nanopen");
                    }
                    else
                    {
                        writer.WriteLine("");
                    }

                }
            }
            catch
            {
                //if any error occurs in above try-block, the execution will
                //jump to this block (avoiding program crash) 
                ok = false;
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
            return ok;
        }
    }
}
