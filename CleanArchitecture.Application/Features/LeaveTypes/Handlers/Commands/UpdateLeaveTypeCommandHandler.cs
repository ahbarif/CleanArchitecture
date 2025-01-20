using AutoMapper;
using CleanArchitecture.Application.DTOs.LeaveType.Validators;
using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Application.Features.LeaveTypes.Requests.Commands;
using CleanArchitecture.Application.Persistence.Contracts;
using MediatR;

namespace CleanArchitecture.Application.Features.LeaveTypes.Handlers.Commands
{
    public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveTypeCommandHandler(
            ILeaveTypeRepository leaveTypeRepository,
            IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateLeaveTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.LeaveTypeDto);

            if (validationResult.IsValid == false)
            {
                throw new ValidationException(validationResult);
            }

            var leaveType = await _leaveTypeRepository.GetAsync(request.LeaveTypeDto.Id);
            _mapper.Map(request.LeaveTypeDto, leaveType);
            await _leaveTypeRepository.UpdateAsync(leaveType);
            return Unit.Value;
        }
    }
}
