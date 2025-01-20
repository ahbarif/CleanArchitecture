using CleanArchitecture.Application.DTOs.LeaveRequest;
using MediatR;

namespace CleanArchitecture.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestListRequest : IRequest<List<LeaveRequestListDto>>
    {

    }
}
