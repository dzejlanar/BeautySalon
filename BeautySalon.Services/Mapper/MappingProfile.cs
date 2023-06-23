using AutoMapper;
using BeautySalon.Model.Requests;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Database;

namespace BeautySalon.Services.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<ServiceCategory, ServiceCategoryVM>();
            CreateMap<ServiceCategoryUpsertRequest, ServiceCategory>();

            CreateMap<Service, ServiceVM>();
            CreateMap<ServiceUpsertRequest, Service>();

            CreateMap<User, UserVM>();
            CreateMap<UserInsertRequest, User>();
            CreateMap<UserUpdateRequest, User>();

            CreateMap<UserRole, UserRoleVM>();

            CreateMap<Role, RoleVM>();
        }
    }
}
