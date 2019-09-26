using System.Text;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Storage;

namespace ef_core_json_provider
{
  internal class JsonSqlGenerationHelper : RelationalSqlGenerationHelper, IJsonSqlGenerationHelper
  {
    public JsonSqlGenerationHelper([NotNullAttribute] RelationalSqlGenerationHelperDependencies dependencies) : base(dependencies)
    {
    }

    public override string StatementTerminator => base.StatementTerminator;

    public override string BatchTerminator => base.BatchTerminator;

    public override string SingleLineCommentToken => base.SingleLineCommentToken;

    public override string DelimitIdentifier(string identifier)
    {
      return base.DelimitIdentifier(identifier);
    }

    public override void DelimitIdentifier(StringBuilder builder, string identifier)
    {
      base.DelimitIdentifier(builder, identifier);
    }

    public override string DelimitIdentifier(string name, string schema)
    {
      return base.DelimitIdentifier(name, schema);
    }

    public override void DelimitIdentifier(StringBuilder builder, string name, string schema)
    {
      base.DelimitIdentifier(builder, name, schema);
    }

    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }

    public override string EscapeIdentifier(string identifier)
    {
      return base.EscapeIdentifier(identifier);
    }

    public override void EscapeIdentifier(StringBuilder builder, string identifier)
    {
      base.EscapeIdentifier(builder, identifier);
    }

    public override string GenerateComment(string text)
    {
      return base.GenerateComment(text);
    }

    public override string GenerateParameterName(string name)
    {
      return base.GenerateParameterName(name);
    }

    public override void GenerateParameterName(StringBuilder builder, string name)
    {
      base.GenerateParameterName(builder, name);
    }

    public override string GenerateParameterNamePlaceholder(string name)
    {
      return base.GenerateParameterNamePlaceholder(name);
    }

    public override void GenerateParameterNamePlaceholder(StringBuilder builder, string name)
    {
      base.GenerateParameterNamePlaceholder(builder, name);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public override string ToString()
    {
      return base.ToString();
    }
  }
}
