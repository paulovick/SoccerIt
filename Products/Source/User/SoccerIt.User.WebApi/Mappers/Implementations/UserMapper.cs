using System;
using SoccerIt.User.Domain.Entities;
using SoccerIt.User.WebApi.Dto;
using SoccerIt.User.WebApi.Mappers.Contracts;

namespace SoccerIt.User.WebApi.Mappers.Implementations
{
	public class UserMapper : IUserMapper
	{
		public UserEntity Convert(UserRequest source)
		{
			var result = new UserEntity
			{
				Id = source.Id,
				Username = source.Username,
				Email = source.Email,
				Password = source.Password,
				IsAdmin = source.IsAdmin
			};

			return result;
		}
	}
}
