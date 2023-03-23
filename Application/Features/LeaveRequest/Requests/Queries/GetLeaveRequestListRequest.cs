using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.Application.Features.LeaveRequest.Requests.Queries
{
    public class GetLeaveRequestListRequest :IRequest<List<LeaveRequestDto>>
    {
    }
}
