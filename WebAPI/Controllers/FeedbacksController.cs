using Application.Features.Feedbacks.Commands.Create;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FeedbacksController : ControllerBase
	{
		private readonly IMediator _mediator;

		public FeedbacksController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpPost]
		public async Task<IActionResult> CreateFeedback([FromBody]CreateFeedbackCommand command)
		{
			CreateFeedbackResponse response = await _mediator.Send(command);
			return Ok(response);
		}
	}
}
