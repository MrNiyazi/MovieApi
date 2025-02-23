using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.CQRSDesingPattern.Handlers.CategoryHandlers;

namespace MovieApi.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriesController : ControllerBase
	{
		private readonly GetCategoryQueryHandler _getCategoryQueryHandler;
		private readonly GetCategoryByIdQueryHandler _getCategoryByIdQueryHandler;
		private readonly CreateCategoryCommandHandler _createCategoryCommandHandler;
		private readonly UpdateCategoryCommandHandler _updateCategoryCommandHandler;
		private readonly RemoveCategoryCommandHandler _removeCategoryCommandHandler;

		public CategoriesController(GetCategoryQueryHandler getCategoryQueryHandler, GetCategoryByIdQueryHandler getCategoryByIdQueryHandler, CreateCategoryCommandHandler createCategoryCommandHandler, UpdateCategoryCommandHandler updateCategoryCommandHandler, RemoveCategoryCommandHandler removeCategoryCommandHandler)
		{
			_getCategoryQueryHandler = getCategoryQueryHandler;
			_getCategoryByIdQueryHandler = getCategoryByIdQueryHandler;
			_createCategoryCommandHandler = createCategoryCommandHandler;
			_updateCategoryCommandHandler = updateCategoryCommandHandler;
			_removeCategoryCommandHandler = removeCategoryCommandHandler;
		}

		[HttpGet]
		public async Task<IActionResult> CategoryList()
		{
			var value = await _getCategoryQueryHandler.Handle();
			return Ok(value);
		}
	}
}
