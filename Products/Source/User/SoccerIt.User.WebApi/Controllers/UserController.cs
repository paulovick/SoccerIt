using Microsoft.AspNetCore.Mvc;
using SoccerIt.User.WebApi.Dto;
using SoccerIt.User.WebApi.Mappers.Contracts;
using SoccerIt.User.WebApi.Mappers.Implementations;
using SoccerIt.User.ServiceLibrary.Services.Contracts;
using SoccerIt.User.ServiceLibrary.Services.Implementations;
using Newtonsoft.Json;

namespace SoccerIt.User.WebApi.Controllers
{
	[Route("api/[controller]")]
	public class UserController : Controller
	{
		private IUserMapper iUserMapper;
		private IUserAppService iUserAppService;

		public UserController()
		{
			this.iUserMapper = new UserMapper();
			this.iUserAppService = new UserAppService();
		}

		[HttpGet]
		public IActionResult GetAll()
		{
			var result = this.iUserAppService.GetAll();
			return Ok(result);
		}

		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			var result = this.iUserAppService.GetById(id);
			return Ok(result);
		}

		[HttpPost]
		public IActionResult Post([FromBody]UserRequest request)
		{
			var user = this.iUserMapper.Convert(request);
			var result = this.iUserAppService.Create(user);
			if (result == false)
			{
				return this.BadRequest();
			}

			return Ok();
		}

		[HttpPut]
		public IActionResult Put([FromBody]UserRequest request)
		{
			var user = this.iUserMapper.Convert(request);
			var result = this.iUserAppService.Update(user);
			if (result == false)
			{
				return this.BadRequest();
			}

			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var result = this.iUserAppService.Delete(id);
			if (result == false)
			{
				return this.BadRequest();
			}

			return Ok();
		}
	}
}
