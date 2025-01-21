using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Persistence.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        private readonly AppDbContext _dbContext;
        public LeaveTypeRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
