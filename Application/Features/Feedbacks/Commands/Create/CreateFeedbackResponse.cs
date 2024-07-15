using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Feedbacks.Commands.Create
{
	public class CreateFeedbackResponse
	{
		public string Description { get; set; }
		public int UserId { get; set; }
	}
}
