using CleanArchitecture.Application.DTOs.Common;

namespace CleanArchitecture.Application.DTOs.LeaveRequest
{
    public class ChangeLeaveRequestApprovalDto : BaseDto
    {
        public bool? Approved { get; set; }
    }
}
