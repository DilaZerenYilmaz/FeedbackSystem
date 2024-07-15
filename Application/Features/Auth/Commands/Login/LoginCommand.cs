using Application.Features.Auth.Constants;
using Application.Repositories;
using Core.Hashing;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auth.Commands.Login
{
	public class LoginCommand : IRequest
	{
		public string Email { get; set; }
		public string Password { get; set; }

		public class LoginCommandHandler : IRequestHandler<LoginCommand>
		{
			private readonly IUserRepository _userRepository;
			public LoginCommandHandler(IUserRepository userRepository)
			{
				_userRepository = userRepository;
			}

			public async Task Handle(LoginCommand request, CancellationToken cancellationToken)
			{
				User? user = await _userRepository.GetAsync(x=> x.Email ==  request.Email);

				if (user == null)
				{
					throw new Exception(AuthMessages.AuthFailed);
				}

				bool isPasswordMatch = HashingHelper.VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt);
				if (!isPasswordMatch)
				{
					throw new Exception(AuthMessages.AuthFailed);
				}
			}
		}
	}
}
