using AutoMapper;

namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles.EmployeeRole
{
    public class EmployeeRoleProfile : Profile
    {
        public EmployeeRoleProfile()
        {
            CreateMap<DTOs.EmployeeRole.EmployeeRoleDto, Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>()
                .ForCtorParam("roleName", opt => opt.MapFrom(src => src.Cargo));


            CreateMap<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, DTOs.EmployeeRole.EmployeeRoleDto>()
                .ForMember
        }
    }
}
