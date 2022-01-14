using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESDesign.Model
{
    class Employee
    {
        string name;
        string gender;
        string tel;
        string depart;
        string position;
        string work;

        public Employee(string name, string gender, string tel,
            string depart, string position, string work)
        {
            this.name = name;
            this.gender = gender;
            this.tel = tel;
            this.depart = depart;
            this.position = position;
            this.work = work;
        }

        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Depart { get => depart; set => depart = value; }
        public string Position { get => position; set => position = value; }
        public string Work { get => work; set => work = value; }
    }
}
