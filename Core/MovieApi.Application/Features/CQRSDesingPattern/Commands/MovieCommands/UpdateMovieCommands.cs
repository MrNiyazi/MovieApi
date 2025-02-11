﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesingPattern.Commands.MovieCommands
{
	public class UpdateMovieCommands
	{
		public int MovieId { get; set; }
		public string Title { get; set; }
		public string CoverImgUrl { get; set; }
		public decimal Rating { get; set; }
		public string Description { get; set; }
		public int Duration { get; set; }
		public DateTime ReleaseDate { get; set; }
		public string CreatedYear { get; set; }
		public bool Status { get; set; }
	}
}
