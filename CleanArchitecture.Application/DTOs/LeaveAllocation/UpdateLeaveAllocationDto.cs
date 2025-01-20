using CleanArchitecture.Application.DTOs.Common;

namespace CleanArchitecture.Application.DTOs.LeaveAllocation
{
    public class UpdateLeaveAllocationDto : BaseDto, ILeaveAllocationDto
    {
        public int NumberOfDays { get; set; }
        public int Period { get; set; }
        public int LeaveTypeId { get; set; }
    }
}
