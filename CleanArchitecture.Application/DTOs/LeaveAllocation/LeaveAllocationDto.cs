using CleanArchitecture.Application.DTOs.Common;
using CleanArchitecture.Application.DTOs.LeaveType;

namespace CleanArchitecture.Application.DTOs.LeaveAllocation
{
    public class LeaveAllocationDto : BaseDto, ILeaveAllocationDto
    {
        public int NumberOfDays { get; set; }
        public int Period { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
    }
}
