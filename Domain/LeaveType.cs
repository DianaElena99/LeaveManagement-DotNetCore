using Domain.Common;
using System;

namespace Domain
{
    public class LeaveType : BaseDomainEntity
    {
        public String Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
