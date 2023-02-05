using System.Collections.ObjectModel;

namespace MixERP.Net.DatabaseLayer.EF.Core.Interfaces
{
    public interface IFlagsService
    {
        Task<int> CreateFlag(int userId, int flagTypeId, string resourceName, string resourceKey, Collection<int> resourceIds);
        Task<int> RemoveFlagsFromDb();
    }
}