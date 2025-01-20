using AutoMapper;
using CleanArchitecture.Application.Features.LeaveRequests.Requests.Commands;
using CleanArchitecture.Application.Persistence.Contracts;
using MediatR;

namespace CleanArchitecture.Application.Features.LeaveRequests.Handlers.Commands
{
    public class UpdateLeaveRequestCommandHandler : IRequestHandler<UpdateLeaveRequestCommand, Unit>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveRequestCommandHandler(
            ILeaveRequestRepository leaveRequestRepository,
            IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.GetAsync(request.Id);

            if (request.LeaveRequestDto != null)
            {
                _mapper.Map(request.LeaveRequestDto, leaveRequest);
                await _leaveRequestRepository.UpdateAsync(leaveRequest);
            }
            else if(request.ChangeLeaveRequestApprovalDto == null)
            {
                await _leaveRequestRepository.ChangeApprovalStatusAsync(leaveRequest, request.ChangeLeaveRequestApprovalDto.Approved);
            }
            return Unit.Value;

        }
    }
}
