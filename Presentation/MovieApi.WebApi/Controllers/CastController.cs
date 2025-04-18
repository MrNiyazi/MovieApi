﻿using MediatR;
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
		public IActionResult CastList() 
		{
			var value = _mediator.Send(new GetCastQuery());
			return Ok(value);
		}

		[HttpPost]
		public IActionResult CreateCast(CreateCastCommand command) 
		{
			_mediator.Send(command);
			return Ok("Ekleme işlemi başarılı");
		}

		[HttpDelete]
		public IActionResult DeleteCast(int id) 
		{
			_mediator.Send(new RemoveCastCommand());
			return Ok("Silme işlemi başarılır");
		}

		[HttpGet("GetCastById")]
		public IActionResult GetCastById(int id) 
		{
			var value = _mediator.Send(new GetCastByIdQuery(id));
			return Ok(value);
		}

		[HttpPut]
		public IActionResult UpdateCast(UpdateCastCommand command) 
		{
			_mediator.Send(command);
			return Ok("Güncelleme işlemi başarılı");
		}
	}
}
