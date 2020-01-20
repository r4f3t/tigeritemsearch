using ItemSearchTiger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemSearchTiger.BusinessLayer.Abstract
{
public interface IItemB2BExpReport
    {
        IEnumerable<ItemWithExp> GetItems();
    }
}
