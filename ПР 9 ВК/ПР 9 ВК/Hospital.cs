using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР_9_ВК
{
    using System.Collections.Generic;

    internal class Hospital
    {
        private int hospitalId;
        private string name;
        private string address;
        private List<string> departments;

        public int HospitalId => hospitalId;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Address
        {
            get => address;
            set => address = value;
        }
        public List<string> Departments
        {
            get => departments;
            set => departments = value;
        }

        public Hospital() { }
        public Hospital(int hospitalid) { this.hospitalId = hospitalid; }
        public Hospital(int hospitalid, string name) : this(hospitalid) { this.name = name; }
        public Hospital(int hospitalid, string name, string adress) : this(hospitalid, name) { this.address = adress; }
        public Hospital(int hospitalid, string name, string adress, List<string> derpatments) : this(hospitalid, name, adress) { this.departments = derpatments; }
    }

}

