using MovieApi.Application.Features.CQRSDesingPattern.Commands.MovieCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesingPattern.Handlers.MovieHandlers
{
	public class UpdateMovieCommandHandler
	{
		private readonly MovieContext _context;

		public UpdateMovieCommandHandler(MovieContext context) {  _context = context; }

		public async void Handle(UpdateMovieCommands command)
		{
			var value = await _context.Movies.FindAsync(command.MovieId);
			value.CoverImgUrl = command.CoverImgUrl;
			value.CreatedYear = command.CreatedYear;
			value.Description = command.Description;
			value.Duration = command.Duration;
			value.ReleaseDate = command.ReleaseDate;
			value.Rating = command.Rating;
			value.Title = command.Title;
			value.Status = command.Status;
			await _context.SaveChangesAsync();
		}
		
	}
}
