using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.LeaveRequest
{
    public interface ILeaveRequestDTO
    {
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public int LeaveTypeId { get; set; }
        
    }
}
