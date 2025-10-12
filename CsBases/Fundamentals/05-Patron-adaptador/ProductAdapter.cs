using System;

namespace CsBases.Fundamentals._05_Patron_adaptador;

public class ProductAdapter
{
  public static ProductDto ToDto(Product product)
  {
    return new ProductDto
    {
      Name = product.Name ?? "Sin nombre",
      Price = product.Price,
      Code = $"P-{product.Id}-{product.UniqueCode.ToString().Substring(0, 8)}"
    };
  }
}
