﻿using Application.Repositories;
using AutoMapper;
using Core.Hashing;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auth.Commands.Register
{
	public class RegisterCommand : IRequest
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
        public string UserName { get; set; }

        public class RegisterCommandHandler : IRequestHandler<RegisterCommand> 
		{
			private readonly IMapper _mapper;
			private readonly IUserRepository _userRepository;

			public RegisterCommandHandler(IMapper mapper, IUserRepository userRepository)
			{
				_mapper = mapper;
				_userRepository = userRepository;
			}

			public async Task Handle(RegisterCommand request, CancellationToken cancellationToken)
			{
				User user = _mapper.Map<User>(request);

				byte[] passwordHash, passwordSalt;
				HashingHelper.CreatePasswordHash(request.Password, out passwordHash, out passwordSalt);

				user.PasswordHash = passwordHash;
				user.PasswordSalt = passwordSalt;

				await _userRepository.AddAsync(user);
			}
		}
	}
}
