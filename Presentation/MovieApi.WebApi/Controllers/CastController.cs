using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

		public IActionResult CastList() 
		{
			
		}
	}
}
