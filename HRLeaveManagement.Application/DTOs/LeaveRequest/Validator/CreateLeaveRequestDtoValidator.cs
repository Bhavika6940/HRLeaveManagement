using FluentValidation;
using HRLeaveManagement.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLeaveManagement.Application.DTOs.LeaveRequest.Validator
{
    public class CreateLeaveRequestDtoValidator : AbstractValidator<CreateLeaveRequestDto>
    {
        private readonly ILeaveRequestRepository _leaveRepository;

        public CreateLeaveRequestDtoValidator(ILeaveRequestRepository leaveRepository)
        {
            _leaveRepository = leaveRepository;
            Include(new ILeaveRequestDtoValidator(_leaveRepository));
        }

        
    }
}
