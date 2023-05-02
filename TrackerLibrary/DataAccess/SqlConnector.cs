using Dapper;
using System.Data;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Saves a new prize to the database.
        /// </summary>
        /// <param name="model">The prize being saved.</param>
        /// <returns>The prize with the ID initialized.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("Tournaments"));
            var parameters = new DynamicParameters();
            parameters.Add("@PlaceNumber", model.PlaceNumber);
            parameters.Add("@PlaceName", model.PlaceName);
            parameters.Add("@PrizeAmount", model.PrizeAmount);
            parameters.Add("@PrizePercentage", model.PrizePercentage);
            // ID generated on DB side is expected as output from executing the stored procedure
            parameters.Add("@id", 0, dbType: DbType.Int16, direction: ParameterDirection.Output);

            // name of the stored procedure is dbo.spPrize_Insert
            connection.Execute("dbo.spPrize_Insert", parameters, commandType: CommandType.StoredProcedure);

            model.Id = parameters.Get<short>("@id");

            return model;
        }
    }
}
