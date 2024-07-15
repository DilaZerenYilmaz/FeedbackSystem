using Application.Features.Feedbacks.Commands.Create;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Feedbacks.Profiles
{
	public class FeedbackMappingProfile : Profile
	{
		public FeedbackMappingProfile() 
		{
			CreateMap<Feedback, CreateFeedbackCommand>().ReverseMap();
			CreateMap<Feedback, CreateFeedbackResponse>().ReverseMap();
		}
	}
}
