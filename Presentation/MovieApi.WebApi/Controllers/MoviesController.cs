using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.CQRSDesingPattern.Commands.MovieCommands;
using MovieApi.Application.Features.CQRSDesingPattern.Handlers.MovieHandlers;
using MovieApi.Application.Features.CQRSDesingPattern.Queries.MovieQueries;

namespace MovieApi.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MoviesController : ControllerBase
	{
		private readonly GetMovieByIdQuery _getMovieByIdQuery;
		private readonly GetMovieQueryMovieHandler _getMovieQueryMovieHandler;
		private readonly GetMovieByIdQueryHandler _getMovieByIdQueryHandler;
		public readonly CreateMovieCommandHandler _createMovieCommandHandler;
		public readonly UpdateMovieCommandHandler _updateMovieCommandHandler;
		public readonly RemoveMovieCommandHandler _removeMovieCommandHandler;

		public MoviesController(GetMovieByIdQuery getMovieByIdQuery, GetMovieQueryMovieHandler getMovieQueryMovieHandler, GetMovieByIdQueryHandler getMovieByIdQueryHandler, CreateMovieCommandHandler createMovieCommandHandler, UpdateMovieCommandHandler updateMovieCommandHandler, RemoveMovieCommandHandler removeMovieCommandHandler)
		{
			_getMovieByIdQuery = getMovieByIdQuery;
			_getMovieQueryMovieHandler = getMovieQueryMovieHandler;
			_getMovieByIdQueryHandler = getMovieByIdQueryHandler;
			_createMovieCommandHandler = createMovieCommandHandler;
			_updateMovieCommandHandler = updateMovieCommandHandler;
			_removeMovieCommandHandler = removeMovieCommandHandler;
		}

		[HttpGet]
		public async Task<IActionResult> MovieList()
		{
			var value = await _getMovieQueryMovieHandler.Handle();
			return Ok(value);
		}
		[HttpPost]

		public async Task<IActionResult> CreateMovie(CreateMovieCommands commands)
		{
			await _createMovieCommandHandler.Handler(commands);
			return Ok("Film Ekleme İşlemi başarılı");
		}
		[HttpDelete]
		public async Task<IActionResult> DeleteMovie(int id)
		{
			await _removeMovieCommandHandler.Handle(new RemovaMovieCommands(id));
			return Ok("Film Silme İşlemi başarılı");
		}
		[HttpGet("GetMovie")]
		public async Task<IActionResult> GetMovie(int id)
		{
			var value = await _getMovieByIdQueryHandler.Handle(new GetMovieByIdQuery(id));
			return Ok(value);
		}

		[HttpPut]
		public async Task<IActionResult> UpdateMovie(UpdateMovieCommands commands)
		{
			await _updateMovieCommandHandler.Handle(commands);
			return Ok("Film güncelleme işlemi başarılı");
		}
	}
}
