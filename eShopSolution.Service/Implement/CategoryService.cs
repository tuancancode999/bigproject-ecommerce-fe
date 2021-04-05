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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly EShopSolutionDBContext _context;
        private IMapper _mapper;
        public CategoryService( EShopSolutionDBContext context, IMapper mapper , ICategoryRepository categoryRepository)
        {
            _context = context;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }
        public async Task<Category> AddCategoryAsync(CategoryCreateRequest request)
        {
            var Category = _mapper.Map<Category>(request);
            return await _categoryRepository.AddAsync(Category);
        }

        public Task DeleteCategoryAsync(Category category)
        {
            return _categoryRepository.DeleteAsync(category);
        }

        public IEnumerable<Category> GetAllCategoryAsync()
        {
            return _categoryRepository.GetAll();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await _categoryRepository.GetCategoryByIdAsync(id);
        }

        public async Task<Category> UpdateCategoryAsync(CategoryEditRequest request)
        {
            var Category = _mapper.Map<Category>(request);
            return await _categoryRepository.UpdateAsync(Category);
        }
    }
}
