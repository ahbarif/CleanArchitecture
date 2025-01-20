using CleanArchitecture.Application.DTOs.LeaveRequest;
using MediatR;

namespace CleanArchitecture.Application.Features.LeaveRequests.Requests.Commands
{
    public class UpdateLeaveRequestCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public UpdateLeaveRequestDto LeaveRequestDto { get; set; }
        public ChangeLeaveRequestApprovalDto ChangeLeaveRequestApprovalDto { get; set; }
    }
}
