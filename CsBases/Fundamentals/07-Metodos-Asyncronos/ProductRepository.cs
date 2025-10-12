using System;

namespace CsBases.Fundamentals._07_Metodos_Asyncronos;

public class ProductRepository
{
  public async Task<Product> GetProduct(int id)
  {

    // Obtener de una base de datos
    WriteLine("Buscando producto...");
    await Task.Delay(2000);
    return new Product("Producto simulado", 400);
  }
}
