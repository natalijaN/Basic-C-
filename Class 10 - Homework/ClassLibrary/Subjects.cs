using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Subjects
    {
        public string NameOfSubject { get; set; }
        public int indicatiorOfStudents { get; set; }

        public Subjects(string name)
        {
            NameOfSubject = name;
        }

        public Subjects()
        {

        }
    }
}
