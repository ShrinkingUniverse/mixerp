using System.Collections.ObjectModel;

namespace MixERP.Net.DatabaseLayer.EF.Core
{
    public interface IFlagsService
    {
        void CreateFlag(int userId, int flagTypeId, string resourceName, string resourceKey, Collection<int> resourceIds);
    }
}