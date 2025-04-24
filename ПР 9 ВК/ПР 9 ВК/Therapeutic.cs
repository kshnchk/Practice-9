using System;
using System.Collections.Generic;

namespace ПР_9_ВК
{
    internal class Therapeutic
    {
        public int therapeuticDepartmentId;
        public string therapeuticDepartmentName;
        public Doctor therapeuticHeadOfDepartment;
        public List<Doctor> therapeuticDoctors;
        public bool[] therapeuticBeds;

        public Therapeutic() { }
        public Therapeutic(int departmentId) { therapeuticDepartmentId = departmentId; }
        public Therapeutic(int departmentId, string name) : this(departmentId) { this.therapeuticDepartmentName = name; }
        public Therapeutic(int departmentId, string name, Doctor headOfDepartment) : this(departmentId, name) { this.therapeuticHeadOfDepartment = headOfDepartment; }
        public Therapeutic(int departmentId, string name, Doctor headOfDepartment, bool[] beds) : this(departmentId, name, headOfDepartment) { this.therapeuticBeds = beds; }

        public void AddDoctor(Doctor doctor)
        {
            if (therapeuticDoctors == null)
            {
                therapeuticDoctors = new List<Doctor>();
            }
            therapeuticDoctors.Add(doctor);
        }

        public bool RemoveDoctor(int doctorId)
        {
            var doctor = therapeuticDoctors?.Find(d => d.DoctorId == doctorId);
            if (doctor != null)
            {
                therapeuticDoctors.Remove(doctor);
                return true;
            }
            return false;
        }

        public Doctor FindDoctor(int doctorId)
        {
            return therapeuticDoctors?.Find(d => d.DoctorId == doctorId);
        }

        public int GetAvailableBeds()
        {
            int count = 0;
            foreach (bool bed in therapeuticBeds)
            {
                if (!bed) count++;
            }
            return count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа завершена.");
        }
    }
}

