﻿using MovieApi.Application.Features.CQRSDesingPattern.Commands.MovieCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesingPattern.Handlers.MovieHandlers
{
	public class CreateMovieCommandHandler
	{
		private readonly MovieContext _context;

		public CreateMovieCommandHandler(MovieContext context) { _context = context; }

		public async Task Handler(CreateMovieCommands command)
		{
			_context.Movies.Add(new Movie
			{
				Title = command.Title,
				CoverImgUrl = command.CoverImgUrl,
				CreatedYear = command.CreatedYear,
				Description = command.Description,
				Duration = command.Duration,
				Rating = command.Rating,
				ReleaseDate = command.ReleaseDate,
				Status = command.Status,
				
			});
			await _context.SaveChangesAsync();
		}
	}
}
