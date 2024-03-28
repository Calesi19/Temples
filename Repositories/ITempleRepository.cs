using Temples.Data.Models;

namespace Temples.Repositories;

public interface ITempleRepository
{
    Task<IEnumerable<Temple>> FindAll();
    Task<Temple> FindById(Guid id);
    Task<Guid> Create(Temple temple);
    Task<bool> Update(Temple temple);
    Task<bool> DeleteById(Guid id);
}