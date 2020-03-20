using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DataGroupPermissions
    {
        DataGroupPermissions()
        {
            AdminGroups = new List<AdminGroup>();
        }
        public List<AdminGroup> AdminGroups { get; set; }
    }
    public class AdminGroup
    {
        AdminGroup()
        {
            AdminGroupName = "";
            DataGroupIdPermissionsId = 0;
            AdminSubGroupPermissions = new List<AdminSubGroups>();
        }
        public string AdminGroupName { get; set; }

        public int DataGroupIdPermissionsId { get; set; }
        public List<AdminSubGroups> AdminSubGroupPermissions { get; set; }

    }
    public class AdminSubGroups
    {
        AdminSubGroups()
        {
            AdminSubGroupNames = "";
        }
        public string AdminSubGroupNames { get; set; }
        public bool canread { get; set; }
        public bool canwrite { get; set; }
        public bool candelete { get; set; }
    }
}
