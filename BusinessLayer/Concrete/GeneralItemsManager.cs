using ItemSearchTiger.BusinessLayer.Abstract;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using Dapper;
using System.Threading.Tasks;

namespace ItemSearchTiger.BusinessLayer.Concrete
{
    public class GeneralItemsManager : IGeneralItemsService
    {
        IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DapperConnectionString"].ConnectionString);
        public async Task<IEnumerable<string>> GetSpecodes()
        {
            using (db)
            {
                var result = await db.QueryAsync<string>("select SPECODE from LG_206_ITEMS group by SPECODE");
                return  result.OrderBy(x=>x);
            }
        }
    }
}
