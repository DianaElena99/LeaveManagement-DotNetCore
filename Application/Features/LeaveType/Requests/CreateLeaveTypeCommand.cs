using Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.LeaveType.Requests
{
    public class CreateLeaveTypeCommand : IRequest<int>
    {
        public LeaveTypeDTO leaveTypeDTO;
    }
}
