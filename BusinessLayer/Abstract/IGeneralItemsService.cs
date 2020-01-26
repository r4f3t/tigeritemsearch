using System.Collections.Generic;
using System.Threading.Tasks;

namespace ItemSearchTiger.BusinessLayer.Abstract
{
    public interface IGeneralItemsService
    {
        Task<IEnumerable<string>> GetSpecodes();
    }
}
