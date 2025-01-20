using CleanArchitecture.Application.DTOs.Common;
using CleanArchitecture.Application.DTOs.LeaveType;

namespace CleanArchitecture.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto: BaseDto
    {
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }
    }
}
