using ItemSearchTiger.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemSearchTiger.BusinessLayer
{
    public class ItemSearchManager : IItemSearchService
    {
        TIGEREntities db = new TIGEREntities();
        public ICollection<string> GetItems(string searchKey)
        {
            var stringProperties = typeof(LG_206_ITEMS).GetProperties().Where(prop =>
    prop.PropertyType == searchKey.GetType());

            var query = db.LG_206_ITEMS.AsQueryable();
            query=query.Where(x =>
    stringProperties.Any(prop =>
        prop.GetValue(x, null) == query));

            return query.Select(x => x.CODE).ToList();
        }
    }
}
