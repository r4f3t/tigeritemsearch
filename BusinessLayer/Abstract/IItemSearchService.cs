using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemSearchTiger.BusinessLayer.Abstract
{
    public interface IItemSearchService
    {
        ICollection<string> GetItems(string searchKey);
        ICollection<string> GetItemsTigerStr(string searchKey);
    }
}
