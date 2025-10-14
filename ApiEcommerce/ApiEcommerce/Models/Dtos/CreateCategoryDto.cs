using System;
using System.ComponentModel.DataAnnotations;

namespace ApiEcommerce.Models.Dtos;

public class CreateCategoryDto
{
  [Required(ErrorMessage = "El nombre de la categoría es requerido.")]
  [MaxLength(50, ErrorMessage = "El nombre de la categoría no puede tener mas de 50 caracteres.")]
  [MinLength(3, ErrorMessage = "El nombre de la categoría no puede tener menos de 3 caracteres.")]
  public string name { get; set; } = string.Empty;

}
