using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ПР_9_ВК;

namespace ПР_9_ВК
{

    internal class Patient
    {
        private int patientId;
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private string diagnosis;

        public int PatientId => patientId; 
        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }
        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }
        public DateTime DateOfBirth
        {
            get => dateOfBirth;
            set => dateOfBirth = value;
        }
        public string Diagnosis
        {
            get => diagnosis;
            set => diagnosis = value;
        }

        public Patient() { }
        public Patient(int patientid) { this.patientId = patientid; }
        public Patient(int patientid, string firstName) : this(patientid) { this.firstName = firstName;}
        public Patient(int patientid, string firstName, string lastName) : this(patientid, firstName) { this.lastName = lastName;}
        public Patient(int patientid, string firstName, string lastName, DateTime dateOfBirth) : this(patientid, firstName, lastName) { this.dateOfBirth = dateOfBirth;}

        public Patient(int patientid, string firstName, string lastName, DateTime dateOfBirth, string diagnosis) : this(patientid, firstName, lastName, dateOfBirth) { this.diagnosis = diagnosis;}

        public void UpdateDiagnosis(string newDiagnosis)
        {
            this.diagnosis = newDiagnosis;
        }

        public int GetAge()
        {
            var today = DateTime.Today;
            var age = today.Year - dateOfBirth.Year;
            if (dateOfBirth > today.AddYears(-age)) age--;
            return age;
        }

        public override string ToString()
        {
            return $"Patient ID: {patientId}, Name: {firstName} {lastName}, Date of Birth: {dateOfBirth.ToShortDateString()}, Diagnosis: {diagnosis}";
        }
    }

}



