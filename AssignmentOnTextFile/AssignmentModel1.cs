using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnTextFile
{
    public class AssignmentModel1
    {
        public int Id { get; set; }
        public string AssignmentName { get; set; }
        public string AssignmentLocation { get; set; }
        public AssignmentModel2 AssignmentModel2 { get; set; }

    }
}
