using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.FeedbackService
{
	public class FeedbackManager : IFeedbackService
	{
		private readonly IFeedbackRepository _feedbackRepository;

		public FeedbackManager(IFeedbackRepository feedbackRepository)
		{
			_feedbackRepository = feedbackRepository;
		}

		public async Task<bool> FeedbackValidationById(int id)
		{
			Feedback? feedback = await _feedbackRepository.GetAsync(x => x.Id == id);
			if (feedback == null)
			{
				return true;
			}
			return false;
		}
	}
}
