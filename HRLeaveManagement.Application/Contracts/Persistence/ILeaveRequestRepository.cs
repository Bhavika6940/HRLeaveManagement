using HRLeaveManagement.Application.DTOs.LeaveRequest;
using HRLeaveManagement.Application.Persistence;
using HRLeaveManagement.Application.Persistence.Contracts;
using HRLeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HRLeaveManagement.Application.Contracts.Persistence
{
    public interface ILeaveRequestRepository : IGenericRepository<ILeaveRequestDto>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetails(int id);
        Task<List<LeaveRequest>> GetLeaveRequestListWithDetails();
    }
}
