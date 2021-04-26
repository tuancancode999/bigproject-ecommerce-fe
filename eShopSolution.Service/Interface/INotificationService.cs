using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Service.Interface
{
   public  interface INotificationService
    {
        Task<Notification> AddNotificationAsync(NotificationCreateRequest request);

        Task<Notification> UpdateNotificationAsync(NotificationEditRequest request);

        Task DeleteNotificationAsync(Notification notification);

        IEnumerable<Notification> GetAllNotificationAsync();

        Task<Notification> GetNotificationByIdAsync(int id);
    }
}
