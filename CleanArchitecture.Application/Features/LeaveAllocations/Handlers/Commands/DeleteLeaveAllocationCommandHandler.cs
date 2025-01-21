using AutoMapper;
using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Application.Features.LeaveAllocations.Requests.Commands;
using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Features.LeaveAllocations.Handlers.Commands
{
    public partial class CreateLeaveAllocationCommandHandler
    {
        public class DeleteLeaveAllocationCommandHandler : IRequestHandler<DeleteLeaveAllocationCommand, Unit>
        {
            private readonly ILeaveAllocationRepository _leaveAllocationRepository;
            private readonly IMapper _mapper;

            public DeleteLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
            {
                _leaveAllocationRepository = leaveAllocationRepository;
                _mapper = mapper;
            }

            public async Task<Unit> Handle(DeleteLeaveAllocationCommand request, CancellationToken cancellationToken)
            {
                var leaveAllocation = await _leaveAllocationRepository.GetAsync(request.Id);

                if (leaveAllocation == null)
                {
                    throw new NotFoundException(nameof(LeaveAllocation), request.Id);
                }

                await _leaveAllocationRepository.DeleteAsync(leaveAllocation);

                return Unit.Value;
            }

        }
    }
}

