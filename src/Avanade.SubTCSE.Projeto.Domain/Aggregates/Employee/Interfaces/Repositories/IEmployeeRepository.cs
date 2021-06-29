using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Interfaces.Repositories
{
    public interface IEmployeeRepository
    {
        Task<Entities.Employee> AddEmployeeRole(Entities.Employee employee);
    }
}
