using eShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Repository.Interface
{
   public interface INotificationRepository : IRepository<Notification>
    {
        Task<Notification> GetNotificationByIdAsync(int id);
    }

}
