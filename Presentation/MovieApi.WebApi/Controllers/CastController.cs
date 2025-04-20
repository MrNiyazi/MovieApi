using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.MediatorDesingPattern.Commands.CastCommands;
using MovieApi.Application.Features.MediatorDesingPattern.Queries.CastQueries;

namespace MovieApi.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CastController : ControllerBase
	{
		private readonly IMediator _mediator;

		public CastController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> CastList() 
		{
			var value = await _mediator.Send(new GetCastQuery());
			return Ok(value);
		}

		[HttpPost]
		public async Task<IActionResult> CreateCast(CreateCastCommand command) 
		{
			await _mediator.Send(command);
			return Ok("Ekleme işlemi başarılı");
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteCast(int id) 
		{
			await _mediator.Send(new RemoveCastCommand());
			return Ok("Silme işlemi başarılır");
		}

		[HttpGet("GetCastById")]
		public async Task<IActionResult> GetCastById(int id) 
		{
			var value = await _mediator.Send(new GetCastByIdQuery(id));
			return Ok(value);
		}

		[HttpPut]
		public async Task<IActionResult> UpdateCast(UpdateCastCommand command) 
		{
			await _mediator.Send(command);
			return Ok("Güncelleme işlemi başarılı");
		}
	}
}
