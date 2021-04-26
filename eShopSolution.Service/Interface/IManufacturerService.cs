using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Service.Interface
{
    public interface IManufacturerService
    {
        Task<Manufacturer> AddManufacturerAsync(ManufacturerCreateRequest request);

        Task<Manufacturer> UpdateManufacturerAsync(ManufacturerEditRequest request);

        Task DeleteManufacturerAsync(Manufacturer manufacturer);

        IEnumerable<Manufacturer> GetAllManufacturerAsync();

        Task<Manufacturer> GetManufacturerByIdAsync(int id);
    }
}
