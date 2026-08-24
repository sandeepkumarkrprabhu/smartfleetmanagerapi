using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFleet.Utility
{
    public enum AuditActionType
    {
        Login = 1,
        Logout = 2,
        Create = 3,
        Update = 4,
        Delete = 5,
        View = 6,
        Export = 7,
        Approve = 8,
        Reject = 9,
    }
}
