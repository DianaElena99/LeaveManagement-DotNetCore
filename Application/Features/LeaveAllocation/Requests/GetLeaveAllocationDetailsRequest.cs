using Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.LeaveAllocation.Requests
{
    public class GetLeaveAllocationDetailsRequest : IRequest<LeaveAllocationDTO>
    {
        public int Id { get; set; }
    }
}
