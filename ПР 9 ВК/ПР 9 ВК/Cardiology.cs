using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ПР_9_ВК
{
    internal class Cardiology
    {
        public int departmentId; 
        public string name;       
        public Doctor headOfDepartment;
        public List<Doctor> doctors;
        public bool[] beds;      

        
        public Cardiology() { }
        public Cardiology(int departmentid) { departmentId = departmentid; }
        public Cardiology(int departmentid, string name) : this(departmentid) { this.name = name; }
        public Cardiology(int departmentid, string name, Doctor headOfDepartment) : this(departmentid, name) { this.headOfDepartment = headOfDepartment; }
        public Cardiology(int departmentid, string name, Doctor headOfDepartment, bool[] beds) : this(departmentid, name, headOfDepartment) { this.beds = beds; }

        
        public void AddDoctor(Doctor doctor)
        {
            if (doctors == null)
            {
                doctors = new List<Doctor>();
            }
            doctors.Add(doctor); 
        }

        
        public bool RemoveDoctor(int doctorId)
        {
            var doctor = doctors?.Find(d => d.DoctorId == doctorId);
            if (doctor != null)
            {
                doctors.Remove(doctor); 
                return true; 
            }
            return false; 
        }

        
        public Doctor FindDoctor(int doctorId)
        {
            return doctors?.Find(d => d.DoctorId == doctorId); 
        }

        
        public int GetAvailableBeds()
        {
            int count = 0; 
            foreach (bool bed in beds)
            {
                if (!bed) 
                    count++; 
            }
            return count; 
        }
    }

}



