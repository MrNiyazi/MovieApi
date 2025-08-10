﻿using Microsoft.AspNetCore.Identity;
using MovieApi.Application.Features.CQRSDesingPattern.Commands.UserRegisterCommands;
using MovieApi.Persistence.Context;
using MovieApi.Persistence.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesingPattern.Handlers.UserRegisterHandlers
{
	public class CreateUserRegisterCommandHandler
	{
		private readonly MovieContext _movieContext;
		private readonly UserManager<AppUser> _userManager;
		public CreateUserRegisterCommandHandler(MovieContext movieContext, UserManager<AppUser> userManager)
		{
			_movieContext = movieContext;
			_userManager = userManager;
		}

		public async Task Handle(CreateUserRegisterCommand command)
		{
			var user = new AppUser()
			{
				Name = command.Name,
				Surname = command.Surname,
				Email = command.Email,
				UserName = command.UserName,
			};
			await _userManager.CreateAsync(user, command.Password);
		}
	}
}
