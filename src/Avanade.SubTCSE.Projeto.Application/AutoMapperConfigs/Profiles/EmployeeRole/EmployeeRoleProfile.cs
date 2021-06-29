using AutoMapper;

namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles.EmployeeRole
{
    public class EmployeeRoleProfile : Profile
    {
        public EmployeeRoleProfile()
        {
            CreateMap<DTOs.EmployeeRole.EmployeeRoleDTO, Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>()
                .ForCtorParam("roleName", opt => opt.MapFrom(src => src.Cargo));


            CreateMap<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, DTOs.EmployeeRole.EmployeeRoleDTO>()
                .ForMember(dest => dest.Identificador, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Cargo, opt => opt.MapFrom(src => src.RoleName))
                .ForAllOtherMembers(I => I.Ignore());
        }
    }
}
