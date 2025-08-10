using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.CQRSDesingPattern.Commands.UserRegisterCommands;
using MovieApi.Application.Features.CQRSDesingPattern.Handlers.UserRegisterHandlers;

namespace MovieApi.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RegistersController : ControllerBase
	{
		private readonly CreateUserRegisterCommandHandler _userRegisterCommandHandler;

		public RegistersController(CreateUserRegisterCommandHandler userRegisterCommandHandler)
		{
			_userRegisterCommandHandler = userRegisterCommandHandler;
		}

		[HttpPost]
		public async Task<IActionResult> CreateUserRegister(CreateUserRegisterCommand command)
		{
			await _userRegisterCommandHandler.Handle(command);
			return Ok("Kullanıcı başarı ile eklendi");
		}
	}
}
