﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Item {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str, ou recrie o projeto do VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Sql {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Sql() {
        }
        
        /// <summary>
        ///   Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Item.Sql", typeof(Sql).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas as
        ///   pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a DELETE
        ///  FROM OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  lor_man_item.num_serie_lmi
        ///        FROM  lor_man_item
        ///        WHERE lor_man_item.num_serie_lmi = {1}
        ///    &apos;
        ///  ).
        /// </summary>
        internal static string DeleteRecord {
            get {
                return ResourceManager.GetString("DeleteRecord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT  tabela.existe
        ///  FROM  OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  DISTINCT 1 AS existe
        ///        FROM  lor_man_item
        ///        WHERE lor_man_item.cod_item = &quot;{1}&quot;
        ///    &apos;
        ///  ) AS tabela.
        /// </summary>
        internal static string ExisteAk {
            get {
                return ResourceManager.GetString("ExisteAk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT  tabela.existe
        ///  FROM  OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  DISTINCT 1 AS existe
        ///        FROM  lor_man_item_empresa
        ///        WHERE lor_man_item_empresa.num_serie_lmi = {1}
        ///  &apos;
        ///  ) AS tabela.
        /// </summary>
        internal static string ExisteDependencias {
            get {
                return ResourceManager.GetString("ExisteDependencias", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT  tabela.existe
        ///  FROM  OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  DISTINCT 1 AS existe
        ///        FROM  lor_man_item
        ///        WHERE lor_man_item.num_serie_lmi = {1}
        ///  &apos;
        ///  ) AS tabela.
        /// </summary>
        internal static string ExistePk {
            get {
                return ResourceManager.GetString("ExistePk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a INSERT
        ///  INTO OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  lor_man_item.cod_item
        ///           ,  lor_man_item.den_item
        ///        FROM  lor_man_item
        ///    &apos;
        ///  )
        ///  VALUES
        ///  (
        ///    UPPER ( &quot;{1}&quot; )
        ///  , UPPER ( &quot;{2}&quot; )
        ///  ).
        /// </summary>
        internal static string InsertRecord {
            get {
                return ResourceManager.GetString("InsertRecord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT  tabela.serie_item
        ///     ,  tabela.codigo_item
        ///     ,  tabela.descricao_item
        ///  FROM  OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  lor_man_item.num_serie_lmi      AS serie_item
        ///           ,  TRIM ( lor_man_item.cod_item )  AS codigo_item
        ///           ,  TRIM ( lor_man_item.den_item )  AS descricao_item
        ///        FROM  lor_man_item
        ///        WHERE lor_man_item.cod_item = &quot;{1}&quot;
        ///  &apos;
        ///  ) AS tabela.
        /// </summary>
        internal static string QueryRecordAk {
            get {
                return ResourceManager.GetString("QueryRecordAk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT  tabela.serie_item
        ///     ,  tabela.codigo_item
        ///     ,  tabela.descricao_item
        ///  FROM  OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  lor_man_item.num_serie_lmi      AS serie_item
        ///           ,  TRIM ( lor_man_item.cod_item )  AS codigo_item
        ///           ,  TRIM ( lor_man_item.den_item )  AS descricao_item
        ///        FROM  lor_man_item
        ///        WHERE 1=1
        ///        {1}
        ///        ORDER BY lor_man_item.cod_item
        ///  &apos;
        ///  ) AS tabela.
        /// </summary>
        internal static string QueryRecordAll {
            get {
                return ResourceManager.GetString("QueryRecordAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT  tabela.serie_item
        ///     ,  tabela.codigo_item
        ///     ,  tabela.descricao_item
        ///  FROM  OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  lor_man_item.num_serie_lmi      AS serie_item
        ///           ,  TRIM ( lor_man_item.cod_item )  AS codigo_item
        ///           ,  TRIM ( lor_man_item.den_item )  AS descricao_item
        ///        FROM  lor_man_item
        ///        WHERE lor_man_item.num_serie_lmi = {1}
        ///  &apos;
        ///  ) AS tabela.
        /// </summary>
        internal static string QueryRecordPk {
            get {
                return ResourceManager.GetString("QueryRecordPk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Item.
        /// </summary>
        internal static string TableDescription {
            get {
                return ResourceManager.GetString("TableDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a lor_man_item.
        /// </summary>
        internal static string TableName {
            get {
                return ResourceManager.GetString("TableName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a UPDATE  OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  lor_man_item.cod_item AS codigo_item
        ///           ,  lor_man_item.den_item AS descricao_item
        ///        FROM  lor_man_item
        ///        WHERE lor_man_item.num_serie_lmi = {1}
        ///    &apos;
        ///  ) 
        ///  SET  codigo_item = UPPER ( &quot;{2}&quot; )
        ///    ,  descricao_item = UPPER ( &quot;{3}&quot;).
        /// </summary>
        internal static string UpdateRecord {
            get {
                return ResourceManager.GetString("UpdateRecord", resourceCulture);
            }
        }
    }
}
