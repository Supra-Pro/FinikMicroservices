using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Domain.Eintities
{
    public class ProjectsModel
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        // rasm qoshadigan joyi.
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
