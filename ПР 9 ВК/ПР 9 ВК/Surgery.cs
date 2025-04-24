using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР_9_ВК
{
    internal class Surgery
    {
        public int surgeryDepartmentId;
        public string surgeryDepartmentName;
        public Doctor surgeryHeadOfDepartment;
        public List<Doctor> surgeryDoctors;
        public bool[] surgeryBeds;

        public Surgery() { }
        public Surgery(int departmentId) { surgeryDepartmentId = departmentId; }
        public Surgery(int departmentId, string name) : this(departmentId) { this.surgeryDepartmentName = name; }
        public Surgery(int departmentId, string name, Doctor headOfDepartment) : this(departmentId, name) { this.surgeryHeadOfDepartment = headOfDepartment; }
        public Surgery(int departmentId, string name, Doctor headOfDepartment, bool[] beds) : this(departmentId, name, headOfDepartment) { this.surgeryBeds = beds; }

        public void AddDoctor(Doctor doctor)
        {
            if (surgeryDoctors == null)
            {
                surgeryDoctors = new List<Doctor>();
            }
            surgeryDoctors.Add(doctor);
        }

        public bool RemoveDoctor(int doctorId)
        {
            var doctor = surgeryDoctors?.Find(d => d.DoctorId == doctorId);
            if (doctor != null)
            {
                surgeryDoctors.Remove(doctor);
                return true;
            }
            return false;
        }

        public Doctor FindDoctor(int doctorId)
        {
            return surgeryDoctors?.Find(d => d.DoctorId == doctorId);
        }

        public int GetAvailableBeds()
        {
            int count = 0;
            foreach (bool bed in surgeryBeds)
            {
                if (!bed)
                    count++;
            }
            return count;
        }
    }

}
