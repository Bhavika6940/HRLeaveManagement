using HRLeaveManagement.Application.Features.LeaveRequests.Requests.Commands;
using MediatR;
using AutoMapper;
using HRLeaveManagement.Application.Contracts.Persistence;
namespace HRLeaveManagement.Application.Features.LeaveRequests.Handlers.Commands
{
    public class UpdateLeaveRequestCommandHandler : IRequestHandler<UpdateLeaveRequestCommand, Unit>  
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
        public UpdateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.Get(request.Id);
            if(request.LeaveRequestDto!= null)
            {
                _mapper.Map(request.LeaveRequestDto, leaveRequest);

                await _leaveRequestRepository.Update(leaveRequest);
            }
            else if(request.ChangeLeaveRequestApprovalDto!= null)
            {
                _mapper.Map(request.ChangeLeaveRequestApprovalDto, leaveRequest);
                await _leaveRequestRepository.Update(leaveRequest);
            }   

            return Unit.Value;
        }

    }
}
