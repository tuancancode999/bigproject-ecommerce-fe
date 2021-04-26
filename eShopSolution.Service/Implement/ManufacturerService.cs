using AutoMapper;
using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.Repository.Interface;
using eShopSolution.Service.Interface;
using eShopSolution.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Service.Implement
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly IManufacturerRepository _manufacturerRepository;
        private readonly EShopSolutionDBContext _context;
        private IMapper _mapper;
        public ManufacturerService(EShopSolutionDBContext context, IMapper mapper, IManufacturerRepository manufacturerRepository)
        {
            _context = context;
            _mapper = mapper;
            _manufacturerRepository = manufacturerRepository;
        }
        public async Task<Manufacturer> AddManufacturerAsync(ManufacturerCreateRequest request)
        {
            var Manufacturer = _mapper.Map<Manufacturer>(request);
            return await _manufacturerRepository.AddAsync(Manufacturer);
        }

        public Task DeleteManufacturerAsync(Manufacturer manufacturer)
        {
            return _manufacturerRepository.DeleteAsync(manufacturer);
        }

        public IEnumerable<Manufacturer> GetAllManufacturerAsync()
        {
            return _manufacturerRepository.GetAll();
        }

        public async Task<Manufacturer> GetManufacturerByIdAsync(int id)
        {
            return await _manufacturerRepository.GetManufacturerByIdAsync(id);
        }

        public async Task<Manufacturer> UpdateManufacturerAsync(ManufacturerEditRequest request)
        {
            var Manufacturer = _mapper.Map<Manufacturer>(request);
            return await _manufacturerRepository.UpdateAsync(Manufacturer);
        }
    }
}
