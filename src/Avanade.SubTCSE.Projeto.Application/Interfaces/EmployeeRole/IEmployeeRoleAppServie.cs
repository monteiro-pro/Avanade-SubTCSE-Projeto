using Avanade.SubTCSE.Projeto.Application.DTOs.EmployeeRole;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.Interfaces.EmployeeRole
{
    public interface IEmployeeRoleAppServie
    {
        Task<EmployeeRoleDTO> AddEmployeeRole(EmployeeRoleDto employeeRoleDto);
    }
}
