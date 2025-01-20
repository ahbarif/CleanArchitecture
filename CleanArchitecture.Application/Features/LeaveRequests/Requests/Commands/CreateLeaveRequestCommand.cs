using CleanArchitecture.Application.DTOs.LeaveRequest;
using CleanArchitecture.Application.Responses;
using MediatR;

namespace CleanArchitecture.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand : IRequest<BaseCommandResponse>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }
    }
}
