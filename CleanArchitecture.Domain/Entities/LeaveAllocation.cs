﻿using CleanArchitecture.Domain.Entities.Common;

namespace CleanArchitecture.Domain.Entities
{
    public class LeaveAllocation : BaseDomainEntity
    {
        public int NumberOfDays { get; set; }
        public int Period { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
    }
}
