using System.Collections.Generic;
using System.Threading.Tasks;
using MyOnionApi.Application.Features.Positions.Queries.GetPositions;
using MyOnionApi.Application.Parameters;
using MyOnionApi.Domain.Entities;

namespace MyOnionApi.Application.Interfaces.Repositories
{
    public interface IPositionRepositoryAsync : IGenericRepositoryAsync<Position>
    {
        Task<bool> IsUniquePositionNumberAsync(string positionNumber);

        Task<bool> SeedDataAsync(int rowCount);

        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> GetPagedPositionResponseAsync(GetPositionsQuery requestParameters);
    }
}