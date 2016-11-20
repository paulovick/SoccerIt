using SoccerIt.User.Domain.Entities;
using SoccerIt.User.WebApi.Dto;

namespace SoccerIt.User.WebApi.Mappers.Contracts
{
	public interface IUserMapper
	{
		UserEntity Convert(UserRequest source);
	}
}
