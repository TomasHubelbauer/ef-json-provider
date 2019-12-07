using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ef_core_json_provider
{
  class JsonOptions : IJsonOptions
  {
    public void Initialize(IDbContextOptions options)
    {
      throw new System.NotImplementedException();
    }

    public void Validate(IDbContextOptions options)
    {
      throw new System.NotImplementedException();
    }
  }
}
