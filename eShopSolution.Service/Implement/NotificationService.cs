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
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _notificationRepository;
        private readonly EShopSolutionDBContext _context;
        private IMapper _mapper;
        public NotificationService(EShopSolutionDBContext context, IMapper mapper, INotificationRepository notificationRepository)
        {
            _context = context;
            _mapper = mapper;
            _notificationRepository = notificationRepository;
        }
        public async Task<Notification> AddNotificationAsync(NotificationCreateRequest request)
        {
            var Notification = _mapper.Map<Notification>(request);
            return await _notificationRepository.AddAsync(Notification);
        }

        public Task DeleteNotificationAsync(Notification notification)
        {
            return _notificationRepository.DeleteAsync(notification);
        }

        public IEnumerable<Notification> GetAllNotificationAsync()
        {
            return _notificationRepository.GetAll();
        }

        public async Task<Notification> GetNotificationByIdAsync(int id)
        {
            return await _notificationRepository.GetNotificationByIdAsync(id);

        }

        public async Task<Notification> UpdateNotificationAsync(NotificationEditRequest request)
        {
            var Notification = _mapper.Map<Notification>(request);
            return await _notificationRepository.UpdateAsync(Notification);
        }
    }
}
