﻿using MediatR;
using MovieApi.Application.Features.MediatorDesingPattern.Commands.TagCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesingPattern.Handlers.TagHandlers
{
	public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand>
	{
		private readonly MovieContext _movieContext;

		public CreateTagCommandHandler(MovieContext movieContext)
		{
			_movieContext = movieContext;
		}

		public async Task Handle(CreateTagCommand request, CancellationToken cancellationToken)
		{
			_movieContext.Tags.Add(new Tag
			{
				Title = request.Title,
			});
			await _movieContext.SaveChangesAsync();
		}
	}
}
