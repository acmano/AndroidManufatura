using System;

namespace Comum
{
  public class AcessoSql
  {
    public enum AcessoTipo
    {
      Desenvolvimento
    , Producao
    }

    public string OpenQuery { get; }

    public string Server { get; }

    public string UserName { get; }

    public string Password { get; }

    public AcessoSql(AcessoTipo acessoTipo)
    {
      if (acessoTipo == AcessoTipo.Desenvolvimento)
      {
        OpenQuery = BancoSqlDesenv.OpenQuery;
        Server = BancoSqlDesenv.Server;
        UserName = BancoSqlDesenv.Username;
        Password = BancoSqlDesenv.Password;
      }
      else if (acessoTipo == AcessoTipo.Producao)
      {
        OpenQuery = BancoSqlProd.OpenQuery;
        Server = BancoSqlProd.Server;
        UserName = BancoSqlProd.Username;
        Password = BancoSqlProd.Password;
      }
    }
  }
}
