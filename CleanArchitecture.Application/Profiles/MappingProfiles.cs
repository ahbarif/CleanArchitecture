using AutoMapper;
using CleanArchitecture.Application.DTOs.LeaveAllocation;
using CleanArchitecture.Application.DTOs.LeaveRequest;
using CleanArchitecture.Application.DTOs.LeaveType;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
        }
    }
}
