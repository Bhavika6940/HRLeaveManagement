using HRLeaveManagement.Application.DTOs.LeaveType;
using MediatR;
using HRLeaveManagement.Application.DTOs.LeaveType;

namespace HRLeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand : IRequest<int>
    {
        public CreateLeaveTypeDto LeaveTypeDto { get; set; }
    }
}
