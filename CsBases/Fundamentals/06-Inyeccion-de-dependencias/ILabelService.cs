using System;

namespace CsBases.Fundamentals._06_Inyeccion_de_dependencias;

public interface ILabelService
{
  string GenerateLabel(Product product);
}
