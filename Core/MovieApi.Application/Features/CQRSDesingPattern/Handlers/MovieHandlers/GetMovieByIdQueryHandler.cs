﻿using MovieApi.Application.Features.CQRSDesingPattern.Queries.MovieQueries;
using MovieApi.Application.Features.CQRSDesingPattern.Results.MovieResult;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesingPattern.Handlers.MovieHandlers
{
	public class GetMovieByIdQueryHandler
	{
		private readonly MovieContext _context;

		public GetMovieByIdQueryHandler(MovieContext context)
		{
			_context = context;
		}

		public async Task<GetMovieByIdQueryResult> Handle(GetMovieByIdQuery query)
		{
			var value = await _context.Movies.FindAsync(query.MovieId);
			return new GetMovieByIdQueryResult
			{
				MovieId = value.MovieId,
				CoverImgUrl = value.CoverImgUrl,
				CreatedYear = value.CreatedYear,
				Description = value.Description,
				Duration = value.Duration,
				Rating = value.Rating,
				ReleaseDate = value.ReleaseDate,
				Status = value.Status,
				Title = value.Title,
			};
		}
	}
}
