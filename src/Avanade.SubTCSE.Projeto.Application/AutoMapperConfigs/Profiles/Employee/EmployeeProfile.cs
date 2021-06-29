using AutoMapper;

namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles.Employee
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<DTOs.Employee.EmployeeDTO, Domain.Aggregates.Employee.Entities.Employee>()
                .ConstructUsing((ctor, res) =>
                {
                    return new Domain.Aggregates.Employee.Entities.Employee(
                        firstName: ctor.PrimeiroNome,
                        surName: ctor.Sobrenome,
                        birthday: ctor.Aniversario,
                        ctor.Ativo,
                        ctor.Salario,
                        employeeRole: res.Mapper.Map<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>(ctor.Cargo));
                })
                .ForAllOtherMembers(i => i.Ignore());

            CreateMap<Domain.Aggregates.Employee.Entities.Employee, DTOs.Employee.EmployeeDTO>()
                .ForMember(dest => dest.Identificador, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.PrimeiroNome, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.Sobrenome, opt => opt.MapFrom(src => src.SurName))
                .ForMember(dest => dest.Aniversario, opt => opt.MapFrom(src => src.Birthday))
                .ForMember(dest => dest.Ativo, opt => opt.MapFrom(src => src.Active))
                .ForMember(dest => dest.Salario, opt => opt.MapFrom(src => src.Salary))
                .ForMember(dest => dest.Cargo, opt => opt.MapFrom(src => src.EmployeeRole))
                .ForAllOtherMembers(i => i.Ignore());
        }
    }
}
