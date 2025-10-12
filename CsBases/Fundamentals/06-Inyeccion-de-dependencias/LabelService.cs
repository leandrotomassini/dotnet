using System;

namespace CsBases.Fundamentals._06_Inyeccion_de_dependencias;

public class LabelService : ILabelService
{
  public string GenerateLabel(Product product)
  {
    return $"{product.Name} - Precio: {product.Price} - Código: {product.GetType().Name} - {product.GetHashCode()}";
  }
}
