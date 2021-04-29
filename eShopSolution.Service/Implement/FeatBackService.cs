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
    public class FeatBackService : IFeatBackService
    {
        private readonly IFeatBackRepository _featBackRepository;
        private readonly EShopSolutionDBContext _context;
        private IMapper _mapper;
        public FeatBackService(EShopSolutionDBContext context, IMapper mapper, IFeatBackRepository featBackRepository)
        {
            _context = context;
            _mapper = mapper;
            _featBackRepository = featBackRepository;
        }

        public async Task<FeatBack> AddCategoryAsync(FeatBackCreateRequest request)
        {
            var FeatBack = _mapper.Map<FeatBack>(request);
            return await _featBackRepository.AddAsync(FeatBack);
        }

        public Task DeleteFeatBackAsync(FeatBack featBack)
        {
            return _featBackRepository.DeleteAsync(featBack);
        }
   

        public IEnumerable<FeatBack> GetAllFeatBackAsync()
        {
            return _featBackRepository.GetAll();
        }

        public async Task<FeatBack> GetFeatBackByIdAsync(int id)
        {
            return await _featBackRepository.GetFeatBackByIdAsync(id);
        }

        public async Task<FeatBack> UpdateCategoryAsync(FeatBackEditRequest request)
        {
            var FeatBack = _mapper.Map<FeatBack>(request);
            return await _featBackRepository.UpdateAsync(FeatBack);
        }
    }
}
