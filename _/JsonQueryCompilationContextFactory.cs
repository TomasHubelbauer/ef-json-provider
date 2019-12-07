using Microsoft.EntityFrameworkCore.Query;

namespace ef_core_json_provider
{
  internal class JsonQueryCompilationContextFactory : IQueryCompilationContextFactory
  {
    public JsonQueryCompilationContextFactory()
    {
    }

    public QueryCompilationContext Create(bool async)
    {
      throw new System.NotImplementedException();
    }
  }
}
