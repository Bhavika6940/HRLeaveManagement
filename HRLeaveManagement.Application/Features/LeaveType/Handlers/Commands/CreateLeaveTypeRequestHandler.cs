using AutoMapper;
using HRLeaveManagement.Application.Contracts.Persistence;
using HRLeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
using MediatR;
using HRLeaveManagement.Domain;
using HRLeaveManagement.Application.DTOs.LeaveType.Validator;


namespace HRLeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class CreateLeaveTypeRequestHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public CreateLeaveTypeRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateLeaveTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.LeaveTypeDto);

            if (!validationResult.IsValid == false)
            {
                throw new Exception();
            }
            var leaveType = _mapper.Map<HRLeaveManagement.Domain.LeaveType>(request.LeaveTypeDto);
            await _leaveTypeRepository.Add(leaveType);
            return leaveType.Id;
        }
    }
}
