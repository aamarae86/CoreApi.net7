using AutoMapper;
using Hr.Application.Contracts.Persistence;
using Hr.Application.Features.LeaveRequest.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.Application.Features.LeaveRequest.Handlers.Commands
{
    public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, int>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public CreateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository,IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var _leaveRequest = _mapper.Map<Hr.Domain.LeaveRequest>(request.leaveRequest);
           _leaveRequest=await _leaveRequestRepository.Add(_leaveRequest);
            return _leaveRequest.Id;
        }
    }
}
