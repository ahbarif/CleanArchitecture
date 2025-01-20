using CleanArchitecture.Application.DTOs.LeaveAllocation;
using MediatR;

namespace CleanArchitecture.Application.Features.LeaveAllocations.Requests.Commands
{
    public class UpdateLeaveAllocationCommand : IRequest<Unit>
    {
        public UpdateLeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
