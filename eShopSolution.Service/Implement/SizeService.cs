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
    public class SizeService : ISizeService
    {
        private readonly ISizeRepository _sizeRepository;
        private readonly EShopSolutionDBContext _context;
        private IMapper _mapper;
        public SizeService(ISizeRepository sizeRepository, EShopSolutionDBContext context, IMapper mapper)
        {
            _sizeRepository = sizeRepository;
            _context = context;
            _mapper = mapper;
        }
    
        public async Task<Sizes> AddSizeAsync(SizeCreateRequest request)
        {
            var Size = _mapper.Map<Sizes>(request);
            return await _sizeRepository.AddAsync(Size);
        }

        public Task DeleteSizeAsync(Sizes sizes)
        {
            return _sizeRepository.DeleteAsync(sizes);
        }

        public IEnumerable<Sizes> GetAllSizeAsync()
        {
            return _sizeRepository.GetAll();
        }

        public async Task<Sizes> GetSizesByIdAsync(int id)
        {
            return await _sizeRepository.GetSizeByIdAsync(id);
        }

        public async Task<Sizes> UpdateSizeAsync(SizeEditRequest request)
        {
            var Size = _mapper.Map<Sizes>(request);
            return await _sizeRepository.UpdateAsync(Size);
        }
    }
}
