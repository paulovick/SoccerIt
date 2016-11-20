using System;
using Microsoft.AspNetCore.Mvc;
using SoccerIt.User.WebApi.Dto;

namespace SoccerIt.User.WebApi.Controllers
{
	[Route("api/[controller]")]
	public class UserController : Controller
	{
		[HttpGet]
		public IActionResult GetAll()
		{
			return this.Ok("GetAll");
		}

		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			return this.Ok("GetById: " + id);
		}

		[HttpPost]
		public IActionResult Post([FromBody]UserModel request)
		{
			return this.Ok("Post: " + request.Id);
		}

		[HttpPut]
		public IActionResult Put([FromBody]UserModel request)
		{
			return this.Ok("Put: " + request.Id);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			return this.Ok("Delete: " + id);
		}
	}
}
