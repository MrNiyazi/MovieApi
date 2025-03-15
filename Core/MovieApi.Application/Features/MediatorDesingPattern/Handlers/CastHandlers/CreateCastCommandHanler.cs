using MediatR;
using MovieApi.Application.Features.MediatorDesingPattern.Commands.CastCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesingPattern.Handlers.CastHandlers
{
	public class CreateCastCommandHanler : IRequestHandler<CreateCastCommand>
	{
		private readonly MovieContext _context;
		public CreateCastCommandHanler(MovieContext context) 
		{
			_context = context;
		}
		public async Task Handle(CreateCastCommand request, CancellationToken cancellationToken)
		{
			_context.Casts.Add(new Cast
			{
				Biography = request.Biography,
				ImageUrl = request.ImageUrl,
				Name = request.Name,
				Overview = request.Overview,
				Suname = request.Suname,
				Title = request.Title,
			});
			await _context.SaveChangesAsync();
		}
	}
}
