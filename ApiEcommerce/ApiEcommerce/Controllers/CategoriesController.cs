using ApiEcommerce.Models.Dtos;
using ApiEcommerce.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace ApiEcommerce.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CategoriesController : ControllerBase
  {
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoriesController(ICategoryRepository categoryRepository, IMapper mapper)
    {
      _categoryRepository = categoryRepository;
      _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult GetCateogies()
    {
      var categories = _categoryRepository.GetCategories();

      var categoriesDto = new List<CategoryDto>();

      foreach (var category in categories)
      {
        categoriesDto.Add(_mapper.Map<CategoryDto>(category));
      }

      return Ok(categoriesDto);
    }

    [HttpGet("{id:int}", Name = "GetCategory")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetCategory(int id)
    {
      var category = _categoryRepository.GetCategory(id);

      if (category == null)
      {
        return NotFound($"La categoría por el id {id} no existe.");
      }

      var categoryDto = _mapper.Map<CategoryDto>(category);

      return Ok(categoryDto);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public IActionResult CreateCategory([FromBody] CreateCategoryDto createCategoryDto)
    {

      if (createCategoryDto == null)
      {
        return BadRequest(ModelState);
      }

      if (_categoryRepository.CategoryExists(createCategoryDto.name))
      {
        ModelState.AddModelError("CustomError", "La categoría ya existe.");
        return BadRequest(ModelState);
      }

      var category = _mapper.Map<Category>(createCategoryDto);

      if (!_categoryRepository.CreateCategory(category))
      {
        ModelState.AddModelError("CustomError", $"Algo salió mal al guardar el registro {category.name}");
        return StatusCode(500, ModelState);
      }

      return CreatedAtRoute("GetCategory", new { id = category.Id }, category);
    }

    [HttpPatch("{id}:int", Name = "UpdateCategory")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public IActionResult UpdateCategory(int id, [FromBody] CreateCategoryDto updateCategoryDto)
    {

      if (!_categoryRepository.CategoryExists(id))
      {
        return NotFound($"La categoría por el id {id} no existe.");
      }

      if (updateCategoryDto == null)
      {
        return BadRequest(ModelState);
      }

      if (_categoryRepository.CategoryExists(updateCategoryDto.name))
      {
        ModelState.AddModelError("CustomError", "La categoría ya existe.");
        return BadRequest(ModelState);
      }

      var category = _mapper.Map<Category>(updateCategoryDto);
      category.Id = id;

      if (!_categoryRepository.UpdateCategory(category))
      {
        ModelState.AddModelError("CustomError", $"Algo salió mal al actualizar el registro {category.name}");
        return StatusCode(500, ModelState);
      }

      return NoContent();
    }

    [HttpDelete("{id}:int", Name = "DeleteCategory")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public IActionResult DeleteCategory(int id)
    {

      if (!_categoryRepository.CategoryExists(id))
      {
        return NotFound($"La categoría por el id {id} no existe.");
      }

      var category = _categoryRepository.GetCategory(id);

      if (category == null)
      {
        return NotFound($"La categoría por el id {id} no existe.");
      }

      if (!_categoryRepository.DeleteCategory(category))
      {
        ModelState.AddModelError("CustomError", $"Algo salió mal al eliminar el registro {category.name}");
        return StatusCode(500, ModelState);
      }

      return NoContent();
    }


  }
}
