using AutoMapper;
using Hr.Application.Contracts.Persistence;
using Hr.Application.Features.LeaveType.Requests.Commands;
using Hr.Domain;
using MediatR;

namespace Hr.Application.Features.LeaveType.Handlers.Commands
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository,IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        

        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leaveType =_mapper.Map<Hr.Domain.LeaveType>(request.LeaveTypeDto);
            leaveType =await _leaveTypeRepository.Add(leaveType);
            return leaveType.Id;
           
        }
    }
}
