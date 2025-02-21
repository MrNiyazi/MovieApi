using MovieApi.Application.Features.CQRSDesingPattern.Results.MovieResult;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesingPattern.Handlers.MovieHandlers
{
	public class GetMovieQueryMovieHandler
	{
		private readonly MovieContext _context;

		public GetMovieQueryMovieHandler(MovieContext context)
		{
			_context = context;
		}
		public async Task<List<GetMovieQueryMovieHandler>> Handle()
		{
			var values = await _context.Movies.ToListAsync();
			return values.Select(x=>new GetMovieByIdQueryResult
			{
				MovieId = x.MovieId,
				CoverImgUrl = x.CoverImgUrl,
				CreatedYear = x.CreatedYear,
				Description = x.Description,
				Duration = x.Duration,
				Rating = x.Rating,
				ReleaseDate = x.ReleaseDate,
			}).ToList();
		}
	}
}
