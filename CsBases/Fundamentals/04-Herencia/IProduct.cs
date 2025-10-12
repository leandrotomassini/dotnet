using System;

namespace CsBases.Fundamentals;

public interface IProduct
{
  public void ApplyDiscount(decimal percentage);

  string GetDescription();
}
