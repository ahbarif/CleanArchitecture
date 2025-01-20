﻿using CleanArchitecture.Application.DTOs.LeaveType;
using MediatR;

namespace CleanArchitecture.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand : IRequest<int>
    { 
        public CreateLeaveTypeDto LeaveTypeDto { get; set; }
    }
}
