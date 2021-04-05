using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Repository.Implement
{
    public class NotificationRepository : Repository<Notification>, INotificationRepository
    {
        public NotificationRepository(EShopSolutionDBContext EShopSolutionDBContext) : base(EShopSolutionDBContext)
        {
        }


        public Task<Notification> GetNotificationByIdAsync(int id)
        {
            return GetAll().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
