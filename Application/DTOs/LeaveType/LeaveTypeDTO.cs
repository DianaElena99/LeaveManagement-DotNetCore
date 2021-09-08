using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class LeaveTypeDTO : BaseDTO
    {
        public String Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
