using Application.Features.Feedbacks.Commands.Create;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly IMediator _mediator;

		public UsersController(IMediator mediator)
		{
			_mediator = mediator;
		}

		//[HttpPost]
		//public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
		//{
		//	CreateUserResponse response = await _mediator.Send(command);
		//	return Ok(response);
		//}
	}
}
