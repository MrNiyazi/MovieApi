﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesingPattern.Queries.MovieQueries
{
	public class GetMovieByIdQuery
	{
		public int MovieId { get; set; }
		public GetMovieByIdQuery(int movieId)
		{
			MovieId = movieId;
		}


		
	}
}
