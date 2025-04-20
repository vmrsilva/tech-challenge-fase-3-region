using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechChallenge.Region.Domain.Region.Entity;

namespace TechChallenge.Region.Domain.Region.Service
{
    public interface IRegionService
    {
        Task CreateAsync(RegionEntity regionEntity);
        Task<RegionEntity> GetByIdAsync(Guid id);
        Task<RegionEntity> GetByIdWithCacheAsync(Guid id);
        Task<RegionEntity> GetByDdd(string ddd);
        Task DeleteByIdAsync(Guid id);
        Task<IEnumerable<RegionEntity>> GetAllPagedAsync(int pageSize, int page);
        Task UpdateAsync(RegionEntity regionEntity);
        Task<RegionEntity> GetByDddWithContacts(string ddd);
        Task<int> GetCountAsync();
    }
}
