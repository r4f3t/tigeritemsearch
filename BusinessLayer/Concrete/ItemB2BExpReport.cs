using ItemSearchTiger.BusinessLayer.Abstract;
using ItemSearchTiger.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;

namespace ItemSearchTiger.BusinessLayer.Concrete
{
    public class ItemB2BExpReportManager : IItemB2BExpReport
    {
        IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DapperConnectionString"].ConnectionString);
        public IEnumerable<ItemWithExp> GetItems()
        {
            using (db)
            {
                var result = db.Query<ItemWithExp>("select  I.LOGICALREF,I.CODE,I.NAME,I.NAME2,I.NAME3,I.SPECODE,I.SPECODE2,I.SPECODE3,I.SPECODE4,I.STGRPCODE,I.PRODUCERCODE,B2BACK1,B2BACK2,B2BACK3,B2BACK4,B2BACK5 from LG_206_ITEMS as I left outer  join LG_XT1001_206 as X on I.LOGICALREF=X.PARLOGREF order by I.CODE asc");
                return result;
            }
        }
    }
}
