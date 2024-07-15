using Application.Features.Auth.Commands.Register;
using Application.Features.Feedbacks.Commands.Create;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IMediator _mediator;

		public AuthController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpPost("Register")]
		public async Task<IActionResult> Register([FromBody] RegisterCommand command)
		{
			await _mediator.Send(command);
			return Created();
		}
	}
}
