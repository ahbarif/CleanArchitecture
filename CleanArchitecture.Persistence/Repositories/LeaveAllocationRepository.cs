using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Persistence.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        public LeaveAllocationRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails()
        {
            throw new NotImplementedException();
        }

        public Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id)
        {
            throw new NotImplementedException();
        }
    }
}
