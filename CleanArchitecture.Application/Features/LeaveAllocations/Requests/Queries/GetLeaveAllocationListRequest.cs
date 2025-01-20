using CleanArchitecture.Application.DTOs.LeaveAllocation;
using MediatR;

namespace CleanArchitecture.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationDto>>
    {
    }
}
