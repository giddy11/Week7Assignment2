using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnTextFile
{
    public class AssignmentModel2
    {
        public int Id { get; set; }
        public string AssignmentName { get; set; }
        public string AssignmentLocation { get; set; }
        public AssignmentModel3 AssignmentModel3 { get; set; }
    }
}
