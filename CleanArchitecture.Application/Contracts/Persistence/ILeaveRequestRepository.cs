using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Contracts.Persistence
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetails(int id);
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetails();
        Task ChangeApprovalStatusAsync(LeaveRequest leaveRequest, bool? ApprovalStatus);
    }
}
 