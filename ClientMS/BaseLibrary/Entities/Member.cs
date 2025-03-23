using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? FullName { get; set; }

        public string? Type { get; set; }
        public string? Address { get; set; }
        public string? CellNumber { get; set; }
        public string? Photo { get; set; }
        public string? Other { get; set; }

        //Relationship: Many to One
        public MedicalAid? MedicalAid { get; set; }

        public SchemeOption? SchemeOption { get; set; }

        public Employer? Employer { get; set; }
    }
}
