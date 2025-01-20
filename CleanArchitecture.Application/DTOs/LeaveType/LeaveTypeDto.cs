using CleanArchitecture.Application.DTOs.Common;

namespace CleanArchitecture.Application.DTOs.LeaveType
{
    public class LeaveTypeDto : BaseDto, ILeaveTypeDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }

}
