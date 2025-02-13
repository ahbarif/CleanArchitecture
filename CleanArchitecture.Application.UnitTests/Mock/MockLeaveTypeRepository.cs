using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Domain.Entities;
using Moq;

namespace CleanArchitecture.Application.UnitTests.Mock
{
    public static class MockLeaveTypeRepository
    {
        public static Mock<ILeaveTypeRepository> GetLeaveTypeRepository()
        {
            var leaveTypes = new List<LeaveType>
            {
                new LeaveType 
                { 
                    Id = 1, 
                    Name = "Vacation",
                    DefaultDays = 10
                },
                 new LeaveType
                {
                    Id = 2,
                    Name = "Sick",
                    DefaultDays = 12
                }
            };
            var mockRepo = new Mock<ILeaveTypeRepository>();

            mockRepo.Setup(r => r.GetAllAsync()).ReturnsAsync(leaveTypes);
            mockRepo.Setup(r => r.AddAsync(It.IsAny<LeaveType>())).ReturnsAsync((LeaveType leaveType) =>
            {
                leaveType.Id = leaveTypes.Count + 1;
                leaveTypes.Add(leaveType);
                return leaveType;
            });

            return mockRepo;
        }
    }
}
