using CondominiumManagerApi.Core.Entities;
using CondominiumManagerApi.Core.Entities.Common;
using CondominiumManagerApi.Core.Results;
using CondominiumManagerApi.Infrastructure.SqlServer.Repositories.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace CondominiumManagerApi.Infrastructure.SqlServer.Repositories
{
    public class CondominiumRepository(SqlSettings sqlSettings) : ICondominiumRepository
    {
        public async Task<Condominium> GetById(long id)
        {

            var query = @"SELECT [Id]
                             ,[Name]
                             ,[Street]
                             ,[Number]
                             ,[Neighborhood]
                             ,[City]
                             ,[State]
                             ,[ZipCode]
                         FROM [dbo].[Condominium] WITH(NOLOCK,NOWAIT) WHERE [Id] = @id";


            using var connection = new SqlConnection(sqlSettings.ConnectionString);
            return await connection.QueryFirstOrDefaultAsync<Condominium>(query, new { id }, commandTimeout: 160);
        }
    }
}