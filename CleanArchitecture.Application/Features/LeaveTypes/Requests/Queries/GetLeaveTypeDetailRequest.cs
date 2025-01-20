using CleanArchitecture.Application.DTOs.LeaveType;
using MediatR;

namespace CleanArchitecture.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
