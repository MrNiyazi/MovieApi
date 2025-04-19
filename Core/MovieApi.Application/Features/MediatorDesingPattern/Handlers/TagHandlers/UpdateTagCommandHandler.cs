using MovieApi.Application.Features.MediatorDesingPattern.Commands.TagCommands;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesingPattern.Handlers.TagHandlers
{
	public class UpdateTagCommandHandler
	{
		private readonly MovieContext _context;

		public UpdateTagCommandHandler(MovieContext context)
		{
			_context = context;
		}

		public async Task Handle(UpdateTagCommand request, CancellationToken cancellationToken)
		{
			var value = await _context.Tags.FindAsync(request.TagId);
			value.Title = request.Title;
			await _context.SaveChangesAsync();
		}
	}
}
