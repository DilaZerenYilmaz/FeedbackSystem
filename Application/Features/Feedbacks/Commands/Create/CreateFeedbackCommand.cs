using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Feedbacks.Commands.Create
{
	public class CreateFeedbackCommand : IRequest<CreateFeedbackResponse>
	{
		public string Description { get; set; }
		public int UserId { get; set; }

		public class CreateFeedbackCommandHandler : IRequestHandler<CreateFeedbackCommand, CreateFeedbackResponse>
		{
			private readonly IFeedbackRepository _feedbackRepository;
			private readonly IMediator _mediator;
			private readonly IMapper _mapper;
			public CreateFeedbackCommandHandler(IFeedbackRepository feedbackRepository, IMediator mediator, IMapper mapper)
			{
				_feedbackRepository = feedbackRepository;
				_mediator = mediator;
				_mapper = mapper;
			}

			public async Task<CreateFeedbackResponse> Handle(CreateFeedbackCommand request, CancellationToken cancellationToken)
			{
				
					Feedback feedback = _mapper.Map<Feedback>(request);
					await _feedbackRepository.AddAsync(feedback);

					CreateFeedbackResponse response = _mapper.Map<CreateFeedbackResponse>(feedback);
					return response;
				
			}
		}
	}
}
