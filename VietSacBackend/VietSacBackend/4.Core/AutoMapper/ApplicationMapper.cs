using AutoMapper;
using VietSacBackend._3.Repository.Data;
using VietSacBackend._4.Core.Model.Auth;
using VietSacBackend._4.Core.Model.Product;
using VietSacBackend._4.Core.Model.Role;
using VietSacBackend._4.Core.Model.User;

namespace VietSacBackend._4.Core.AutoMapper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            //Role
            CreateMap<RoleEntity, RequestRoleModel>().ReverseMap();
            CreateMap<RoleEntity, ResponseRoleModel>().ReverseMap();

            //User
            CreateMap<UserEntity, RequestUserModel>().ReverseMap();
            CreateMap<UserEntity, ResponseUserModel>().ReverseMap();

            //User Auth
            CreateMap<UserEntity, SignUpModel>().ReverseMap();
            CreateMap<UserEntity, SignInModel>().ReverseMap();
        }
    }
}
