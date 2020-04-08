using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Roles
    {
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public int RoleType { get; set; }
        public string RoleTypeName { get; set; }

        public List<EmployeeActions> EmployeeActions { get; set; }

        public List<WorkflowManagement> WorkflowManagements { get; set; }

        public DataGroupPermissions DataGroupPermissions { get; set; }

    }

}
