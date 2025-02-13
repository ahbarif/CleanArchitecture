﻿namespace CleanArchitecture.Application.DTOs.LeaveAllocation
{
    public interface ILeaveAllocationDto
    {
        public int NumberOfDays { get; set; }
        public int Period { get; set; }
        public int LeaveTypeId { get; set; }
    }
}
