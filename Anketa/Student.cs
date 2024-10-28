using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anketa
{
    internal class Student
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public bool NeedsHostel { get; set; }
        public bool IsLeader { get; set; }
        public ImageSource Photo { get; set; }
    }
}
