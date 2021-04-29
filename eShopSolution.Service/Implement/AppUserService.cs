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
   public class AppUserService : IAppUserService
    {
        private readonly IAppUserRepository _appUserRepository;
        private readonly EShopSolutionDBContext _context;
        private IMapper _mapper;
        public AppUserService(EShopSolutionDBContext context, IMapper mapper, IAppUserRepository appUserRepository)
        {
            _context = context;
            _mapper = mapper;
            _appUserRepository = appUserRepository;
        }
        public Task DeleteAppUserAsync(AppUser appUser)
        {
            return _appUserRepository.DeleteAsync(appUser);
        }

        public IEnumerable<AppUser> GetAllAppUserAsync()
        {
            return _appUserRepository.GetAll();
        }

        public async Task<AppUser> GetAppUserByIdAsync(Guid id)
        {
            return await _appUserRepository.GetAppUserIdAsync(id);
        }

        public async Task<AppUser> UpdateAppUserAsync(AppUserEditRequest request)
        {
            var Data = _mapper.Map<AppUser>(request);
            return await _appUserRepository.UpdateAsync(Data);
        }
    }
}
