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
    public class PromotionService : IPromotionService
    {
        private readonly IPromotionRepository _promotionRepository;
        private readonly EShopSolutionDBContext _context;
        private IMapper _mapper;
        public PromotionService(IPromotionRepository promotionRepository, EShopSolutionDBContext context, IMapper mapper)
        {
            _promotionRepository = promotionRepository;
            _context = context;
            _mapper = mapper;
        }
        public async Task<Promotion> AddManufacturerAsync(PromotionCreateRequest request)
        {
            var Promotion = _mapper.Map<Promotion>(request);
            return await _promotionRepository.AddAsync(Promotion);
        }

        public Task DeletePromotionAsync(Promotion promotion)
        {
            return _promotionRepository.DeleteAsync(promotion);
        }

        public IEnumerable<Promotion> GetAllPromotionAsync()
        {
            return _promotionRepository.GetAll();
        }

        public async Task<Promotion> GetPromotionByIdAsync(int id)
        {
            return await _promotionRepository.GetPromotionByIdAsync(id);
        }

        public async Task<Promotion> UpdatePromotionAsync(PromotionEditRequest request)
        {
            var Promotion = _mapper.Map<Promotion>(request);
            return await _promotionRepository.UpdateAsync(Promotion);
        }
    }
}
