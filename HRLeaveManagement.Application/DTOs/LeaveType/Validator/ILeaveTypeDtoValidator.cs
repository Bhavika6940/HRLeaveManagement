using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace HRLeaveManagement.Application.DTOs.LeaveType.Validator
{
    public class ILeaveTypeDtoValidator : AbstractValidator<ILeaveTypeDto>
    {
       public ILeaveTypeDtoValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} must be present")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");
            RuleFor(p => p.DefaultDays)
                .NotEmpty().WithMessage("{PropertyName} must be present")
                .GreaterThan(0).WithMessage("{PropertyName} must be greater than {ComparisionValue}")
                .LessThan(100).WithMessage("{PropertyName} must be less than {ComparisonValue}");
        }
    }
}
