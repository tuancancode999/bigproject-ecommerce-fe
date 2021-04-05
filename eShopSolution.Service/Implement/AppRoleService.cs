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
    public class AppRoleService : IAppRoleService
    {
        private readonly IAppRoleRepository _appRoleRepository;
        private readonly EShopSolutionDBContext _context;
        private IMapper _mapper;
        public AppRoleService(EShopSolutionDBContext context, IMapper mapper, IAppRoleRepository appRoleRepository)
        {
            _context = context;
            _mapper = mapper;
            _appRoleRepository = appRoleRepository;
        }
        public async Task<AppRole> AddAppUserAsync(AppRoleCreateRequest request)
        {
            var Data = _mapper.Map<AppRole>(request);
            return await _appRoleRepository.AddAsync(Data);
        }

        public Task DeleteAppRoleAsync(AppRole appRole)
        {
            return _appRoleRepository.DeleteAsync(appRole);
        }

        public IEnumerable<AppRole> GetAllAppRoleAsync()
        {
            return _appRoleRepository.GetAll();
        }

        public async Task<AppRole> GetAppRoleByIdAsync(Guid id)
        {
            return await _appRoleRepository.GetAppRoleIdAsync(id);
        }

        public async Task<AppRole> UpdateAppUserAsync(AppRoleEditRequest request)
        {
            var Data = _mapper.Map<AppRole>(request);
            return await _appRoleRepository.UpdateAsync(Data);
        }
    }
}
