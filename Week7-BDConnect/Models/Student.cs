using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week7_BDConnect.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentLName { get; set; }
        public string StudentCourse { get; set;}
        public string StudentStatus { get; set; }
        public int StudentYear { get; set; }
        public int StudentLevel { get; set; }
    }
}
