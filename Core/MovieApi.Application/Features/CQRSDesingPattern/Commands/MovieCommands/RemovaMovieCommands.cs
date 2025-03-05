using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesingPattern.Commands.MovieCommands
{
	public class RemovaMovieCommands
	{
		public RemovaMovieCommands(int movieId)
		{
			MovieId = movieId;
		}

		public int MovieId { get; set; }
	}
}
