using Avanade.SubTCSE.Projeto.Application.DTOs.EmployeeRole;
using Avanade.SubTCSE.Projeto.Application.Interfaces.EmployeeRole;
using System;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.Services.EmployeeRole
{
    public class EmployeeRoleService : IEmployeeRoleAppServie
    {

        Task<EmployeeRoleDTO> IEmployeeRoleAppServie.AddEmployeeRole(EmployeeRoleDto employeeRoleDto)
        {
            throw new NotImplementedException();
        }
    }
}
