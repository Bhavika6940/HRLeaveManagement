using HRLeaveManagement.Application.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLeaveManagement.Application.Features.LeaveType.Requests.Commands
{
    public class UpdateLeaveTypeCommand
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
