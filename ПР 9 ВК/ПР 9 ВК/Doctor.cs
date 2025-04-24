using System.Security.Cryptography.X509Certificates;

namespace ПР_9_ВК
{

    internal class Doctor
    {
        private int doctorId;
        private string firstName;
        private string lastName;
        private string specialization;
        private List<Patient> patients;

        public int DoctorId => doctorId; 
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
        public string Specialization
        {
            get => specialization;
            set => specialization = value;
        }
        public List<Patient> Patients
        {
            get => patients ??= new List<Patient>(); 
        }

        public Doctor(int doctorId) { this.doctorId = doctorId; }
        public Doctor(int doctorId, string firstName) : this(doctorId) { this.firstName = firstName; }
        public Doctor(int doctorId, string firstName, string lastName) : this(doctorId, firstName) { this.lastName = lastName; }
        public Doctor(int doctorId, string firstName, string lastName, List<Patient> patients) : this(doctorId, firstName, lastName) { this.patients = patients; }

        public void AddPatient(Patient patient)
        {
            if (patient != null && !Patients.Contains(patient))
            {
                Patients.Add(patient);
            }
        }

        public bool RemovePatient(int patientId)
        {
            var patient = Patients.Find(p => p.PatientId == patientId);
            if (patient != null)
            {
                Patients.Remove(patient);
                return true;
            }
            return false;
        }

        public Patient FindPatient(int patientId)
        {
            return Patients.Find(p => p.PatientId == patientId);
        }

        public int GetPatientCount()
        {
            return Patients.Count;
        }
    }
}    

