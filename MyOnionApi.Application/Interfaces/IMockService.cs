using System.Collections.Generic;
using MyOnionApi.Domain.Entities;

namespace MyOnionApi.Application.Interfaces
{
    public interface IMockService
    {
        List<Position> GetPositions(int rowCount);
        List<Employee> GetEmployees(int rowCount);
        List<Position> SeedPositions(int rowCount);
    }
}