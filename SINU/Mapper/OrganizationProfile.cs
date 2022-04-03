using AutoMapper;
using SINU.DTO;
using SINU.Model;

namespace SINU.Mapper
{
	public class OrganizationProfile : Profile
	{
		public OrganizationProfile()
		{
			CreateMap<UserInsertDTO, User>();
			CreateMap<User, UserInsertDTO>();
			CreateMap<User, UserInfoDTO>();
		}
	}
}
