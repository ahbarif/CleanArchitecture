using CleanArchitecture.Application.DTOs.LeaveType;
using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {
    }
}
